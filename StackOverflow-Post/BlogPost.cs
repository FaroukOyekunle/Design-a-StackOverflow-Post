using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class BlogPost
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public int Votes { get; private set; }


        public void VoteUp()
        {
            Votes++;
        }
        public void VoteDown()
        {
            Votes--;
        }

        public void PrintFullPost()
        {
            Console.WriteLine("Date Posted: " + CreatedTime.ToLongDateString());
            Console.WriteLine(Title);
            Console.WriteLine();
            Console.WriteLine(Description);
            Console.WriteLine();
            Console.WriteLine("Votes: " + Votes);

        }
    }
}
