using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
{
  public class HelloController : Controller   //remember inheritance??
  {
    //for each route this controller is to handle:
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public string Index()
    {
      return "This is my Index!";
    }

    [HttpGet]
    [Route("projects")]
    public string Project()
    {
      // Same logic for serving a view applies
      // if we provide the the exact view name
      return "These are my projects!";
    }

    [HttpGet]
    [Route("contact")]
    public string Contact()
    {
      // Same logic for serving a view applies
      // if we provide the the exact view name
      return "This is my contact information!";
    }
  }
}
