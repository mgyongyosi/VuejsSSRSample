const path = require('path');

module.exports = {
    entry: path.join(__dirname, 'VueApp/client.js'),
    output: {
        path: path.join(__dirname, 'wwwroot/dist'),
        filename: 'bundle.client.js',
    },
    module: {
        loaders: [
          {
              test: /\.vue$/,
              loader: 'vue',
          },
          {
              test: /\.js$/,
              loader: 'babel',
              include: __dirname,
              exclude: /node_modules/
          },
        ]
    },
};
