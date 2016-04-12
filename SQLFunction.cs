using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFunction
{
    public class SQLFunction
    {
        private SqlConnection con;
        private string dataSource = "SHIN\\SQLEXPRESS";
        public SQLFunction()//預設連接資料庫
        {
            con = new SqlConnection("Data Source=" + dataSource +";Initial Catalog=NTUT;Integrated Security=True"); 
        }

        public SQLFunction(string userName, string password)//連接資料庫需要UID和PWD時
        {
            con = new SqlConnection(string.Format("Data Source=" + dataSource + ";Initial Catalog=NTUT;Integrated Security=True;UID={0};PWD={1}", userName, password));
        }

        #region

        public List<string> GetSelectField()//取得所有欄位
        {
            List<string> fieldName=new List<string>();            
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select b.name from sysobjects as a, syscolumns as b where a.xtype = 'U' and a.id = b.id and a.name='查詢';";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tt = new DataTable();
            tt.Load(reader);
            if (tt.Rows.Count > 0)            
                foreach (DataRow rr in tt.Rows)                
                    fieldName.Add(rr[0].ToString());                            
            reader.Close();
            con.Close();
            return fieldName;
        }

        public List<string> GetSelectFieldValue(string fieldName)//取得特定欄位值
        {
            List<string> fieldNameValue = new List<string>();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select distinct " + fieldName + " from 查詢 order by " + fieldName + " ASC;";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tt = new DataTable();
            tt.Load(reader);
            if (tt.Rows.Count > 0)            
                foreach (DataRow rr in tt.Rows)                
                    fieldNameValue.Add(rr[0].ToString());                            
            reader.Close();
            con.Close();
            return fieldNameValue;
        }

        public DataTable GetDataTable(string fieldName1, string fieldValue1, string fieldName2, string fieldValue2)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from 查詢 where " + fieldName1 + "='" + fieldValue1 + "' and " + fieldName2 + "='" + fieldValue2 + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tt = new DataTable();
            tt.Load(reader);            
            reader.Close();
            con.Close();            
            return tt;            
        }
        #endregion        
    }
}
