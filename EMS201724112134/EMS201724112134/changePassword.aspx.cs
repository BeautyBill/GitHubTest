using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112134
{
    public partial class changePasseord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string oldPass = oldPwd.Text.Trim();  //取出旧密码
            string newPass = newPwd.Text.Trim();         //取出新密码
            string repeatPwd = TextBox1.Text.Trim();
            //设置连接字符串
            String strConn =
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';";
            //实例化连接对象
            SqlConnection conn = new SqlConnection(strConn);
            //打开数据库连接
            conn.Open();
            if (Session["password"].ToString() == oldPass)
            {
                
                string sql = "update Employee set Emp_password='" + newPass + "' where Emp_name=N'" + Session["username"].ToString()+"'";
                //创建查询用户名的ＳＱＬ语句
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                    Response.Write("<script>alert('密码修改成功');</script>");
                    oldPwd.Text = "";
                    newPwd.Text = "";
                    TextBox1.Text = "";
                

            }

            else
            {
                Response.Write("<script>alert('密码错误，请重新登录');location.href='Default.aspx';</script>");
                oldPwd.Text = "";
                newPwd.Text = "";
                TextBox1.Text = "";

            }
            conn.Close();







        }





    }
}