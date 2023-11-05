using Microsoft.AspNetCore.Mvc;

namespace IMDB.Web.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult _AdminLayout()
		{
			return View();
		}

		public PartialViewResult HeadPartial()
		{
			return PartialView();
		}
		public PartialViewResult SpinnerPartial()
		{
			return PartialView();
		}

		public PartialViewResult SideBarPartial()
		{
			return PartialView();
		}
		public PartialViewResult NavBarPartial() 
		{
			return PartialView();
		}
		public PartialViewResult FooterPartial() 
		{
			return PartialView();
		}
		public PartialViewResult ScriptPartial() 
		{
			return PartialView();
		}
	}
}
