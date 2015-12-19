using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn.DATA
{
    public class Issue
    {
        public int IssueID { get; set; }
        public string IssueName { get; set; }
        public Publisher PublisherName { get; set; }
        public Title TitleName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int IssueNumber { get; set; }
    }
}
