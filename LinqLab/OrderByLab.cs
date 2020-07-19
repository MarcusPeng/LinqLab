using System;
using System.Collections.Generic;
using LinqLab.Models;

namespace LinqLab
{
    public class OrderByLab
    {
        private IEnumerable<Sample> _source { get; set; }

        public OrderByLab(IEnumerable<Sample> source)
        {
            _source = source;
        }

        public List<Sample> 請使用Id升冪排序()
        {
            throw new NotImplementedException();
        }

        public List<Sample> 請使用Id降冪排序()
        {
            throw new NotImplementedException();
        }

        public List<Sample> 請使用Price昇冪排序後再使用Id昇冪排序()
        {
            throw new NotImplementedException();
        }
    }
}