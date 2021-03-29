using System.Threading.Tasks;
using System;
using Gather;

namespace ZillowAnalyzer
{
    class Program
    {

        static DataGather gatherer = new DataGather();
        static async Task Main(string[] args)
        {
           await  gatherer.Data("https://jsonplaceholder.typicode.com/posts/1");
            //new generated object
           Post.Post post  = Post.Post.NewPost(gatherer.data);
            //test
            Console.WriteLine(post.title);
            Console.WriteLine(post.id);
            Console.WriteLine(post.userId);
            Console.WriteLine(post.body);
        }
  
    }
}
