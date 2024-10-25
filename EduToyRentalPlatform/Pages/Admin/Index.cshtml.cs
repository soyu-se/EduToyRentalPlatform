using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToyShop.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            //// Ki?m tra quy?n truy c?p
            //if (!UserHasAccess())
            //{
            //    // N?u kh�ng c� quy?n, chuy?n h??ng v? trang kh�c
            //    return RedirectToPage("/Account/ErrorPage");
            //}

            return Page();
        }

        private bool UserHasAccess()
        {
            var role = HttpContext.Request.Cookies["UserRole"];
            return role == "Admin"; // Ki?m tra xem c� ph?i l� Admin kh�ng
        }
    }
}
