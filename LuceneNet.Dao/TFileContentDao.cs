
/****************************************
***生成器版本：V2.0
***创建人：李峰艳
***生成时间：2014-08-28 10:27:29
***公司：iCat Studio
***友情提示：本文件为生成器自动生成，
***         如发现任何编译和运行时的
***         错误，请联系QQ：330669393。
*****************************************/
using CustomSpring.Core;
using Foundation.Core;
using LuceneNet.IDao;
using LuceneNet.Model;

namespace LuceneNet.Dao
{
    public class TFileContentDao : BaseDao, ITFileContentDao
    {
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="tFileContentData">欲保存的数据集</param>
        public void Save(TFileContentData tFileContentData)
        {
            base.Save(tFileContentData);
        }
        
        /// <summary>
        /// 检索单表
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns>TFileContent的数据集</returns>
        public TFileContentData SelectSingleT(
            QueryCondition condition)
        {
            return base.GetDataSet<TFileContentData>(condition);
        }
    }
}

