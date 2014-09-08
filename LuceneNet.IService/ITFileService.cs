
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
    public interface ITFileService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileData"></param>
        /// <param name="tFile"></param>
        void Add(
            ref TFileData tFileData,
            EntityTFile tFile);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileData"></param>
        /// <param name="tFiles"></param>
        void Add(
           ref TFileData tFileData,
           IList<EntityTFile> tFiles);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFile"></param>
        /// <returns></returns>
        TFileData Add(
            EntityTFile tFile);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFiles"></param>
        /// <returns></returns>
        TFileData Add(
            IList<EntityTFile> tFiles);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileData"></param>
        /// <param name="tFile"></param>
        void Edit(
            ref TFileData tFileData,
            EntityTFile tFile);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tFileData"></param>
        /// <param name="tFile"></param>
        void Delete(
            ref TFileData tFileData,
            EntityTFile tFile);
        
    }
}

