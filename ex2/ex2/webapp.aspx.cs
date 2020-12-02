using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ex2
{
    public partial class webapp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i <= 10; i++)
                {

                    ddlist.Items.Add(i.ToString());
                }
            }
            else
            {
                lbox1.Items.Clear();
            }
           
        }

        protected void ddlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {

        

                int resul = int.Parse(ddlist.Text);
                int res = 0;
                for (int i = 0; i <= 10; i++)
                {
                    res = i * resul;
                    lbox1.Items.Add(i.ToString() + "X" + resul.ToString() + "=" + res.ToString());

                Table1.Rows[i].Cells[0].Text = resul.ToString();

                Table1.Rows[i].Cells[4].Text = res.ToString();


            }
            
        }
    }
}