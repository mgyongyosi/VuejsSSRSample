const path = require('path');

module.exports = {
    target: 'node',
    entry: path.join(__dirname, 'VueApp/server.js'),
    output: {
        libraryTarget: 'commonjs2',
        path: path.join(__dirname, 'wwwroot/dist'),
        filename: 'bundle.server.js',
    },
    module: {
        loaders: [
          {
              test: /\.vue$/,
              loader: 'vue',
          },
          {
              test: /\.js$/,
              loader: 'babel-loader',
              include: __dirname,
              exclude: /node_modules/
          },
          {
              test: /\.json?$/,
              loader: 'json-loader'
          }
        ]
    },
    "resolveLoader": {
        "moduleExtensions": ["-loader"]
    }
};
