using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
