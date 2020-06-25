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
    public partial class CreateEqu : System.Web.UI.Page
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
    "INSERT INTO Equip(Eqm_id,Eqm_name,Eqm_standard,Eqm_picture,Eqm_price,Eqm_buydatetime,Eqm_place,Eqm_person)VALUES(@id,@name,@standard,@picture,@price,@buydatetime,@place,@person)";
                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@standard", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@picture", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Float));
                    cmd.Parameters.Add(new SqlParameter("@buydatetime", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@place", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@person", SqlDbType.Char));
                    //对前台输入的时间进行处理


                    cmd.Parameters["@id"].Value = txtBCaseID.Text;
                    cmd.Parameters["@name"].Value = txtBCaseName.Text;
                    cmd.Parameters["@standard"].Value = TextBox1.Text;
                    cmd.Parameters["@picture"].Value = txtrollno.Text;
                    cmd.Parameters["@price"].Value = Convert.ToDouble(TextBox3.Text);
                    cmd.Parameters["@buydatetime"].Value = Convert.ToDateTime(TextBox4.Text).ToString("yyyy-MM-dd"); ;
                    cmd.Parameters["@place"].Value = TextBox5.Text;
                    cmd.Parameters["@person"].Value = TextBox6.Text;


                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('添加设备成功')</script>");

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
                Response.Write("<script>alert('添加设备失败')</script>");

            }
            txtBCaseID.Text = "";
            txtBCaseName.Text = "";
            TextBox1.Text = "";
            txtrollno.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
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

    "Delete from Equip where Eqm_id=@id";
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));


                    cmd.Parameters["@id"].Value = txtBCaseID.Text;


                 
                    cmd.ExecuteNonQuery();
                   
                    Response.Write("<script>alert('删除设备成功')</script>");

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('删除设备失败')</script>");

            }
            txtBCaseID.Text = "";
            txtBCaseName.Text = "";
            TextBox1.Text = "";
            txtrollno.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";



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

         "Update Equip set Eqm_name=@name,Eqm_standard=@standard,Eqm_picture=@picture,Eqm_price=@price,Eqm_buydatetime=@buydatetime,Eqm_place=@place,Eqm_person=@person where Eqm_id=@id;";


                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@standard", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@picture", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Float));
                    cmd.Parameters.Add(new SqlParameter("@buydatetime", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@place", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@person", SqlDbType.Char));
                    //对前台输入的时间进行处理


                    cmd.Parameters["@id"].Value = txtBCaseID.Text;
                    cmd.Parameters["@name"].Value = txtBCaseName.Text;
                    cmd.Parameters["@standard"].Value = TextBox1.Text;
                    cmd.Parameters["@picture"].Value = txtrollno.Text;
                    cmd.Parameters["@price"].Value = Convert.ToDouble(TextBox3.Text);
                    cmd.Parameters["@buydatetime"].Value = Convert.ToDateTime(TextBox4.Text).ToString("yyyy-MM-dd");
                    cmd.Parameters["@place"].Value = TextBox5.Text;
                    cmd.Parameters["@person"].Value = TextBox6.Text;


                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('修改设备信息成功')</script>");

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
                Response.Write("<script>alert('修改设备信息失败')</script>");

            }
            txtBCaseID.Text = "";
            txtBCaseName.Text = "";
            TextBox1.Text = "";
            txtrollno.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!FileUpload1.HasFile)
            {
                Response.Write("未选择文件");
                return;
            }


            else
            {
                //创建访问上传文件的对象，并获取上传的文件
                HttpPostedFile file = FileUpload1.PostedFile;

                //获取上传文件的文件名和扩展名
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string extension = Path.GetExtension(filename);

                //实例化一个byte数组，其长度等于上传文件的长度
                byte[] imagetype = new byte[file.ContentLength];

                //将文件数据读取到byte数组中
                file.InputStream.Read(imagetype, 0, file.ContentLength);

                //判断图片格式
                if ((extension.ToLower() == ".jpg") || (extension.ToLower() == ".png") || (extension.ToLower() == ".gif") || (extension.ToLower() == ".bmp"))
                {
                    //表里写入数据
                    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';"))
                    {

                        connection.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        string commandText = "Insert  into Images(Roll_no,Name_File,Extension,img,Img_date) values ( @Rollno,@filename,@extension,@image,getdate())";

                        cmd.CommandText = commandText;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@Rollno", SqlDbType.VarChar);
                        cmd.Parameters["@Rollno"].Value = txtrollno.Text;
                        cmd.Parameters.Add("@filename", SqlDbType.VarChar);
                        cmd.Parameters["@filename"].Value = filename;
                        cmd.Parameters.Add("@extension", SqlDbType.VarChar);
                        cmd.Parameters["@extension"].Value = extension;
                        cmd.Parameters.Add("@image", SqlDbType.VarBinary);
                        cmd.Parameters["@image"].Value = imagetype;






                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();

                       Label1.Text="导入成功";
                    }
                }
                else
                {
                    Label1.Text = "导入失败"; return;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();

                    string sqlstr2 = "alter table Equip nocheck constraint all;" +
                     "Delete from Images where Roll_no=(select Eqm_picture from Equip where Eqm_id=@id2 );" +
                     "ALTER TABLE Equip CHECK CONSTRAINT ALL";
                    // 建立SqlCommand对象cmd
                    SqlCommand cmd2 = new SqlCommand(sqlstr2, cn);
                    cmd2.Parameters.Add(new SqlParameter("@id2", SqlDbType.Char));


                    cmd2.Parameters["@id2"].Value = txtBCaseID.Text;

                    cmd2.ExecuteNonQuery();
                    Label1.Text = "删除成功";

                }
            }
            catch (Exception ex)
            {
                Label1.Text = "删除失败";


            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!FileUpload1.HasFile)
            {
                Response.Write("未选择文件");
                return;
            }


            else
            {
                //创建访问上传文件的对象，并获取上传的文件
                HttpPostedFile file = FileUpload1.PostedFile;

                //获取上传文件的文件名和扩展名
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string extension = Path.GetExtension(filename);

                //实例化一个byte数组，其长度等于上传文件的长度
                byte[] imagetype = new byte[file.ContentLength];

                //将文件数据读取到byte数组中
                file.InputStream.Read(imagetype, 0, file.ContentLength);

                //判断图片格式
                if ((extension.ToLower() == ".jpg") || (extension.ToLower() == ".png") || (extension.ToLower() == ".gif") || (extension.ToLower() == ".bmp"))
                {
                    //表里写入数据
                    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';"))
                    {

                        connection.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;

                        string commandText = "Update Images set Name_File=@filename,Extension=@extension,img=@image,Img_date=getdate() where Roll_no=@Rollno"; 

                        cmd.CommandText = commandText;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@Rollno", SqlDbType.VarChar);
                        cmd.Parameters["@Rollno"].Value = txtrollno.Text;
                        cmd.Parameters.Add("@filename", SqlDbType.VarChar);
                        cmd.Parameters["@filename"].Value = filename;
                        cmd.Parameters.Add("@extension", SqlDbType.VarChar);
                        cmd.Parameters["@extension"].Value = extension;
                        cmd.Parameters.Add("@image", SqlDbType.VarBinary);
                        cmd.Parameters["@image"].Value = imagetype;






                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();

                        Label1.Text = "修改成功";
                    }
                }
                else
                {
                    Label1.Text = "修改失败"; return;
                }
            }
        }
    }
}
