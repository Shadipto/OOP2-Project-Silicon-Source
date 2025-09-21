using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SiliconSource
{
    internal class DataAccess
    {
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;
        private SqlDataAdapter sqlda;
        private DataSet ds;

        private readonly static string connectionString = "Data Source=SHADIPTO_PRANTO\\DIPTOSQLSERVER;Initial Catalog=SiliconSource;Integrated Security=True;";

        internal SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        internal SqlCommand Sqlcmd
        {
            get { return this.sqlcmd; }
            set { this.sqlcmd = value; }
        }

        internal SqlDataAdapter Sqlda
        {
            get { return this.sqlda; }
            set { this.sqlda = value; }
        }

        internal DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        internal DataAccess()
        { 
           this.Sqlcon = new SqlConnection(connectionString);
           Sqlcon.Open();
        }

        internal DataSet GetDataSet(string query)
        {
            this.Sqlcmd = new SqlCommand(query, this.Sqlcon);
            this.Sqlda = new SqlDataAdapter(this.Sqlcmd);
            this.Ds = new DataSet();
            this.Sqlda.Fill(this.Ds);
            return this.Ds;
        }
    }
}
