using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fablabo.Models
{
    public class Skill
    {
        public Int32 SkillId { get; set; }
        public String Name { get; set; }
        public String BadgeUrl { get; set; }
        public Int32 Level { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
