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
        private TFileOperate _fileOp = null;
        [SetUp]
        public void Setup()
        { 
            if(_fileOp == null)
                _fileOp = new TFileOperate();

            _fileOp._tFileContentService = (TFileContentService)SpringManager.GetObject(SpringKeys.TFileContentService);
            _fileOp._tFileService = (TFileService)SpringManager.GetObject(SpringKeys.TFileService);
        }
        /// <summary>
        /// 测试空字符串的查询
        /// </summary>
        [Test]
        public void TestCreateSimulateData_Lianchengjue()
        {
            _fileOp.CreateData("lianchengjue.txt", 20, 2);
        }
        [Test]
        public void TestCreateSimulateData_Tianlongbabu()
        {
            _fileOp.CreateData("tianlongbabu.txt", 20, 2);
        }
        [Test]
        public void TestCreateSimulateData_SmallFile()
        {
            _fileOp.CreateData("smallfile.txt", 20, 2);
        }
    }
}
