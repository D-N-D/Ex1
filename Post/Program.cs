using System;

namespace Post
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var post = new Post();
            Console.WriteLine(post.Title+"|");

            post.Title = "Title1";
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Vote);

            post.UpVote();
            post.UpVote();

           // post.Vote = 5;

            Console.WriteLine(post.Vote);

            post.DownVote();

			Console.WriteLine(post.Vote);
		}
    }
}
