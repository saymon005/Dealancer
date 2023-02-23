using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectPrepared.Models
{
    public class PostClass
    {
        SqlConnection con = new SqlConnection();
        List<PostClass> PostList = new List<PostClass>();
        public String CName { get; set; }
        public String postTitle { get; set; }
        public String postBody { get; set; }
        public String postDate { get; set; }

        PostClass p = null;
        public List<PostClass> GetPost()
        {

            con.ConnectionString = "data source=SAYMON\\SQLEXPRESS01;initial catalog=projectDB;integrated security=True";
;


             con.Open();

            using (con)
            {

                SqlCommand cmd = new SqlCommand("Select * from posttable", con);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())

                {

                    p = new PostClass();
                    p.CName = Convert.ToString(rd.GetSqlValue(0));
                    p.postTitle = Convert.ToString(rd.GetSqlValue(1));
                    p.postBody = Convert.ToString(rd.GetSqlValue(2));
                    p.postDate = Convert.ToString(rd.GetSqlValue(3));
                    PostList.Add(p);

                }
            }
            return PostList;
        }

    }
}