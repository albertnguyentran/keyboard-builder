using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace keyboard_builder.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]

    public class CheckoutModel : PageModel
    {
        public string KeyboardName { get; set; }
        public float KeyboardPrice { get; set; }
        public string ImageTitle { get; set; }

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(KeyboardName))
            {
                KeyboardName = "Custom";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
