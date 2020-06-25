using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112134
{
   
    public partial class MainMasterPage : System.Web.UI.MasterPage
    {
       protected bool isAdmin = true;
        protected bool isDep = false;
        protected bool isEmp = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            String currName = null;
            
            if (Session["username"] == null || (currName = Session["username"].ToString()) == "")
            {
                
                Response.Redirect("/login.aspx");
                return;
            }
            if (Session["posid"] != null && Session["posid"].ToString() == "02")
            {
                isAdmin = false;
                isDep = true;
            }else if(Session["posid"] != null && Session["posid"].ToString() == "03")
            {
                isAdmin = false;
                isEmp = true;
            }
            labAdmin.Text = currName;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("id");
            Session.Remove("posid");
            Response.Redirect("/login.aspx");
        }
      
        
    }
}