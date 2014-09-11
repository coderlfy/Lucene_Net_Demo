using PanGu.Match;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNet.Service
{
    class PanGuConfig
    {
        public static MatchOptions _Options;

        public static MatchParameter _Parameters;

        public static void Init()
        {
            initOptions();
            initParameters();
        }

        private static void initOptions()
        {
            #region
            if (_Options == null)
                _Options = new MatchOptions();

            _Options.FrequencyFirst = false;
            //过滤停用词
            _Options.FilterStopWords = true;
            //中文人名
            _Options.ChineseNameIdentify = true;
            //多元分词
            _Options.MultiDimensionality = true;
            //英文多元分词
            _Options.EnglishMultiDimensionality = false;
            //强制一元分词
            _Options.ForceSingleWord = false;
            //支持繁体
            _Options.TraditionalChineseEnabled = true;
            //同时输出简体繁体
            _Options.OutputSimplifiedTraditional = false;
            //未登录词识别
            _Options.UnknownWordIdentify = true;
            //过滤英文
            _Options.FilterEnglish = false;
            //过滤数字
            _Options.FilterNumeric = false;
            //忽略大小写
            _Options.IgnoreCapital = false;
            //英文分词
            _Options.EnglishSegment = true;

            _Options.SynonymOutput = false;
            //通配符输出
            _Options.WildcardOutput = false;
            _Options.WildcardSegment = false;
            _Options.CustomRule = false;


            #endregion
        }

        private static void initParameters()
        {
            #region
            if (_Parameters == null)
                _Parameters = new MatchParameter();

            _Parameters.Redundancy = 0;
            _Parameters.FilterEnglishLength = 0;
            _Parameters.FilterNumericLength = 0;
            #endregion
        }
    }
}
