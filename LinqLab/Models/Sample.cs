using System;
using System.Collections.Generic;

namespace LinqLab.Models
{
    public class Sample
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Price { get; set; }
        public DateTime CreateTime { get; set; }
        public List<int> Items { get; set; }
    }
}