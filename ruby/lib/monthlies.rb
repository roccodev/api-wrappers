require 'net/http'
require 'json'

class Monthlies

    def initialize(game)
      @game = game
    end

    def leaderboard(*args)
      if args.length == 2
        url = "https://api.roccodev.pw/#{@game}/monthlies/leaderboard?from=#{args[0]}&to=#{args[1]}"
      else
        url = "https://api.roccodev.pw/#{@game}/monthlies/leaderboard"
      end
      uri = URI(url)
      res = Net::HTTP.get(uri)
      return JSON.parse(res)
    end

    def profile(uuid)
      url = "https://api.roccodev.pw/#{@game}/monthlies/profile/#{uuid}"
      uri = URI(url)
      res = Net::HTTP.get(uri)
      return JSON.parse(res)
    end

end
