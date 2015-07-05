using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objects.Processes.Response
{
    public class OpLogin
    {
        public string msg { get; set; }
        public OpLoginData data { get; set; }
    }

    public class OpLoginData
    {
        public string FullName { get; set; }
        public string TypeUser { get; set; }
        public string ImagePath { get; set; }
    }

}
