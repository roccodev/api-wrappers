using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace roccodevapi {
	
	public class HttpUtils {

		private static readonly HttpClient client = new HttpClient();

		private static Task<string> ReadFromUrl(string url) {
			return client.GetStringAsync(url);
		}

		public static Dictionary<string, T> MoProfs<T>(int start, int end) where T : MonthlyProfile {
            var shortcode = typeof(T).GetField("shortcode").GetValue(null);
            var task = ReadFromUrl($"https://api.rocco.dev/{shortcode}/monthlies/leaderboard?from={start}&to={end}");
			var res = JsonConvert.DeserializeObject<Dictionary<string, T>>(task.Result);
			return res;
		}

		public static T MoProf<T>(string uuid) where T : MonthlyProfile
		{
            var shortcode = typeof(T).GetField("shortcode").GetValue(null);
            var task = ReadFromUrl($"https://api.rocco.dev/{shortcode}/monthlies/profile/{uuid}");
			var res = JsonConvert.DeserializeObject<T>(task.Result);
			return res;
		}
		
		public static Dictionary<string, T> WiProfs<T>(int start, int end) where T : WinstreakProfile {
            var shortcode = typeof(T).GetMethod("ToString").Invoke(null, null);
			var task = ReadFromUrl($"https://api.rocco.dev/{shortcode}/winstreaks/leaderboard?from={start}&to={end}");
			var res = JsonConvert.DeserializeObject<Dictionary<string, T>>(task.Result);
			return res;
		}

		public static T WiProf<T>(string uuid) where T : WinstreakProfile
		{
            var shortcode = typeof(T).GetMethod("ToString").Invoke(null, null);
            var task = ReadFromUrl($"https://api.rocco.dev/{shortcode}/winstreaks/profile/{uuid}");
			var res = JsonConvert.DeserializeObject<T>(task.Result);
			return res;
		}
		
		public static Dictionary<string, T> HiProfs<T>(int start, int end) where T : WinstreakProfile {

            var shortcode = typeof(T).GetMethod("ToString").Invoke(null, null);
            var task = ReadFromUrl($"https://api.rocco.dev/{shortcode}/winstreaks/historical/leaderboard?from={start}&to={end}");
			var res = JsonConvert.DeserializeObject<Dictionary<string, T>>(task.Result);
			return res;
		}

		public static T HiProf<T>(string uuid) where T : WinstreakProfile
		{
            var shortcode = typeof(T).GetMethod("ToString").Invoke(null, null);
            var task = ReadFromUrl($"https://api.rocco.dev/{shortcode}/winstreaks/historical/profile/{uuid}");
			var res = JsonConvert.DeserializeObject<T>(task.Result);
			return res;
		}

	}
}

