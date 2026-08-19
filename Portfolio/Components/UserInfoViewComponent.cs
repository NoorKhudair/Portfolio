using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Components
{
    public class UserInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string userName = User.Identity.Name;
            if (!User.Identity.IsAuthenticated)
            {
                userName = "Guest";
            }
            return View("UserInfo", userName);
        }


    }
}
