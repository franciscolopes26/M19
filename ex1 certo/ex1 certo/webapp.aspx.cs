using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ex1_certo
{
    public partial class webapp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if(txt1.Text != "") 
            {
                lbl1.Text = "<h1>Bem vindo ao parque por favor retire o seu bilhete/a" + txt1.Text + "</h1>";
            }
            else
            {
                lbl1.Text = "<h1>Primeiro escreva o seu nome</h1>";
            }
            

        }
    }
}