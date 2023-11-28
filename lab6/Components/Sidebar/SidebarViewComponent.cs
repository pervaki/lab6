using Microsoft.AspNetCore.Mvc;
using lab6.Models;
using System.Collections.Generic;

namespace lab6.Components.Sidebar
{
    public class SidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var sidebarItems = new List<MenuItem>
            {
                new MenuItem { Name = "Dashboard", Url = "/dashboard" },
                new MenuItem { Name = "Settings", Url = "/settings" },
            };

            return View("~/Views/Components/Sidebar/Default.cshtml", sidebarItems);
        }
    }
}
