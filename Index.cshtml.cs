using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NoviMovie.Pages
{
    public class IndexModel : PageModel
    {
        public string[] Currentexperiences { get; set; }
        public void OnGet()
        {
            Currentexperiences = new string[] { "Avatar", "We Bought a zoo", "Jurassic Park 3", "National Treasure" };
        }
    }
}
