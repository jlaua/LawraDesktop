﻿using System;
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
		public string Token { get; set; }
		public string FullName { get; set; }
		public string UserType { get; set; }
		public string UserLevel { get; set; }
		public string UserLocation { get; set; }
		public string ImagePath { get; set; }
		public InstitutionData Institution { get; set; }
	}

	public class ChangePassword
	{
		public string UserNick { get; set; }
		public string OldPassword { get; set; }
		public string NewPassword { get; set; }
	}

	public class InstitutionData
	{
		public int BranchCode { get; set; }
		public string NameInstitution { get; set; }
		public string BranchAddress { get; set; }
		public string LogoInstitution { get; set; }
	}
}
