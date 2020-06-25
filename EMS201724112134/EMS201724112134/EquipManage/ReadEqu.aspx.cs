using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112134.EquipManage
{
    public partial class ReadEqu : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("select Eqm_id,Eqm_name,Eqm_standard,Eqm_picture,Eqm_price,Eqm_buydatetime= convert(varchar(12),Eqm_buydatetime, 111),Eqm_place,Eqm_person from Equip ", cn);
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
                    /* String sql = "select * from Equip where Eqm_id=@id or Eqm_name=@name or Eqm_buydatetime=convert(varchar(12),@buydatetime, 111) or Eqm_place=@place or Eqm_person=(select Eqm_person from Equip inner join " +
                         "Employee on Equip.Eqm_person = Employee.Emp_id where Employee.Emp_id = (select Emp_id from Employee where Emp_name = @name2))";
                     SqlCommand cmd = new SqlCommand(sql, cn);
                     cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                      cmd.Parameters["@id"].Value = txtBCaseID.Text.Trim();


                     Response.Write(sql.IndexOf("id") != -1);





                     cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                     cmd.Parameters.Add(new SqlParameter("@buydatetime", SqlDbType.Date));
                     cmd.Parameters.Add(new SqlParameter("@place", SqlDbType.NVarChar));
                     cmd.Parameters.Add(new SqlParameter("@name2", SqlDbType.NVarChar));



                     cmd.Parameters["@name"].Value = TextBox1.Text.Trim();
                     cmd.Parameters["@buydatetime"].Value = TextBox2.Text.Trim() ;
                     cmd.Parameters["@place"].Value = TextBox3.Text.Trim();
                     cmd.Parameters["@name2"].Value = TextBox4.Text.Trim();

     */

                    String sql = "select * from Equip where 1=1";

                 if (txtBCaseID.Text != "")
                    {

                        sql += (" and Eqm_id=@id");
                    }
                    if (TextBox1.Text != "")
                    {

                        sql += (" and Eqm_name=@name");
                    }
                    if (TextBox2.Text != "")
                    {

                        sql += (" and Eqm_buydatetime=convert(varchar(12),@buydatetime, 111)");
                    }
                    if (TextBox3.Text != "")
                    {

                        sql += (" and Eqm_place=@place");
                    }
                    if (TextBox4.Text != "")
                    {

                        sql += (" and Eqm_person=(select Eqm_person from Equip inner join " +
                         "Employee on Equip.Eqm_person = Employee.Emp_id where Employee.Emp_id = (select Emp_id from Employee where Emp_name = @name2))");
                    }
                    if (TextBox5.Text != "")
                    {

                        sql += (" and  Eqm_person=(select Emp_id from (select * from Department a inner join Employee on Dep_id=Emp_depid where Dep_id=(select Dep_id from Department where Dep_name=@depname)) as a inner join Equip on Equip.Eqm_person=Emp_id)");
                    }
                    SqlCommand cmd = new SqlCommand(sql, cn);


                    if (sql.IndexOf("id") != -1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                        cmd.Parameters["@id"].Value = txtBCaseID.Text.Trim();
                    }
                    if (sql.IndexOf("name") != -1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                        cmd.Parameters["@name"].Value = TextBox1.Text.Trim();
                    }
                    if (sql.IndexOf("buydatetime") != -1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@buydatetime", SqlDbType.Date));
                        cmd.Parameters["@buydatetime"].Value = TextBox2.Text.Trim();
                    }
                    if (sql.IndexOf("place") != -1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@place", SqlDbType.NVarChar));
                        cmd.Parameters["@place"].Value = TextBox3.Text.Trim();
                    }
                    if (sql.IndexOf("person") != -1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@name2", SqlDbType.NVarChar));
                        cmd.Parameters["@name2"].Value = TextBox4.Text.Trim();
                    }
                    if (sql.IndexOf("depname") != -1)
                    {
                        cmd.Parameters.Add(new SqlParameter("@depname", SqlDbType.NVarChar));
                        cmd.Parameters["@depname"].Value = TextBox5.Text.Trim();
                    }
                
                    SqlDataReader data = cmd.ExecuteReader();
                    GridView1.DataSource = data;

                    GridView1.DataBind();
                   

                }
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('查询失败')</script>");
                 Response.Write("id:" + txtBCaseID.Text);

            }
        }

       

        protected void RowSelector_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;

           Session["roll_no"]=row.Cells[4].Text;
            string sConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';";

            SqlConnection objConn = new SqlConnection(sConn);

            objConn.Open();

            string sql = "select * from Images where Roll_no="+ row.Cells[4].Text;

            SqlCommand cmd = new SqlCommand(sql, objConn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                byte[] bytes = (byte[])dr["img"];

                FileStream fs = new FileStream(@Server.MapPath("/")+"images/" + dr["roll_no"] + ".jpg", FileMode.Create, FileAccess.Write);
               

                fs.Write(bytes, 0, bytes.Length);

                fs.Flush();

                fs.Close();

            }

           
            dr.Close();

            objConn.Close();

           
         
            Response.Redirect("../showPicture.aspx?path");
           
        }
    }
}