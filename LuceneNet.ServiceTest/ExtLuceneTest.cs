using CustomSpring.Core;
using LuceneNet.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNet.ServiceTest
{
    class ExtLuceneTest
    {
        private ExtLucene _lucene = null;
        [SetUp]
        public void Setup()
        {
            #region
            if (_lucene == null)
                _lucene = new ExtLucene();

            _lucene._tFileContentService = 
                (TFileContentService)SpringManager.GetObject(
                SpringKeys.TFileContentService);
            #endregion
        }
        [Test]
        public void Test_CreateIndex()
        {
            _lucene.CreateRamDirectory();
        }
        [Test]
        public void Test_Query_Duanyu()
        {
            _lucene.CreateRamDirectory();
            _lucene.Search("段誉");
        }
        [Test]
        public void Test_Query_Wangyuyan()
        {
            _lucene.CreateRamDirectory();
            //未将“王语嫣”加入词典，所以搜索时无法检索到该姓名。
            _lucene.Search("王语嫣");
        }

        #region old version
        /*
        /// <summary>
        /// 测试空字符串的查询
        /// </summary>
        [Test]
        public void TestQuery_Empty()
        {
            ExtLucene lucene = new ExtLucene();
            lucene.CreateRamDirectory();
            lucene.Search(" ");
        }
        /// <summary>
        /// 测试存在的词语（名词）的查询
        /// </summary>
        [Test]
        public void TestQuery_Has()
        {
            ExtLucene lucene = new ExtLucene();
            lucene.CreateRamDirectory();
            lucene.Search("lucene");
        }
        /// <summary>
        /// 测试停用词的查询
        /// </summary>
        [Test]
        public void TestQuery_StopWords()
        {
            ExtLucene lucene = new ExtLucene();
            lucene.CreateRamDirectory();
            lucene.Search("am");
        }
        /// <summary>
        /// 测试动名词的查询
        /// </summary>
        [Test]
        public void TestQuery_Actioning()
        {
            ExtLucene lucene = new ExtLucene();
            lucene.CreateRamDirectory();
            lucene.Search("learning");
        }
        /// <summary>
        /// 测试动词的查询
        /// </summary>
        [Test]
        public void TestQuery_Action()
        {
            ExtLucene lucene = new ExtLucene();
            lucene.CreateRamDirectory();
            lucene.Search("learn");
        }
         * */
        #endregion
    }
}
