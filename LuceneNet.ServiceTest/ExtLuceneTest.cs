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
        [Test]
        public void Test_SplitWords()
        {
            /*
            string wordsstring = @"盘古分词 简介: 盘古分词 是由eaglet 开发的一款基于字典的中英文分词组件
主要功能: 中英文分词，未登录词识别,多元歧义自动识别,全角字符识别能力
主要性能指标:
分词准确度:90%以上
处理速度: 300-600KBytes/s Core Duo 1.8GHz
用于测试的句子:
长春市长春节致词
长春市长春药店
IＢM的技术和服务都不错
张三在一月份工作会议上说的确实在理
于北京时间5月10日举行运动会
我的和服务必在明天做好";
            */
            string wordsstring = @"段誉王语嫣乔峰虚竹";
            _lucene.SplitWords(wordsstring);
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
