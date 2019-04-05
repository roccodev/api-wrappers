require 'net/http'
require 'json'

class HistoricalWinstreaks

    def initialize(game)
      @game = game
    end

    def leaderboard(*args)
      if args.length == 2
        url = "https://api.rocco.dev/#{@game}/winstreaks/historical/leaderboard?from=#{args[0]}&to=#{args[1]}"
      else
        url = "https://api.rocco.dev/#{@game}/winstreaks/historical/leaderboard"
      end
      uri = URI(url)
      res = Net::HTTP.get(uri)
      return JSON.parse(res)
    end

    def profile(uuid)
      url = "https://api.rocco.dev/#{@game}/winstreaks/historical/profile/#{uuid}"
      uri = URI(url)
      res = Net::HTTP.get(uri)
      return JSON.parse(res)
    end

end
