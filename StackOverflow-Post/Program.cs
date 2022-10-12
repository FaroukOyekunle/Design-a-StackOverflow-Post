// See https://aka.ms/new-console-template for more information
using StackOverflow_Post;


var solutionPost = new BlogPost();

solutionPost.Title = "Adding a README.md file to a c# project in Visual Studio 2015";
solutionPost.Description = "Look in the top of the solution explorer for the option add hidden files. It should appear with dotted outline.\n If you wish to add it to the project you can right click and press \"add to project\"";
solutionPost.CreatedTime = new DateTime(2022, 10, 12);

solutionPost.VoteUp();
solutionPost.VoteUp();
solutionPost.VoteUp();
solutionPost.VoteUp();
solutionPost.VoteUp();
solutionPost.VoteUp();
solutionPost.VoteUp();
solutionPost.VoteUp();

Console.WriteLine("BlogPost Should Have 8 Votes");

solutionPost.PrintFullPost();

solutionPost.VoteDown();
solutionPost.VoteDown();
solutionPost.VoteDown();
Console.WriteLine("BlogPost Should Have 2 Votes");
solutionPost.PrintFullPost();

