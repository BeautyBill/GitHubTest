using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112134.DepartmentManage
{
    public partial class ReadDep1 : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("select Dep_id,Dep_name,Emp_id,Emp_name,Emp_posid from Department inner join Employee on Dep_id=Emp_depid order by Dep_id ", cn);
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
                    SqlCommand cmd = new SqlCommand("select Dep_id,Dep_name ,Emp_id,Emp_name,Emp_posid from Department inner join Employee  on Dep_id=Emp_depid where Dep_id=(select Dep_id from Department where Dep_name=@name)", cn);
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                    cmd.Parameters["@name"].Value = txtBCaseID.Text;
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