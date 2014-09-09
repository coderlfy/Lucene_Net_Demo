using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNet.IService
{
    public interface ITFileOperate
    {
        void CreateData(
            string filename, int recordPerSubmit, int rowCountPer);
    }
}
