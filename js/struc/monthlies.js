const http = require('../http/index.js')


const Monthlies = class {


  constructor(mode) {
    this.game = mode
  }

  lb(start, end) {
    var url
    if(start)
     url = `https://api.rocco.dev/${this.game}/monthlies/leaderboard?from=${start}&to=${end}`
    else
     url = `https://api.rocco.dev/${this.game}/monthlies/leaderboard`

    return http(url)
  }

  profile(uuid) {
    const url = `https://api.rocco.dev/${this.game}/monthlies/profile/${uuid}`
    return http(url)
  }

}

module.exports = Monthlies
