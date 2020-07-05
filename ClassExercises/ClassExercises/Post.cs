using System;

namespace ClassExercises
{
    class Post
    {
        private int _voteCount = 0;
        public string PostContent { get; set; }
        public string PostTitle { get; set; }
        public DateTime DateCreated { get; private set; }

        public Post()
        {
            DateCreated = DateTime.Now;
        }


        public void UpVote()
        {
            _voteCount++;
        }

        public void DownVote()
        {
            _voteCount--;
        }

        public int GetVote()
        {
            return _voteCount;
        }

        public static void GeneratePosts()
        {
            var post1 = new Post();
            var post2 = new Post();

            post1.PostContent = "I am a sample post, hello!";
            post1.PostTitle = "Post 1";
            post2.PostContent = "I am another sample post, post 2! Hiya!";
            post2.PostTitle = "Post 2";
            post1.UpVote();
            post2.UpVote();
            post2.UpVote();
            post1.UpVote();
            post1.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.UpVote();
            post2.DownVote();
            post1.DownVote();
            Console.WriteLine($"***** {post1.PostTitle} *****");
            Console.WriteLine($"Created At: {post1.DateCreated}");
            Console.WriteLine(post1.PostContent);
            Console.WriteLine(post1.GetVote());
            Console.WriteLine($"***** {post2.PostTitle} *****");
            Console.WriteLine($"Created At: {post2.DateCreated}");
            Console.WriteLine(post2.PostContent);
            Console.WriteLine(post2.GetVote());
        }
    }
}
