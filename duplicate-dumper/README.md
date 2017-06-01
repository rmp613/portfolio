**Important information**: 
    I have only tested on a windows desktop PC.
    Its not foolproof and doesn't catch every single duplicate just the fairly obvious ones.
    I didn't confine the app to only music file extensions so it could work on duplicates of any file type.
    Good luck haha.
    
**READ THIS FIRST ^**


If you really want to use this here are your steps to making it work:
  1. Backup any folders that you are planning to unleash this app inside of
  2. Install npm and node.js from here http://nodejs.org/
  3. Download duplicate dumper and unzip (if needed)
  4. Open up any command line tool and navigate to the folder you downloaded/unzipped duplicate-dumper to
  5. Type the command "npm install" to install the required packages
  6. Once everything is installed you're good to start the node server with the command "npm start"
  7. Now heres the ~~fun~~ dumb part, open up any browser and navigate to localhost:3000/begin/YOURDRIVE-FOLDERLOCATION
    ie. localhost:3000/begin/C-Users-Riordan-Music
    
    You can watch what the app is checking if you keep your command line tool open.   
  8. Sometimes a package I use has an unhandled promise rejection error. If this happens the app stops at that point and 
  you will need to refresh your browser to restart the process (with every duplicate previously found already deleted)
  9. Enjoy your relatively clean music folders and remember if you delete something accidentally check the trash folder
