using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET : /HelloWorld
        public string Index() {
            return "This is my default action...";
        }

        // GET : /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method 2...";
        }

        // GET : /HelloWorld/WelcomePerson/ with 2 params : name and numTimes
        // Requires using System.Text.Encodings.Web;
        public string WelcomePerson(string name, int numTimes) {
            return HtmlEncoder.Default.Encode($"Hello {name}, numTimes is {numTimes}");
        }
    }
}
