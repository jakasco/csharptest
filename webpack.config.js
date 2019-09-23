const path = require("path");

module.exports = {
    entry: {
        index: "./wwwroot/js/src/index.js"
    },
    output: {
        path: path.resolve(__dirname, './wwwroot/js/dist'),
        filename: "index.js"
    },
    module: {
        rules: [
            {
                use: {
                    loader: "babel-loader"
                },
                test: /\.js$/,
                exclude: /node_modules/ //excludes node_modules folder from being transpiled by babel. We do this because it's a waste of resources to do so.
            },
            {
                use: {
                    loader: "babel-loader"
                },
                test: /\.jsx$/,
                exclude: /node_modules/ //excludes node_modules folder from being transpiled by babel. We do this because it's a waste of resources to do so.
            }
        ]
    }
}