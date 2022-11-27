using System;
using Microsoft.AspNetCore.Identity;

namespace AuthServer.Core.Model
{
	public class UserApp:IdentityUser
	{
		public UserApp()
		{
		}
		public string City { get; set; }

	}
}

