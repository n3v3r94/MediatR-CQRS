using System;
using System.Collections.Generic;
using System.Text;

namespace SimelERP.Application.Test.Query.GetTest
{
    public class TestViewModel
    {
        public int TestERPId { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public bool EditEnabled { get; set; }

        public bool DeleteEnabled { get; set; }
    }
}
