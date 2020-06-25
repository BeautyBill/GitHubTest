using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace EMS201724112134
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                if ((extension == ".jpg") || (extension == ".png") || (extension == ".gif") || (extension == ".bmp"))
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

                        Response.Write("导入成功");
                    }
                }
                else
                {
                    Response.Write("导入失败"); return;
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';";

            SqlConnection objConn = new SqlConnection(sConn);

            objConn.Open();

            string sql = "select * from Images";

            SqlCommand cmd = new SqlCommand(sql, objConn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                byte[] bytes = (byte[])dr["img"];

                FileStream fs = new FileStream(@"D:\Images\" + dr["roll_no"] + ".jpg", FileMode.Create, FileAccess.Write);

                fs.Write(bytes, 0, bytes.Length);

                fs.Flush();

                fs.Close();

            }

            dr.Close();

            objConn.Close();

            Response.Write("成功导出"); 


        }
    }
}