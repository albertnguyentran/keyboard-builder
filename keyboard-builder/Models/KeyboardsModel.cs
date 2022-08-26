using System;
namespace keyboard_builder.Models
{
    public class KeyboardsModel
    {
        public string ImageTitle { get; set; }
        public string KeyboardName { get; set; }
        public float BasePrice { get; set; } = 200;
        public bool Switches { get; set; }
        public bool Keycaps { get; set; }
        public float FinalPrice { get; set; }
    }
}

