using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LuceneNet.Service
{
    public class ExtLucene
    {
        private RAMDirectory _directory = null;

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
            IndexWriter writer = new IndexWriter(_directory, new StandardAnalyzer(), true);

            Document doc = new Document();
            
            doc.Add(new Field("name", "Chenghui", Field.Store.YES, Field.Index.TOKENIZED));
            doc.Add(new Field("sex", "男的", Field.Store.YES, Field.Index.UN_TOKENIZED));
            doc.Add(new Field("dosometing", "I am learning lucene ", Field.Store.YES, Field.Index.TOKENIZED));
            writer.AddDocument(doc);

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
            //DateTime startTime = DateTime.Now;
            IndexSearcher searcher = new IndexSearcher(_directory);  
            // 根据搜索关键字 封装一个term组合对象，然后封装成Query查询对象  
            // dosometing是上面定义的字段，lucene是检索的关键字  
            Query query = new TermQuery(new Term("dosometing", queryString));  
            // Query query = new TermQuery(new Term("sex", "男"));  
            // Query query = new TermQuery(new Term("name", "cheng"));   
          
            // 去索引目录中查询，返回的是TopDocs对象，里面存放的就是上面放的document文档对象  
            TopDocs rs = searcher.Search(query, null, 10);
            st.Stop();
            Console.WriteLine("总共花费 {0} 毫秒，检索到 {1} 条记录。", st.ElapsedMilliseconds, rs.totalHits);  
            for (int i = 0; i < rs.scoreDocs.Length; i++) {  
                // rs.scoreDocs[i].doc 是获取索引中的标志位id, 从0开始记录  
                Document firstHit = searcher.Doc(rs.scoreDocs[i].doc);  
                Console.WriteLine("name: {0}" , firstHit.GetField("name"));  
            }
            Console.WriteLine("*****************检索结束**********************");  
            #endregion
        }
    }
}
