using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
  public class PortfolioController : Controller   //remember inheritance??
  {
    //for each route this controller is to handle:
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public ViewResult Index()
    {
      return View("index");
    }

    [HttpGet]       //type of request
    [Route("contact")]     //associated route string (exclude the leading /)
    public ViewResult Contact()
    {
      return View("Contact");
    }

    [HttpGet]       //type of request
    [Route("portfolio")]     //associated route string (exclude the leading /)
    public ViewResult Portfolio()
    {
      return View("Project");
    }
  }
}
