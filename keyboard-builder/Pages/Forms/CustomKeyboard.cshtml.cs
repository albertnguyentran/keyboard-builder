﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using keyboard_builder.Models;

namespace keyboard_builder.Pages.Forms
{
    public class CustomKeyboardModel : PageModel
    {
        [BindProperty]
        public KeyboardsModel Keyboard { get; set; }
        public float KeyboardPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            KeyboardPrice = Keyboard.BasePrice;

            if (Keyboard.Switches) KeyboardPrice += 5;
            if (Keyboard.Keycaps) KeyboardPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { Keyboard.KeyboardName, KeyboardPrice});
        }
    }
}
