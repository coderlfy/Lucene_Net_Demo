using CustomSpring.Core;
using LuceneNet.IService;
using LuceneNet.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNet.ServiceTest
{
    class TFileOperateTest
    {
        /// <summary>
        /// 测试空字符串的查询
        /// </summary>
        [Test]
        public void TestCreateSimulateData()
        {
            TFileOperate fileop = new TFileOperate();
            fileop._tFileContentService = (TFileContentService)SpringManager.GetObject(SpringKeys.TFileContentService);
            fileop._tFileService = (TFileService)SpringManager.GetObject(SpringKeys.TFileService);


            fileop.CreateData("lianchengjue.txt", 20, 2);
        }

    }
}
