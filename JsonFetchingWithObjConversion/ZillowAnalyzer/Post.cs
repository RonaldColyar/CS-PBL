using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Post
{
	public class Post
	{
		public string userId;
		public string id;
		public string title;
		public string body;
		public Post(string json)
		{
			JObject jObj = JObject.Parse(json);


			id = jObj["id"].ToString();
			userId = jObj["userId"].ToString();
			title = jObj["title"].ToString();
			body = jObj["body"].ToString();

		}
		public static Post NewPost(string json)
		{
			return new Post(json);
		}
	}
}