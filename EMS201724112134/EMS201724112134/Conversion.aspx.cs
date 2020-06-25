using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;

namespace EMS201724112134
{
    public partial class Conversion : System.Web.UI.Page
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
                        using (SqlConnection connection = new SqlConnection( "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = '|DataDirectory|\\Database1.mdf'; "))
                        {

                            connection.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;

                            string commandText = "Insert into Images values (@image, @Rollno,@img,getdate())";

                            cmd.CommandText = commandText;
                            cmd.CommandType = CommandType.Text;

                            cmd.Parameters.Add("@image", SqlDbType.VarBinary);
                            cmd.Parameters["@image"].Value = imagetype;

                            cmd.Parameters.Add("@Rollno", SqlDbType.VarChar);
                            cmd.Parameters["@Rollno"].Value = txtrollno.Text;

                            cmd.Parameters.Add("@img", SqlDbType.VarChar);
                            cmd.Parameters["@img"].Value = txtrollno.Text;


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
        }
    }

