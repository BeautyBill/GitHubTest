using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112134.EmployeeManage
{
    public partial class ReadEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //只在第1次截入运行
            if (!Page.IsPostBack)
            {
                using (SqlConnection cn = new SqlConnection())
                {

                    cn.ConnectionString =
                        "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Employee ", cn);
                    SqlDataReader data = cmd.ExecuteReader();
                    GridView1.DataSource = data;
                    GridView1.DataBind();
                }
            }
        }

        protected void btnSearch_Click1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString =
                       "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';";
                    cn.Open();
                    string sql = "select * from Employee where 1=1";
                    if (txtBCaseID.Text != "")
                    {
                        sql += " and Emp_id=@id";
                    }
                    if (TextBox1.Text != "")
                    {
                        sql += " and Emp_name=@name";
                    }

                    SqlCommand cmd = new SqlCommand(sql, cn);
                    if (sql.IndexOf("id") != -1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));

                        cmd.Parameters["@id"].Value = txtBCaseID.Text;
                    }
                    if (sql.IndexOf("name")!=-1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));

                        cmd.Parameters["@name"].Value = TextBox1.Text;
                    }
                  

                    SqlDataReader data = cmd.ExecuteReader();
                    GridView1.DataSource = data;
                    GridView1.DataBind();

                }
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('查询失败')</script>");

            }
        }
    }
}