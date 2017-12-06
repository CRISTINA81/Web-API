using Microsoft.AspNetCore.Identity;

namespace MvcMovie.Models
{
	public class ApplicationUser: IdentityUser
	{
		public string NickName { get; set; }
	}
}
