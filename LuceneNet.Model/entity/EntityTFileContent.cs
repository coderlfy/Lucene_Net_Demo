
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
    public class EntityTFileContent : IEntity
    {
		/// <summary>
		/// 文件编号。
		/// </summary>
		public string fid { get; set; }
		/// <summary>
		/// 文件内容。
		/// </summary>
		public string fileContent { get; set; }
        /// <summary>
        /// 从数据集中根据主键获取实体时（接口方法）
        /// </summary>
        /// <param name="dr"></param>
        public void Get(DataRow dr)
        {
			this.fid = dr[TFileContentData.fid].ToString();
			this.fileContent = dr[TFileContentData.fileContent].ToString();
        }
    }
}

