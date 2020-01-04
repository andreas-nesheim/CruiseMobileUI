using System;
using System.Collections.Generic;

namespace ItsaMeDesignio.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Icon { get; set; }
        public List<CarouselImage> Images { get; set; }
    }
}