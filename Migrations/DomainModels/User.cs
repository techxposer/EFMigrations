using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.DomainModels
{
    public class User
    {
        [Key]
        public int Userid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
