using System;
using System.Collections.Generic;
using System.Linq;
using LinqLab.Models;

namespace LinqLab
{
    public class GroupByLab
    {
        private readonly IEnumerable<Sample> _source;

        public GroupByLab(IEnumerable<Sample> source)
        {
            _source = source;
        }

        /// <summary>
        /// 使用UserName作為群組依據
        /// </summary>
        /// <returns></returns>
        public IList<IGrouping<string, Sample>> GroupByUserName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 使用UserName和CreateTime作為群組依據
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IGrouping<TempObj, Sample>> GroupByUserNameAndCreateTime()
        {
            throw new NotImplementedException();
        }
    }
}