using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112134
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string username = txtName.Text.Trim();  //取出账号
            string pw = txtPwd.Text.Trim();         //取出密码
            string posid = DropDownList1.SelectedValue.ToString();
            //设置连接字符串
            String strConn =
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';";
            //实例化连接对象
            SqlConnection conn = new SqlConnection(strConn);
            //打开数据库连接
            conn.Open();
            string sql = "select Emp_name,Emp_password,Emp_posid from Employee where Emp_name=N'" + username + "' and Emp_password='" + pw + "' and Emp_posid='" + posid + "'";
            //创建查询用户名的ＳＱＬ语句
            SqlCommand cmd = new SqlCommand(sql, conn);
            //创建命令对象，连接数据源和设置ＳＱＬ语句
            SqlDataReader dr = cmd.ExecuteReader();
            //通过 ExecuteReader 方法创建DataReader对象
             if (dr.Read())//判断是否有记录
                {
                    if (dr["Emp_password"].ToString() == txtPwd.Text) //判断密码是否一致
                    {
                    Session["posid"] = posid;
                    Session["username"] = username;
                    Session["password"] = pw;
                    Response.Redirect("loginDefault.aspx");
                  
                }

            }
            else
            {
                Response.Write("<script>alert('账号或密码错误，请重新登录');location.href='Default.aspx';</script>");
                txtName.Text = "";
                txtPwd.Text = "";
                DropDownList1.SelectedValue = "01";

            }
              

                conn.Close();





        }

       
    }
}