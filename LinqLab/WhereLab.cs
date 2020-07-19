using System;
using System.Collections.Generic;
using LinqLab.Models;

namespace LinqLab
{
    public class WhereLab
    {
        private readonly IEnumerable<Sample> _source;

        public WhereLab(IEnumerable<Sample> source)
        {
            _source = source;
        }

        /// <summary>
        /// 搜尋Id大於8的資料
        /// </summary>
        /// <returns></returns>
        public List<Sample> GetIdGreaterThen8()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 搜尋Price等於200的資料
        /// </summary>
        /// <returns></returns>
        public List<Sample> GetPriceEqual200()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 搜尋UserName開頭為d的資料
        /// </summary>
        /// <returns></returns>
        public List<Sample> GetUserNameStartWithD()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 搜尋UserName包含e的資料
        /// </summary>
        /// <returns></returns>
        public List<Sample> GetUserNameContainsE()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 搜尋UserName結尾為o的資料
        /// </summary>
        /// <returns></returns>
        public List<Sample> GetUserNameEndWithO()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 搜尋UserName是demo和joey的資料
        /// </summary>
        /// <returns></returns>
        public List<Sample> GetUserNameInDemoAndJoey()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 判斷是否有Id等於99的資料
        /// </summary>
        /// <returns></returns>
        public bool IsContainsId99()
        {
            throw new NotImplementedException();
        }
    }
}