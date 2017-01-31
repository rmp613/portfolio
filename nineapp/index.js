'use strict';

//load modules
var express = require('express');
var bodyParser = require('body-parser');
var Verifier = require('./json-verifier.js');
var Builder = require('./response-builder.js');

// create app
var app = express();
app.use(bodyParser.json());
app.use(errorHandler);


// return correct error response if there is an invalid json request or other unexpected error
function errorHandler(err, req, res, next) {
    res.status(400).json(Builder.buildErrorResponse());
}

// responds to POST requests by filtering the request into a response
app.post('/', function(req, res) {
    var response = Builder.buildResponse(req.body);
    // catch any invalid json code the error handler may have missed
    if (!response) {
        res.status(400).json(Builder.buildErrorResponse());
    } else {
        res.status(200).json(response);
    }
});

// responds to GET requests with a little information on the app
app.get('/', function(req, res) {
    var about = 'This app was designed for the 9Digital Coding Challenge. It will filter JSON data that is sent via POST.';
    res.send(about);
});

var port = process.env.PORT || 8080;

//start the server
app.listen(port, function() {
    console.log("Server running on port %d", port);
});

module.exports = app;