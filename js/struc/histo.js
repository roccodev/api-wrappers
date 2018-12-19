const http = require('../http/index.js')

const HistoricalWinstreaks = class {


  constructor(mode) {
    this.game = mode
  }

  lb(start, end) {
    var url
    if(start)
     url = `https://api.roccodev.pw/${this.game}/winstreaks/historical/leaderboard?from=${start}&to=${end}`
    else
     url = `https://api.roccodev.pw/${this.game}/winstreaks/historical/leaderboard`

    return http(url)
  }

  profile(uuid) {
    const url = `https://api.roccodev.pw/${this.game}/winstreaks/historical/profile/${uuid}`
    return http(url)
  }


}

module.exports = HistoricalWinstreaks
