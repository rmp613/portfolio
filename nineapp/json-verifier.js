var JSONVerifier;

// create module
JSONVerifier = {
    /* functions */

    // returns true if the passed in json is valid
    verifyJSON: function(json) {
        try {
            // make sure json is in string form and then parse it into an object - 
            // going either way successfully means the json is valid
            var jsonStr = JSONVerifier.stringifyJSON(json);
            if (!jsonStr) return false;
            var jsonObj = JSON.parse(jsonStr);
            if (typeof jsonObj.payload === 'undefined') return false;
        } catch (ex) {
            return false;
        }
        return true;
    },

    // returns true if the correct fields and details are present in the passed in item
    verifyItem: function(item) {
        if (this.verifyFields(item) && this.verifyDetails(item)) {
            return true;
        }
        return false;
    },

    // returns true if the required fields are present in the passed in item
    verifyFields: function(item) {
        if ("image" in item &&
            "showImage" in item.image &&
            "slug" in item &&
            "title" in item &&
            "drm" in item &&
            "episodeCount" in item) {
            return true;
        }
        return false;
    },

    // returns true if the item has > 0 episodes and drm is enabled
    verifyDetails: function(item) {
        if (item.episodeCount > 0 && item.drm) {
            return true;
        }
        return false;
    },

    //returns stringified JSON after checking that it isn't already stringified
    stringifyJSON: function(json) {
        if (typeof json === 'string') {
            return json;
        } else if (typeof json === 'object') {
            return JSON.stringify(json);
        } else {
            return false;
        }
    },

    //returns parsed JSON obj after checking that it isnt already parsed
    parseJSON: function(json) {
        if (typeof json === 'object') {
            return json;
        } else if (typeof json === 'string') {
            return JSON.parse(json);
        } else {
            return false;
        }
    }

    /* end functions */
};

module.exports = JSONVerifier;