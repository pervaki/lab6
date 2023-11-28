using Microsoft.AspNetCore.Mvc;
using lab6.Models;

namespace lab6.Components.Navbar
{
    public class NavbarViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var menuItems = new List<MenuItem>
		{
			new MenuItem { Name = "Home", Url = "/" },
			new MenuItem { Name = "About", Url = "/about" },
        };

            return View("~/Views/Components/Navbar/Default.cshtml", menuItems);
        }
	}
}
