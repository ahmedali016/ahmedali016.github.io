using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.netCoreTestall
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        void addbutton(Control con)
        {
            var j = new Button();
            j.Text = "adasfasfa";
            j.BackColor = System.Drawing.Color.Azure;
            con.Controls.Add(j);
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            addbutton(this.form1);
        }
    }
}