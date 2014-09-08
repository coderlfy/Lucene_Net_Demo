
/****************************************
***生成器版本：V2.0
***创建人：李峰艳
***生成时间：2014-08-28 10:27:29
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using LuceneNet.IDao;
using LuceneNet.IService;
using LuceneNet.Model;
using System;
using System.Collections.Generic;

namespace LuceneNet.Service
{
    class TFileService : ITFileService
    {
        public ITFileDao _TFileDao { get; set; }

        #region 添加操作
        /// <summary>
        /// 添加[tFile]数据到数据库（有源、单实体）。
        /// </summary>
        /// <param name="tFileData">源数据集</param>
        /// <param name="tFile">欲添加的实体</param>
        public void Add(
            ref TFileData tFileData,
            EntityTFile tFile)
        {
            #region
            tFileData.AddCache(tFile);
            _TFileDao.Save(tFileData);
            #endregion
        }
        /// <summary>
        /// 添加[tFile]数据到数据库（有源、多实体）。
        /// </summary>
        /// <param name="tFileData">源数据集</param>
        /// <param name="tFiles">欲添加的多实体</param>
        public void Add(
            ref TFileData tFileData,
            IList<EntityTFile> tFiles)
        {
            #region
            tFileData.AddCache(tFiles);
            _TFileDao.Save(tFileData);
            #endregion
        }
        /// <summary>
        /// 添加[tFile]数据到数据库（无源、单实体）。
        /// </summary>
        /// <param name="tFile">单实体</param>
        /// <returns>保存后的数据集</returns>
        public TFileData Add(
            EntityTFile tFile)
        {
            #region
            TFileData tfiledata = new TFileData();
            this.Add(ref tfiledata, tFile);
            return tfiledata;
            #endregion
        }
        /// <summary>
        /// 添加[tFile]数据到数据库（无源、多实体）。
        /// </summary>
        /// <param name="tFiles">多实体</param>
        /// <returns>保存后的数据集</returns>
        public TFileData Add(
            IList<EntityTFile> tFiles)
        {
            #region
            TFileData tfiledata = new TFileData();
            this.Add(ref tfiledata, tFiles);
            return tfiledata;
            #endregion
        }
        #endregion

        #region 编辑操作
        /// <summary>
        /// 编辑[tFile]数据到数据库（有源、单实体）
        /// </summary>
        /// <param name="tFileData">源数据集</param>
        /// <param name="tFile">实体</param>
        public void Edit(
            ref TFileData tFileData,
            EntityTFile tFile)
        {
            #region
            tFileData.EditCache(tFile);
            _TFileDao.Save(tFileData);
            #endregion
        }
        #endregion

        #region 删除操作
        /// <summary>
        /// 删除[tFile]数据集中的数据
        /// </summary>
        /// <param name="tFileData">源数据集</param>
        /// <param name="tFile">要删除的实体</param>
        public void Delete(
            ref TFileData tFileData,
            EntityTFile tFile)
        {
            #region
            tFileData.DeleteCache(tFile);
            _TFileDao.Save(tFileData);
            #endregion
        }
        #endregion
        
        
    }
}

