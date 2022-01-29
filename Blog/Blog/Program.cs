using Blog.Context;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class Program
    {
        static void Main(string[] arg)
        {
            using(BlogContext db = new BlogContext())
            {
                User user1 = new User("Jesús", "1234", "jeschadee@gmail.com");
                db.Add(user1);
                db.SaveChanges();

                foreach(User user in db.Users)
                {
                    Console.WriteLine(user.Name);
                }

                Console.ReadKey();  
            }
        }
    }
}
