using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorPages.Models;

namespace WebRazorPages.Pages
{
    public class ContactPageModel : PageModel
    {
        [BindProperty]
        public Contact contact { get; set; }
        public ContactPageModel()
        {
            contact = new Contact();
        }
        public string thongbao { get; set; }
        public void OnPost()
        {
            if(ModelState.IsValid)
            {
                thongbao = "Du lieu gui den hop le";
            }
            else
            {
                thongbao = "Du lieu khong hop le";
            }
        }
    }
}
