using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112134
{
    public partial class showPicture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = "~/images/"+Session["roll_no"]+".jpg";
          
            Image1.ImageUrl = path;





            //只在第1次截入运行
            if (!Page.IsPostBack)
            {
                using (SqlConnection cn = new SqlConnection())
                {

                    cn.ConnectionString =
                        "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\Database1.mdf';";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select Roll_no,Name_file,Extension,Img_date=convert(varchar(12),Img_date, 111) from Images where Roll_no=" + Session["roll_no"], cn);
                    SqlDataReader data = cmd.ExecuteReader();
                    GridView1.DataSource = data;
                    GridView1.DataBind();
                }
            }
        }

       
    }
}