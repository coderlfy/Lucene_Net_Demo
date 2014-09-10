using Lucene.Net.Analysis;
using Lucene.Net.Analysis.PanGu;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using LuceneNet.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LuceneNet.Service
{
    public class ExtLucene
    {
        private RAMDirectory _directory = null;

        public TFileContentService _tFileContentService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void CreateRamDirectory()
        {
            #region
            Stopwatch st = new Stopwatch();
            st.Start();

            _directory = new RAMDirectory();
            //new SimpleAnalyzer() 分词器
            IndexWriter writer = new IndexWriter(
                _directory, new PanGuAnalyzer(), true);

            TFileContentData indexdata = 
                _tFileContentService.GetTFileContentData(null, null);

            for (int i = 0; i < indexdata.Tables[0].Rows.Count; i++)
            {
                DataRow dr = indexdata.Tables[0].Rows[i];
                Document doc = new Document();

                doc.Add(new Field(
                    TFileContentData.fid, 
                    dr[TFileContentData.fid].ToString(), 
                    Field.Store.YES, 
                    Field.Index.UN_TOKENIZED));

                doc.Add(new Field(
                    TFileContentData.fileContent, 
                    dr[TFileContentData.fileContent].ToString(), 
                    Field.Store.YES, 
                    Field.Index.TOKENIZED));

                writer.AddDocument(doc);
            }
            writer.Close();

            st.Stop();
            Console.WriteLine("创建索引总共花费 {0} 毫秒。", st.ElapsedMilliseconds);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryString"></param>
        public void Search(string queryString)
        {
            #region
            Stopwatch st = new Stopwatch();
            st.Start();
            IndexSearcher searcher = new IndexSearcher(_directory);  
            // 根据搜索关键字 封装一个term组合对象，然后封装成Query查询对象  
            Query query = new TermQuery(new Term(TFileContentData.fileContent, queryString));  
          
            // 去索引目录中查询，返回的是TopDocs对象，里面存放的就是上面放的document文档对象  
            TopDocs rs = searcher.Search(query, null, 10);
            st.Stop();
            Console.WriteLine("总共花费 {0} 毫秒，检索到 {1} 条记录。", st.ElapsedMilliseconds, rs.totalHits);  
            for (int i = 0; i < rs.scoreDocs.Length; i++) {  
                Document firstHit = searcher.Doc(rs.scoreDocs[i].doc);
                Console.WriteLine("name: {0}", firstHit.GetField(TFileContentData.fid).StringValue());  
            }
            Console.WriteLine("*****************检索结束**********************");  
            #endregion
        }
    }
}
