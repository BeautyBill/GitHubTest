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
    public partial class CreateDep : System.Web.UI.Page
    {
        string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
     "AttachDbFilename=|DataDirectory|Database1.mdf;" +
     "Integrated Security=True";


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();

                    string sqlstr =
    "INSERT INTO Department(Dep_id,Dep_name,Dep_mgid)VALUES(@id,@name,@mgid);" +
    "UPDATE Employee SET Emp_depid=@id2,Emp_posid='02' where Emp_id=@mgid2";
                   
                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));              
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@mgid", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@id2", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@mgid2", SqlDbType.Char));

                    cmd.Parameters["@id"].Value = txtBCaseID.Text;
                    cmd.Parameters["@name"].Value = txtBCaseName.Text;
                    cmd.Parameters["@mgid"].Value = TextBox1.Text;
                    cmd.Parameters["@id2"].Value = txtBCaseID.Text;
                    cmd.Parameters["@mgid2"].Value = TextBox1.Text;


                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('添加信息成功')</script>");
                  

                }
            }
            catch (Exception ex)
            {
                
                Response.Write("<script>alert('添加信息失败')</script>");
              
            }

            txtBCaseID.Text = "";
            txtBCaseName.Text = "";
            TextBox1.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();

                    string sqlstr =
         "alter table Employee nocheck constraint all;" +
         " Update Employee set Emp_posid='03' where Emp_depid=@depid and Emp_posid=02;" +
         "alter table Department nocheck constraint all ;"+
         "Update Department set Dep_name=@name,Dep_mgid=@mgid where Dep_id=@id;"+
         "Update Employee set Emp_posid='02' where Emp_id=@empid;"+
         "ALTER TABLE Department CHECK CONSTRAINT ALL;"+
         "ALTER TABLE Employee CHECK CONSTRAINT ALL";
                   
                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);                 
                    cmd.Parameters.Add(new SqlParameter("@depid", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@mgid", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@empid", SqlDbType.Char));
                    cmd.Parameters["@depid"].Value = txtBCaseID.Text;
                    cmd.Parameters["@name"].Value = txtBCaseName.Text;
                    cmd.Parameters["@mgid"].Value = TextBox1.Text;
                    cmd.Parameters["@id"].Value = txtBCaseID.Text;
                    cmd.Parameters["@empid"].Value = TextBox1.Text;



                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('修改信息成功')</script>");
                }
            }
            catch (Exception ex)
            {
              
                Response.Write("<script>alert('修改信息失败')</script>");
               
            }
            txtBCaseID.Text = "";
            txtBCaseName.Text = "";
            TextBox1.Text = "";
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();

                    string sqlstr =
    "alter table Department nocheck constraint all;" +
      "alter table Employee nocheck constraint all;" +
    "Delete from Department where Dep_id=@id;" +
    "Delete from Employee where Emp_depid=@depid;" +
     "ALTER TABLE Department CHECK CONSTRAINT ALL;" +
    "ALTER TABLE Employee CHECK CONSTRAINT ALL";

                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@depid", SqlDbType.Char));

                    cmd.Parameters["@id"].Value = txtBCaseID.Text;
                    cmd.Parameters["@depid"].Value = txtBCaseID.Text;


                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('删除信息成功')</script>");

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('删除信息失败')</script>");
                
            }
            txtBCaseID.Text = "";
            txtBCaseName.Text = "";
            TextBox1.Text = "";
        }
        }
}