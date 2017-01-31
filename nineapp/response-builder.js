var ResponseBuilder;

// load modules
var Verifier = require("./json-verifier.js");

//create module
ResponseBuilder = {
    /* vars */

    ERROR_MESSAGE: "Could not decode request: JSON parsing failed",

    /* end vars */


    /* functions */

    // returns false if the json in invalid or a json response object if it is valid
    buildResponse: function(req) {
        // make sure the json is valid and is in object form
        if (!Verifier.verifyJSON(req)) {
            return false;
        } else {
            req = Verifier.parseJSON(req);
        }

        //setup response structure
        var responseArr = [];
        var response = { "response": responseArr };

        //run through each item in payload array and filter the request into a response
        for (var i = 0; i < req.payload.length; i++) {
            if (Verifier.verifyItem(req.payload[i])) {
                var item = this.buildItem(i, req);
                response.response.push(item);
            }
        }
        return response
    },

    // returns a json error message object
    buildErrorResponse: function() {
        return { "error": this.ERROR_MESSAGE };
    },

    // returns a single response item
    buildItem: function(index, req) {
        var responseItem = {};
        responseItem.image = this.getImage(index, req);
        responseItem.slug = this.getSlug(index, req);
        responseItem.title = this.getTitle(index, req);
        return responseItem;
    },

    //returns the image url from a specific index in a request
    getImage: function(index, req) {
        return req.payload[index].image.showImage;
    },

    //returns the slug from a specific index in a request
    getSlug: function(index, req) {
        return req.payload[index].slug;
    },

    //returns the title from a specific index in a request
    getTitle: function(index, req) {
        return req.payload[index].title;
    }

    /* end functions */
}

module.exports = ResponseBuilder;