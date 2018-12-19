const WS_BASE = "https://api.roccodev.pw/{game}/winstreaks/"

const Monthlies = require('./struc/monthlies.js')
const Winstreaks = require('./struc/streaks.js')
const HistoricalWinstreaks = require('./struc/histo.js')

function monthlies(game) {
  return new Monthlies(game)
}

function winstreaks(game) {
  return new Winstreaks(game)
}

function winstreaks_historical(game) {
  return new HistoricalWinstreaks(game)
}

module.exports = {monthlies, winstreaks, winstreaks_historical}
