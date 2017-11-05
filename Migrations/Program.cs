using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDBContext dbContext = new MyDBContext())
            {
                var users = dbContext.Users.ToList();
            }
        }
    }
}
