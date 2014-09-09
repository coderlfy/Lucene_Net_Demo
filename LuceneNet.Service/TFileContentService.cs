
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
    public class TFileContentService : ITFileContentService
    {
        public ITFileContentDao _TFileContentDao { get; set; }

        #region 添加操作
        /// <summary>
        /// 添加[tFileContent]数据到数据库（有源、单实体）。
        /// </summary>
        /// <param name="tFileContentData">源数据集</param>
        /// <param name="tFileContent">欲添加的实体</param>
        public void Add(
            ref TFileContentData tFileContentData,
            EntityTFileContent tFileContent)
        {
            #region
            tFileContentData.AddCache(tFileContent);
            _TFileContentDao.Save(tFileContentData);
            #endregion
        }
        /// <summary>
        /// 添加[tFileContent]数据到数据库（有源、多实体）。
        /// </summary>
        /// <param name="tFileContentData">源数据集</param>
        /// <param name="tFileContents">欲添加的多实体</param>
        public void Add(
            ref TFileContentData tFileContentData,
            IList<EntityTFileContent> tFileContents)
        {
            #region
            tFileContentData.AddCache(tFileContents);
            _TFileContentDao.Save(tFileContentData);
            #endregion
        }
        /// <summary>
        /// 添加[tFileContent]数据到数据库（无源、单实体）。
        /// </summary>
        /// <param name="tFileContent">单实体</param>
        /// <returns>保存后的数据集</returns>
        public TFileContentData Add(
            EntityTFileContent tFileContent)
        {
            #region
            TFileContentData tfilecontentdata = new TFileContentData();
            this.Add(ref tfilecontentdata, tFileContent);
            return tfilecontentdata;
            #endregion
        }
        /// <summary>
        /// 添加[tFileContent]数据到数据库（无源、多实体）。
        /// </summary>
        /// <param name="tFileContents">多实体</param>
        /// <returns>保存后的数据集</returns>
        public TFileContentData Add(
            IList<EntityTFileContent> tFileContents)
        {
            #region
            TFileContentData tfilecontentdata = new TFileContentData();
            this.Add(ref tfilecontentdata, tFileContents);
            return tfilecontentdata;
            #endregion
        }
        #endregion

        #region 编辑操作
        /// <summary>
        /// 编辑[tFileContent]数据到数据库（有源、单实体）
        /// </summary>
        /// <param name="tFileContentData">源数据集</param>
        /// <param name="tFileContent">实体</param>
        public void Edit(
            ref TFileContentData tFileContentData,
            EntityTFileContent tFileContent)
        {
            #region
            tFileContentData.EditCache(tFileContent);
            _TFileContentDao.Save(tFileContentData);
            #endregion
        }
        #endregion

        #region 删除操作
        /// <summary>
        /// 删除[tFileContent]数据集中的数据
        /// </summary>
        /// <param name="tFileContentData">源数据集</param>
        /// <param name="tFileContent">要删除的实体</param>
        public void Delete(
            ref TFileContentData tFileContentData,
            EntityTFileContent tFileContent)
        {
            #region
            tFileContentData.DeleteCache(tFileContent);
            _TFileContentDao.Save(tFileContentData);
            #endregion
        }
        #endregion
        
        
    }
}

