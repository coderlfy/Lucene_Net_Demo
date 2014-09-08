
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
using System.Data;

namespace LuceneNet.Model
{
    public class EntityTFile : IEntity
    {
		/// <summary>
		/// 文件编号。
		/// </summary>
		public string fid { get; set; }
		/// <summary>
		/// 文件标题。
		/// </summary>
		public string title { get; set; }
		/// <summary>
		/// 文件名。
		/// </summary>
		public string filename { get; set; }
		/// <summary>
		/// 录入时刻。
		/// </summary>
		public string writetime { get; set; }
        /// <summary>
        /// 从数据集中根据主键获取实体时（接口方法）
        /// </summary>
        /// <param name="dr"></param>
        public void Get(DataRow dr)
        {
			this.fid = dr[TFileData.fid].ToString();
			this.title = dr[TFileData.title].ToString();
			this.filename = dr[TFileData.filename].ToString();
			this.writetime = dr[TFileData.writetime].ToString();
        }
    }
}

