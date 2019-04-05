const http = require('../http/index.js')

const Winstreaks = class {


  constructor(mode) {
    this.game = mode
  }

  lb(start, end) {
    var url
    if(start)
     url = `https://api.rocco.dev/${this.game}/winstreaks/leaderboard?from=${start}&to=${end}`
    else
     url = `https://api.rocco.dev/${this.game}/winstreaks/leaderboard`

    return http(url)
  }

  profile(uuid) {
    const url = `https://api.rocco.dev/${this.game}/winstreaks/profile/${uuid}`
    return http(url)
  }


}

module.exports = Winstreaks
