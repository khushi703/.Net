using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab9_q3_mvc.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public DateTime OrderDate { get; set; }
        public string ItemsDisplay => Items != null ? string.Join(", ", Items) : "";
    }
}