using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace WcfCineStar.db
{
    
        public class Db
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            public Db(string _cn)
            {
            cn = new SqlConnection("Data Source=SQL8006.site4now.net;Initial Catalog=db_a9d4c4_cinesta;User Id=db_a9d4c4_cinesta_admin;Password=Senati2023@");
            cmd = new SqlCommand("", cn);
            }
            internal void Sentencia(string _sql)
            {
                cmd = new SqlCommand(_sql, cn);
            }
            internal void Parametros(params object[] parametros)
            {
                for (int i = 0; i < parametros.Length; i++)
                {
                    cmd.CommandText += " @" + (i + 1) + (i < parametros.Length - 1 ? "," : "");
                    cmd.Parameters.AddWithValue("@" + (i + 1), parametros[i]);
                }

            }
            internal DataSet getDataSet()
            {
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            internal DataTable getDataTable()
            {
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        dt.Rows[i].ItemArray = System.Array.ConvertAll(dt.Rows[i].ItemArray, x => x.ToString().Trim());
                    return dt;
                }
                return null;
            }
            internal DataRow getDataRow()
            {
                DataTable dt = getDataTable();
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }

            internal int Ejecutar()
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                return cmd.ExecuteNonQuery();
            }

        }
    }
