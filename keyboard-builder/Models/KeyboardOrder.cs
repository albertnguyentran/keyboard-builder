using System;
namespace keyboard_builder.Models
{
    public class KeyboardOrder
    {
        public int Id { get; set; }
        public string KeyboardName { get; set; }
        public float BasePrice { get; set; } = 200;
    }
}

