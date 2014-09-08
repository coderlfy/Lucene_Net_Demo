
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
    public class TFileDao : BaseDao, ITFileDao
    {
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="tFileData">欲保存的数据集</param>
        public void Save(TFileData tFileData)
        {
            base.Save(tFileData);
        }
        
        /// <summary>
        /// 检索单表
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns>TFile的数据集</returns>
        public TFileData SelectSingleT(
            QueryCondition condition)
        {
            return base.GetDataSet<TFileData>(condition);
        }
    }
}

