using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EFSample
{
    // class : Post 
    public class Post
    {
        // Properties 
        public int Id { get; set; }
        public DateTime PublishTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
    // BlogDbContext 
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=POSTS;User Id=SA;Password=MyPassword#321;TrustServerCertificate=True");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new BlogDbContext())
            {
                // input title 
                Console.WriteLine("Enter the title: ");
                string TitleConsole = Console.ReadLine();

                // create a new post
                var NewPost = new Post()
                {
                    PublishTime = DateTime.Now,
                    Title = TitleConsole,
                    Body = "Body of the blog"
                };

                // add to the context
                context.Posts.Add(NewPost);
                context.SaveChanges();

                // view all the post 
                foreach (var item in context.Posts) {
                    Console.WriteLine(item.Title);
                }
            }
        }
    }
}