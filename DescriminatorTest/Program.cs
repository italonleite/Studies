
using DescriminatorTest.Context;
using DescriminatorTest.Models;
using System;

namespace DescriminatorTest
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var db = new DiscriminatorTet())
            {
                var blog = new Blog()
                {
                    BlogId = 1,
                    Url = "www.xyz.com.br",
                };

                var rssBlog = new RssBlog()
                {
                             
                   RssUrl = "www.rss.com.br",
                };

                db.Add(blog);
                db.Add(rssBlog);
                db.SaveChanges();
                   
                


            }

        }
    }
}
