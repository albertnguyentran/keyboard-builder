using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using keyboard_builder.Models;
using keyboard_builder.Data;

namespace keyboard_builder.Pages
{
    public List<KeyboardOrder> KeyboardOrders = new List<KeyboardOrder>();

    private readonly ApplicationDbContext _context;

    public OrdersModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public class OrdersModel : PageModel
    {
        public void OnGet()
        {
            KeyboardOrders = _context.KeyboardOrders.ToList();
        }
    }
}
