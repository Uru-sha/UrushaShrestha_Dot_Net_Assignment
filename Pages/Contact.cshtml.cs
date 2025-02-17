using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrowdFunding.Pages
{
    public class ContactModel : PageModel
    {

        public bool hasData =  false;
        public string firstname = "";
        public string lastname = "";
        public string country = "";
        public string message = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            country = Request.Form["country"];  
            message = Request.Form["message"];
        }
    }
}
