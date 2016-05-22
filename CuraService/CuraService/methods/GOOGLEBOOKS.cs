using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;
using Google.API.Search;

namespace CuraService.methods
{
    class GOOGLEBOOKS
    {
        
        
        public DataTable gglbks(string srch)
        {
            DataTable rslt = new DataTable("result", "google");            

            rslt.Columns.Add(new DataColumn("Title", typeof(string)));//[0]
            rslt.Columns.Add(new DataColumn("Author", typeof(string)));//[1]
            rslt.Columns.Add(new DataColumn("Url", typeof(string)));//[2]
            rslt.Columns.Add(new DataColumn("Image", typeof(string)));//[3]
            rslt.Columns.Add(new DataColumn("Year", typeof(string)));//[4]
            rslt.Columns.Add(new DataColumn("Page", typeof(string)));//[5]       
            GbookSearchClient client = new GbookSearchClient("");
            string srchtrm = srch;
            IList<IBookResult> Results = client.Search(srchtrm, 20);

            foreach (IBookResult result in Results)
            {
                DataRow dr = rslt.NewRow();
                
                dr[0] = result.Title.ToString();
                dr[1] = result.Authors.ToString();
                dr[2] = result.Url.ToString();
                dr[3] = result.TbImage;
                dr[4] = result.PublishedYear.ToString();
                dr[5] = result.PageCount.ToString();
                rslt.Rows.Add(dr);
            }
            return rslt;
        }

    }
}
