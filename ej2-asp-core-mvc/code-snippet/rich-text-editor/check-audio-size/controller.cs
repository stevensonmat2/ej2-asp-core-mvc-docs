public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "Audio" };
        return View();
    }
}