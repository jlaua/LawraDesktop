using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objects.Tables;

namespace Objects.Processes
{
    public class RequestLogin
    {
        public string UserNick { get; set; }
        public string UserPass { get; set; }
    }

	public class ResponseLogin
	{
		public string msg { get; set; }
		public LoginData data { get; set; }
	}

	public class LoginData
	{
		public string FullName { get; set; }
		public string TypeUser { get; set; }
		public string ImagePath { get; set; }
	}
}
