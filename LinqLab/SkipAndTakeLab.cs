using System;
using System.Collections.Generic;
using LinqLab.Models;

namespace LinqLab
{
    public class SkipAndTakeLab
    {
        private readonly IEnumerable<Sample> _source;

        public SkipAndTakeLab(IEnumerable<Sample> source)
        {
            _source = source;
        }

        /// <summary>
        /// 跳過五筆資料
        /// </summary>
        /// <returns></returns>
        public List<Sample> 跳過五筆資料()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 取得五筆資料
        /// </summary>
        /// <returns></returns>
        public List<Sample> 取得五筆資料()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 跳過五筆取得兩筆
        /// </summary>
        /// <returns></returns>
        public List<Sample> 跳過五筆取得兩筆()
        {
            throw new NotImplementedException();
        }
    }
}