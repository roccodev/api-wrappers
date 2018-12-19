const request = require("request-promise")

const options = {
    json: true
}

function makePromise(url) {
  return request(url, options)
}

module.exports = makePromise
