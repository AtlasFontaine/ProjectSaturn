using Saturn.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn.DAL._Context
{
    public class SaturnContext:DbContext
    {
        public SaturnContext() : base("server=EMIRHAN;database=SaturnProject;user id=sa;password=emi12hanA") 
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> UserTable { get; set; }
        public DbSet<UserRole> UserRoleTable { get; set; }
        public DbSet<Bundle> BundleTable { get; set; }
        public DbSet<Issue> IssueTable { get; set; }
        public DbSet<Title> TitleTable { get; set; }
        public DbSet<Publisher> PublisherTable { get; set; }
    }
}
