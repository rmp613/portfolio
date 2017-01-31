'use strict'

// load modules
var expect = require('chai').expect;
var Verifier = require('../json-verifier');

/* example vars that are used in multiple tests \/ */

// a good example of a json object in a request.payload
var exampleGoodJSONObj = {
    "drm": true,
    "episodeCount": 3,
    "image": {
        "showImage": "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg"
    },
    "slug": "show/16kidsandcounting",
    "title": "16 Kids and Counting"
};

// an example good json string equal the the below object \/
var exampleJSONStr = '{"payload":[{"country":"UK"}]}';

// an example good json object equal to the above string  /\
var exampleJSONObj = {
    "payload": [
        { "country": "UK" }
    ]
};

// episodeCount is not more than 0 here
var exampleBadEpisodeCountObject = {
    "drm": false,
    "episodeCount": 0,
    "image": {
        "showImage": "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg"
    },
    "slug": "show/16kidsandcounting",
    "title": "16 Kids and Counting"
};

// drm is disabled here \/
var exampleBadDrmObject = {
    "drm": false,
    "episodeCount": 3,
    "image": {
        "showImage": "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg"
    },
    "slug": "show/16kidsandcounting",
    "title": "16 Kids and Counting"
};

/* end example vars */


describe('JSONVerifier', function() {
    it('should exist', function() {
        expect(Verifier).to.not.be.undefined;
    });


    describe('#verifyJSON()', function() {
        it('should exist', function() {
            expect(Verifier.verifyJSON).to.not.be.undefined;
        });

        it('should take a string and verify that it is valid JSON', function() {
            // there is an extra comma after UK here \/ making this invalid json
            var exampleBadJSONStr = '{"payload":[{"country":"UK",}]}';

            expect(Verifier.verifyJSON(exampleJSONStr)).to.be.true;
            expect(Verifier.verifyJSON(exampleBadJSONStr)).to.be.false;
        });
    });


    describe('#verifyItem()', function() {
        it('should exist', function() {
            expect(Verifier.verifyItem).to.not.be.undefined;
        });

        it('should take an item and verify that it had the correct fields and correct details', function() {
            var result = Verifier.verifyItem(exampleGoodJSONObj);
            expect(result).to.be.true;
            result = Verifier.verifyItem(exampleBadDrmObject);
            expect(result).to.be.false;
            result = Verifier.verifyItem(exampleBadEpisodeCountObject);
            expect(result).to.be.false;
        });
    });


    describe('#verifyFields()', function() {
        it('should exist', function() {
            expect(Verifier.verifyFields).to.not.be.undefined;
        });

        it('should take an object and verify the required fields are', function() {
            // episodeCount is missing here \/
            var exampleBadFieldsJSONObj = {
                "drm": true,
                "image": {
                    "showImage": "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg"
                },
                "slug": "show/16kidsandcounting",
                "title": "16 Kids and Counting"
            };
            expect(Verifier.verifyFields(exampleGoodJSONObj)).to.be.true;
            expect(Verifier.verifyFields(exampleBadFieldsJSONObj)).to.be.false;
        });
    });


    describe('#verifyDetails()', function() {
        it('should exist', function() {
            expect(Verifier.verifyDetails).to.not.be.undefined;
        });

        it('should take an object and verify that drm is enabled', function() {
            var correctDetails = Verifier.verifyDetails(exampleGoodJSONObj);
            expect(correctDetails).to.be.true;
            correctDetails = Verifier.verifyDetails(exampleBadDrmObject);
            expect(correctDetails).to.be.false;
        });

        it('should take an object and return true if obj.episodeCount > 0 and obj.drm = true', function() {
            var correctDetails = Verifier.verifyDetails(exampleGoodJSONObj);
            expect(correctDetails).to.be.true;
        });

        it('should take an object and return false if obj.episodeCount = 0', function() {
            var correctDetails = Verifier.verifyDetails(exampleBadEpisodeCountObject);
            expect(correctDetails).to.be.false;
        });

        it('should take an object and return false if obj.drm = false', function() {
            var correctDetails = Verifier.verifyDetails(exampleBadDrmObject);
            expect(correctDetails).to.be.false;
        });
    });


    describe('#stringifyJSON()', function() {
        it('should exist', function() {
            expect(Verifier.stringifyJSON).to.not.be.undefined;
        });

        it('should take a json object and stringify it', function() {
            var exampleJSONObj = {
                "payload": [
                    { "country": "UK" }
                ]
            };

            expect(Verifier.stringifyJSON(exampleJSONObj)).to.eql(exampleJSONStr);
        });

        it('should take a json string and return it unchanged', function() {
            expect(Verifier.stringifyJSON(exampleJSONStr)).to.eql(exampleJSONStr);
        });

        it('should take an variable which is not an object and not a string and return false', function() {
            var exampleNonJSONVar = true;
            expect(Verifier.stringifyJSON(exampleNonJSONVar)).to.be.false;
        });
    });


    describe('#parseJSON()', function() {
        it('should exist', function() {
            expect(Verifier.parseJSON).to.not.be.undefined;
        });

        it('should take a json string and parse it', function() {


            expect(Verifier.parseJSON(exampleJSONStr)).to.eql(exampleJSONObj);
        });

        it('should take a json object and return it unchanged', function() {
            expect(Verifier.parseJSON(exampleJSONObj)).to.eql(exampleJSONObj);
        });

        it('should take an variable which is not an object and not a string and return false', function() {
            var exampleNonJSONVar = true;
            expect(Verifier.parseJSON(exampleNonJSONVar)).to.be.false;
        });
    });
});