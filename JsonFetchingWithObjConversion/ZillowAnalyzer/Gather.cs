using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Gather{
	public class DataGather
	{
		public string data = string.Empty;
		static HttpClient client = new HttpClient();
		public async Task Data(string url)
		{
			string response = await client.GetStringAsync(url);
			data = response;
			
			

		}
	}
}