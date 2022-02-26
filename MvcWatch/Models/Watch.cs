using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWatch.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public string Color { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }
        public int Rating { get; set; }
       
        public decimal Price { get; set; }
    }
}