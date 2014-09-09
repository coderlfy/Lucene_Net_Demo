
/****************************************
***生成器版本：V2.0
***创建人：李峰艳
***生成时间：2014-08-28 10:27:29
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using Foundation.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LuceneNet.Model
{
    public class TFileContentData : DataLibBase
    {
        #region table structure
		/// <summary>
		/// 文件编号。
		/// </summary>
		public const string fid = "fid";
		/// <summary>
		/// 文件内容。
		/// </summary>
		public const string fileContent = "fileContent";
        /// <summary>
        /// 表名。
        /// </summary>
        public const string TFileContent = "TFileContent";
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public TFileContentData()
        {
            this.buildData();
        }
        private void buildData()
        {
            #region
            DataTable dt = new DataTable(TFileContent);
			dt.Columns.Add(fid, typeof(System.Guid));
			dt.Columns.Add(fileContent, typeof(System.Object));
            dt.PrimaryKey = new DataColumn[1] { dt.Columns[fid] };
            dt.TableName = TFileContent;
            this.Tables.Add(dt);
            this.DataSetName = "TTFileContent";
            #endregion
        }
        /// <summary>
        /// 将实体赋予数据行。
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="tFileContent"></param>
        private void assignAll(
            DataRow currentRow, EntityTFileContent tFileContent)
        {
            #region
		this.Assign(currentRow, fid, tFileContent.fid);
		this.Assign(currentRow, fileContent, tFileContent.fileContent);
            #endregion
        }
        /// <summary>
        /// 接口：添加实体到缓存。
        /// </summary>
        /// <param name="tFileContent"></param>
        public void AddCache(
            EntityTFileContent tFileContent)
        {
            #region
            base.checkIsNull(() => { 
                this.buildData();
            });
                
            DataRow dr = this.Tables[0].NewRow();
            assignAll(dr, tFileContent);
            this.Tables[0].Rows.Add(dr);
            #endregion
        }
        /// <summary>
        /// 接口：添加多实体到缓存。
        /// </summary>
        /// <param name="tFileContents"></param>
        public void AddCache(
            IList<EntityTFileContent> tFileContents)
        {
            #region
            foreach (EntityTFileContent tfilecontent in tFileContents)
                this.AddCache(tfilecontent);
            #endregion
        }
        /// <summary>
        /// 接口：编辑单实体到缓存。
        /// </summary>
        /// <param name="tFileContent"></param>
        public void EditCache(
            EntityTFileContent tFileContent)
        {
            #region
            base.checkIsNotNull(() => { 
                DataRow dr = findRow(tFileContent);

                if (dr != null)
                    this.assignAll(dr, tFileContent);
                else
                    Console.WriteLine("TFileContentData Cache hasn't tFileContent！");
            });
            #endregion
        }
        /// <summary>
        /// 接口：从缓存中删除实体。
        /// </summary>
        /// <param name="tFileContent"></param>
        public void DeleteCache(
            EntityTFileContent tFileContent)
        {
            #region
            base.checkIsNotNull(() =>
            {
                DataRow dr = findRow(tFileContent);

                if (dr != null)
                    dr.Delete();
                else
                    Console.WriteLine("TFileContentData Cache hasn't tFileContent！");
            });
            #endregion
        }
        /// <summary>
        /// 根据实体查找数据行，用于编辑或删除缓存。
        /// </summary>
        /// <param name="tFileContent"></param>
        /// <returns></returns>
        private DataRow findRow(
            EntityTFileContent tFileContent)
        {
            #region
            return this.Tables[0].Rows.Find(
                this.getPrimaryParams(tFileContent));
            #endregion
        }
        /// <summary>
        /// 从实体中获取关键字参数
        /// </summary>
        /// <param name="tFileContent"></param>
        /// <returns></returns>
        private object[] getPrimaryParams(
            EntityTFileContent tFileContent)
        {
            #region
            IList<object> dbparams = new List<object>();
			dbparams.Add(tFileContent.fid);
            return dbparams.ToArray<object>();
            #endregion
        }
    }
}

