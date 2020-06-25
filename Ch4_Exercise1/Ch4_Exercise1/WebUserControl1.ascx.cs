using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch4_Exercise1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        private string labelText;
        private Label resultLabel;


        public string LabelText
        {
            set
            {
                this.labelText = value;
            }
            get
            {
                return this.labelText;
            }

        }


        public Label ResultLabel
        {
            set
            {
                this.resultLabel = value;
            }
            get
            {
                return this.resultLabel;
            }
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            
                this.Label1.Text = this.labelText;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = TextBox1.Text;

        }
    }
}