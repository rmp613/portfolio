'use strict'

// load modules
var app = require('../index.js');
var expect = require('chai').expect;
var request = require('supertest');
var Builder = require('../response-builder.js');

describe('App', function() {
    it('should exist', function() {
        expect(app).to.not.be.undefined;
    });


    /* regression tests */

    describe("POST", function() {
        it('should respond with a filtered version of the request in a json response with status 200 for success', function(done) {
            // a good example json request
            var exampleRequest = {
                "payload": [{
                        "drm": true,
                        "episodeCount": 3,
                        "image": {
                            "showImage": "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg"
                        },
                        "slug": "show/16kidsandcounting",
                        "title": "16 Kids and Counting"
                    },
                    {
                        "slug": "show/seapatrol",
                        "title": "Sea Patrol",
                        "tvChannel": "Channel 9"
                    },
                    {
                        "drm": true,
                        "episodeCount": 2,
                        "image": {
                            "showImage": "http://mybeautifulcatchupservice.com/img/shows/TheTaste1280.jpg"
                        },
                        "slug": "show/thetaste",
                        "title": "The Taste"
                    }
                ]
            };
            // a good example json response
            var expectedResponse = {
                "response": [{
                        "image": "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg",
                        "slug": "show/16kidsandcounting",
                        "title": "16 Kids and Counting"
                    },
                    {
                        "image": "http://mybeautifulcatchupservice.com/img/shows/TheTaste1280.jpg",
                        "slug": "show/thetaste",
                        "title": "The Taste"
                    }
                ]
            };
            request(app)
                .post('/')
                .send(exampleRequest)
                .expect(200)
                .expect('Content-Type', "application/json; charset=utf-8")
                .end(function(err, res) {
                    expect(res.body).to.eql(expectedResponse);
                    done();
                });
        });

        it('should respond with a an error message and a status of 400 if the request is invalid json', function(done) {
            // have to use a string to create an invalid json request
            // this \/ is invalid json because there is no closing ]
            var exampleRequest = '{"payload":[{"country":"UK"}}';
            var expectedResponse = JSON.stringify(Builder.buildErrorResponse());
            request(app)
                .post('/')
                .send(exampleRequest)
                .expect(400)
                .expect('Content-Type', "application/json; charset=utf-8")
                .end(function(err, res) {
                    expect(res.text).to.eql(expectedResponse);
                    done();
                });
        });
    });

    /* end regression tests */


    describe("GET", function() {
        it('should send a 200 status for success and a message', function(done) {
            request(app)
                .get('/')
                .expect(200)
                .expect('Content-Type', "application/json; charset=utf-8")
                .end(function(err, res) {
                    expect(res.text).to.not.be.undefined;
                    expect(res.text).to.be.a('string');
                    expect(res.status).to.eql(200);
                    done()
                });
        });
    });
});