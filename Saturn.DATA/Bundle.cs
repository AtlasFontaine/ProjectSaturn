using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn.DATA
{
    public class Bundle
    {
        public int BundleID { get; set; }
        public List<Issue> IssuesOfBundle { get; set; }
        public List<User> UsersOfBundle { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
