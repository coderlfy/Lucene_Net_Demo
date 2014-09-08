
/****************************************
***生成器版本：V2.0
***创建人：李峰艳
***生成时间：2014-08-28 10:27:29
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using LuceneNet.Model;
using System;
using System.Collections.Generic;

namespace LuceneNet.IService
{
    public interface ITFileContentService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileContentData"></param>
        /// <param name="tFileContent"></param>
        void Add(
            ref TFileContentData tFileContentData,
            EntityTFileContent tFileContent);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileContentData"></param>
        /// <param name="tFileContents"></param>
        void Add(
           ref TFileContentData tFileContentData,
           IList<EntityTFileContent> tFileContents);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileContent"></param>
        /// <returns></returns>
        TFileContentData Add(
            EntityTFileContent tFileContent);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileContents"></param>
        /// <returns></returns>
        TFileContentData Add(
            IList<EntityTFileContent> tFileContents);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileContentData"></param>
        /// <param name="tFileContent"></param>
        void Edit(
            ref TFileContentData tFileContentData,
            EntityTFileContent tFileContent);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileContentData"></param>
        /// <param name="tFileContent"></param>
        void Delete(
            ref TFileContentData tFileContentData,
            EntityTFileContent tFileContent);
        
    }
}

