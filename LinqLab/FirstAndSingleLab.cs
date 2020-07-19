using System;
using System.Collections.Generic;
using LinqLab.Models;

namespace LinqLab
{
    public class FirstAndSingleLab
    {
        private readonly IEnumerable<Sample> _source;

        public FirstAndSingleLab(IEnumerable<Sample> source)
        {
            _source = source;
        }

        /// <summary>
        /// Use First to get Sample which UserName is "demo"
        /// </summary>
        /// <returns></returns>
        public Sample GetUserNameIsDemoByFirst()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Use FirstOrDefault to get Sample which UserName is "skilltree"
        /// </summary>
        /// <returns></returns>
        public Sample GetUserNameIsSkilltreeByFirstOrDefault()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Use First to get Sample which UserName is "skilltree"
        /// </summary>
        /// <returns></returns>
        public Sample GetUserNameIsSkilltreeByFirst()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Use Single to get Sample which UserName is "demo"
        /// </summary>
        /// <returns></returns>
        public Sample GetUserNameIsDemoBySingle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 搜尋UserName等於bill的資料使用Single
        /// </summary>
        /// <returns></returns>
        public Sample GetUserNameIsBillBySingle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 搜尋UserName等於bill的資料使用SingleOrDefault
        /// </summary>
        /// <returns></returns>
        public Sample GetUserNameIsBillBySingleOrDefault()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 搜尋UserName等於skilltree的資料使用SingleOrDefault
        /// </summary>
        /// <returns></returns>
        public Sample GetUserNameIsSkilltreeBySingleOrDefault()
        {
            throw new NotImplementedException();
        }
    }
}