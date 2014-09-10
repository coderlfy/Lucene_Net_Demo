using LuceneNet.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LuceneNet.Service
{
    public class TFileOperate
    {
        private string _filename;
        /// <summary>
        /// 原始输入（构建测试数据的原始文件名）
        /// </summary>
        public string _Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        private int _rowCountPer;
        /// <summary>
        /// 每？行构建一条记录
        /// </summary>
        public int _RowCountPer
        {
            get { return _rowCountPer; }
            set { _rowCountPer = value; }
        }

        private int _recordPerSubmit;
        /// <summary>
        /// 每？条记录提交一次
        /// </summary>
        public int _RecordPerSubmit
        {
            get { return _recordPerSubmit; }
            set { _recordPerSubmit = value; }
        }
        
        private IList<EntityTFile> _tFiles = null;
        private IList<EntityTFileContent> _tFileContents = null;

        public TFileService _tFileService { get; set; }
        public TFileContentService _tFileContentService { get; set; }
        /// <summary>
        ///     
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="recordPerSubmit"></param>
        /// <param name="rowCountPer"></param>
        public void CreateData(
            string filename,int recordPerSubmit ,int rowCountPer)
        {
            #region
            this._filename = filename;
            this._recordPerSubmit = recordPerSubmit;
            this._rowCountPer = rowCountPer;

            StringBuilder singletxt = new StringBuilder();

            StreamReader filereader = new StreamReader(filename, Encoding.UTF8);

            try
            {
                string line = filereader.ReadLine();

                int rowindex = 0;
                int submitindex = 0;
                while (line != null)
                {
                    rowindex++;
                    singletxt.AppendLine(line);
                    if (rowindex == this._rowCountPer)
                    {
                        addTFile(singletxt);
                        singletxt.Clear();
                        rowindex = 0;
                        submitindex++;

                        if (submitindex == this._recordPerSubmit)
                        {
                            _tFileService.Add(this._tFiles);
                            _tFileContentService.Add(this._tFileContents);
                            submitindex = 0;
                            this._tFiles.Clear();
                            this._tFileContents.Clear();
                        }

                        singletxt.Clear();
                    }
                    line = filereader.ReadLine();
                }

                if (this._tFiles.Count > 0)
                {
                    if(!String.IsNullOrEmpty(singletxt.ToString()))
                        addTFile(singletxt);

                    _tFileService.Add(this._tFiles);
                    _tFileContentService.Add(this._tFileContents);
                }
            }
            finally
            {
                filereader.Close();
                this._tFiles.Clear();
                this._tFileContents.Clear();
                singletxt.Clear();
            }
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        private void addTFile(
            StringBuilder content)
        {
            #region
            if (_tFiles == null)
                _tFiles = new List<EntityTFile>();

            EntityTFile tfile = new EntityTFile();
            tfile.fid = Guid.NewGuid().ToString();
            tfile.filename = string.Format("{0}.txt", tfile.fid.ToUpper()); ;
            tfile.title = tfile.fid.ToUpper();
            tfile.writetime = DateTime.Now.ToString();

            _tFiles.Add(tfile);

            addTFileContent(tfile, content);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tfile"></param>
        /// <param name="content"></param>
        private void addTFileContent(
            EntityTFile tfile, StringBuilder content)
        {
            #region
            if (this._tFileContents == null)
                this._tFileContents = new List<EntityTFileContent>();

            EntityTFileContent tfilecontent = new EntityTFileContent();
            tfilecontent.fid = tfile.fid.ToUpper();
            tfilecontent.fileContent = content.ToString();
            _tFileContents.Add(tfilecontent);
            #endregion
        }
    }
}
