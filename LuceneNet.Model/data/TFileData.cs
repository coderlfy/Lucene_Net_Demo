
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
    public class TFileData : DataLibBase
    {
        #region table structure
		/// <summary>
		/// 文件编号。
		/// </summary>
		public const string fid = "fid";
		/// <summary>
		/// 文件标题。
		/// </summary>
		public const string title = "title";
		/// <summary>
		/// 文件名。
		/// </summary>
		public const string filename = "filename";
		/// <summary>
		/// 录入时刻。
		/// </summary>
		public const string writetime = "writetime";
        /// <summary>
        /// 表名。
        /// </summary>
        public const string TFile = "TFile";
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public TFileData()
        {
            this.buildData();
        }
        private void buildData()
        {
            #region
            DataTable dt = new DataTable(TFile);
			dt.Columns.Add(fid, typeof(System.Object));
			dt.Columns.Add(title, typeof(System.String));
			dt.Columns.Add(filename, typeof(System.String));
			dt.Columns.Add(writetime, typeof(System.DateTime));
            dt.PrimaryKey = new DataColumn[1] { dt.Columns[fid] };
            dt.TableName = TFile;
            this.Tables.Add(dt);
            this.DataSetName = "TTFile";
            #endregion
        }
        /// <summary>
        /// 将实体赋予数据行。
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="tFile"></param>
        private void assignAll(
            DataRow currentRow, EntityTFile tFile)
        {
            #region
		this.Assign(currentRow, fid, tFile.fid);
		this.Assign(currentRow, title, tFile.title);
		this.Assign(currentRow, filename, tFile.filename);
		this.Assign(currentRow, writetime, tFile.writetime);
            #endregion
        }
        /// <summary>
        /// 接口：添加实体到缓存。
        /// </summary>
        /// <param name="tFile"></param>
        public void AddCache(
            EntityTFile tFile)
        {
            #region
            base.checkIsNull(() => { 
                this.buildData();
            });
                
            DataRow dr = this.Tables[0].NewRow();
            assignAll(dr, tFile);
            this.Tables[0].Rows.Add(dr);
            #endregion
        }
        /// <summary>
        /// 接口：添加多实体到缓存。
        /// </summary>
        /// <param name="tFiles"></param>
        public void AddCache(
            IList<EntityTFile> tFiles)
        {
            #region
            foreach (EntityTFile tfile in tFiles)
                this.AddCache(tfile);
            #endregion
        }
        /// <summary>
        /// 接口：编辑单实体到缓存。
        /// </summary>
        /// <param name="tFile"></param>
        public void EditCache(
            EntityTFile tFile)
        {
            #region
            base.checkIsNotNull(() => { 
                DataRow dr = findRow(tFile);

                if (dr != null)
                    this.assignAll(dr, tFile);
                else
                    Console.WriteLine("TFileData Cache hasn't tFile！");
            });
            #endregion
        }
        /// <summary>
        /// 接口：从缓存中删除实体。
        /// </summary>
        /// <param name="tFile"></param>
        public void DeleteCache(
            EntityTFile tFile)
        {
            #region
            base.checkIsNotNull(() =>
            {
                DataRow dr = findRow(tFile);

                if (dr != null)
                    dr.Delete();
                else
                    Console.WriteLine("TFileData Cache hasn't tFile！");
            });
            #endregion
        }
        /// <summary>
        /// 根据实体查找数据行，用于编辑或删除缓存。
        /// </summary>
        /// <param name="tFile"></param>
        /// <returns></returns>
        private DataRow findRow(
            EntityTFile tFile)
        {
            #region
            return this.Tables[0].Rows.Find(
                this.getPrimaryParams(tFile));
            #endregion
        }
        /// <summary>
        /// 从实体中获取关键字参数
        /// </summary>
        /// <param name="tFile"></param>
        /// <returns></returns>
        private object[] getPrimaryParams(
            EntityTFile tFile)
        {
            #region
            IList<object> dbparams = new List<object>();
			dbparams.Add(tFile.fid);
            return dbparams.ToArray<object>();
            #endregion
        }
    }
}

