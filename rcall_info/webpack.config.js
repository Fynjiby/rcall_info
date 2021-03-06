"use strict";

var isDevBuild = process.argv.indexOf('--env.prod') < 0;
var devConfig = require("./build/webpack.dev.conf");
var prodConfig = require("./build/webpack.prod.conf");
var baseConfig = require("./build/webpack.base.conf");

module.exports = baseConfig;
