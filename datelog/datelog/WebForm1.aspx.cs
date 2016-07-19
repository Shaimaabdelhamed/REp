using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace requiredtasks
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string path;
        int counter=0;
       // ViewState["counter"] = counter;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                counter++;
                ViewState["counter"] = counter;               
            }
            Timer1.Tick += Timer1_Tick;
            path = Server.MapPath("~/");
            Image1.ImageUrl = @"\imgas\ho1.jpg";
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter = (int) ViewState["counter"];          
           // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('"+ counter+"' )", true);          
            report rprt = new report();
            int count = (int) ViewState["counter"];
            Label1.Text = count.ToString();
            counter++;
            ViewState["counter"]= counter;

            using (StreamWriter w = File.AppendText(@path + @"\log.txt"))
            {
                rprt.Writetxt("Hi", w);
                //math.path
            }
           
        }
    }
}