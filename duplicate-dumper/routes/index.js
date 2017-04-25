var express = require('express');
var router = express.Router();
const trash = require('trash');
const fs = require("fs");
const Finder = require('fs-finder');
/* GET home page. */
router.get('/', function (req, res, next) {
  res.render('index', {
    title: 'Express'
  });
});

function getFilesizeInBytes(filename) {
  const stats = fs.statSync(filename)
  const fileSizeInBytes = stats.size
  return fileSizeInBytes
}

function getFileInfo(file) {
  let fileSize = getFilesizeInBytes(file);
  let fileStr = file.split('\\').pop();
  let fileExt = fileStr.split('.').pop();
  let fileSplit = fileStr.split('.');
  fileSplit.splice(fileSplit.length - 1, 1);
  let fileName = fileSplit.join('');
  let filePath = file.replace(fileStr, '');
  return {
    fileSize: fileSize,
    fileStr: fileStr,
    fileExt: fileExt,
    fileName: fileName,
    filePath: filePath
  }
}

function deleteFiles(info, files) {
  let trashPile = [];
  files.forEach((checkFile) => {

    let checkInfo = getFileInfo(checkFile);
    console.log('     against:', checkInfo.fileStr);


    if (checkInfo.fileStr !== info.fileStr &&
      checkInfo.fileStr.length > info.fileStr.length &&
      checkInfo.fileSize === info.fileSize) {
      console.log("vsed");
      trashPile.push(checkFile);
    }
  });
  if (trashPile.length > 0) {
    console.log('trashing:', trashPile);
    trash(trashPile).then((err) => {
      if (err) console.error(err);
      // console.log('trashed');
    });
  }
}
router.get('/begin/:location', (req, res, next) => {
  let location = req.params.location;
  location = location.replace(/-/, ':\\');
  location = location.replace(/-/g, '\\');
  console.log(location);
  //if (location === "C:\\Other\fordeletion.txt") {
  Finder.from(location).findFiles((files) => {
    // console.log(files);
    files.forEach((file) => {
      let info = getFileInfo(file);
      console.log('checking:', info.fileStr);

      // Finder.from(info.filePath).findFiles('*' + info.fileName + '*', (checkFiles) => {
      //   deleteFiles(info, checkFiles);
      // });
      Finder.from(info.filePath).findFiles('*' + info.fileName + '*', (checkFiles) => {
        deleteFiles(info, checkFiles);
      });
      Finder.from(info.filePath).findFiles('*' + info.fileName.toLowerCase() + '*', (checkFiles) => {
        deleteFiles(info, checkFiles);
      });
    })
  });
  // trash([location]).then(() => {
  //   console.log('done');
  // });
  // }else
});

module.exports = router;