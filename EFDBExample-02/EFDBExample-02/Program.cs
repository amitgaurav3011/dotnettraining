using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBExample_02
{
    class Program
    {
        static void Main(string[] args)
        {
            using(BlogPostDBEntities bpdb=new BlogPostDBEntities())
            {
                //bpdb.Blogs.Add(new Blog { Name = "Test Blog1" });
                //bpdb.Blogs.Add(new Blog { Name = "Test Blog2" });
                //bpdb.Blogs.Add(new Blog { Name = "Test Blog3" });

                Blog blog = bpdb.Blogs.FirstOrDefault(b => b.Name == "Test Blog1");
                bpdb.Posts.Add(new Post { Title = "Test Post1", Content = "my first post", BlogId = blog.BlogId });

                Blog blog1 = bpdb.Blogs.FirstOrDefault(b => b.Name == "Test Blog3");
                bpdb.Posts.Add(new Post { Title = "Test Post2", Content = "my second post", BlogId = blog1.BlogId });

                bpdb.SaveChanges();
            }
        }
    }
}
