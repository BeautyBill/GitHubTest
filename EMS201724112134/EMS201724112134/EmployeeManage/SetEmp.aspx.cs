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
    public partial class CreateEmp : System.Web.UI.Page
    {
        string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
      "AttachDbFilename=|DataDirectory|Database1.mdf;" +
      "Integrated Security=True";

      
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
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
                        "alter table Employee nocheck constraint all;" +
    "INSERT INTO Employee(Emp_id,Emp_password,Emp_name,Emp_telephone,Emp_depid,Emp_posid)VALUES(@Emp_id,@Emp_password,@Emp_name,@Emp_telephone,@Emp_depid,@Emp_posid);" +
    "ALTER TABLE Department CHECK CONSTRAINT ALL";
                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@Emp_id", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@Emp_password", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@Emp_name", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@Emp_telephone", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@Emp_depid", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@Emp_posid", SqlDbType.Char));
                    cmd.Parameters["@Emp_id"].Value = txtBCaseID.Text;
                    cmd.Parameters["@Emp_password"].Value = txtBCaseName.Text;
                    cmd.Parameters["@Emp_name"].Value = TextBox1.Text;
                    cmd.Parameters["@Emp_telephone"].Value = TextBox2.Text;
                    cmd.Parameters["@Emp_depid"].Value = TextBox3.Text;
                    cmd.Parameters["@Emp_posid"].Value = DropDownList1.SelectedValue;

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
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedValue = "01";

        
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();

                    string sqlstr =

         "Update Employee set Emp_password=@password,Emp_name=@name,Emp_telephone=@telephone,Emp_depid=@depid,Emp_posid=@posid where Emp_id=@id;";


                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@telephone", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@depid", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@posid", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));

                    cmd.Parameters["@password"].Value = txtBCaseName.Text;
                    cmd.Parameters["@name"].Value = TextBox1.Text;
                    cmd.Parameters["@telephone"].Value = TextBox2.Text;
                    cmd.Parameters["@depid"].Value = TextBox3.Text;
                    cmd.Parameters["@posid"].Value = DropDownList1.SelectedValue;
                    cmd.Parameters["@id"].Value = txtBCaseID.Text;



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
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedValue = "01";


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();

                    string sqlstr =

    "Delete from Employee where Emp_id=@id"; 
  

                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                 

                    cmd.Parameters["@id"].Value = txtBCaseID.Text;
              


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
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedValue = "01";


        }

    }
}
