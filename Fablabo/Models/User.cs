using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fablabo.Models
{
    public class User : IdentityUser
    {
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String ImageUrl { get; set; }
        public String Description { get; set; }

        public ICollection<Skill> Skills { get; set; }

    }
}
