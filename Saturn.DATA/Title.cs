﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn.DATA
{
    public class Title
    {
        public int TitleID { get; set; }
        public string TitleName { get; set; }
        public Publisher PublisherOfTitle { get; set; }
        public List<Issue> IssuesOfTitle { get; set; }
    }
}