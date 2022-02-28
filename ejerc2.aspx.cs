using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio2
{
    public partial class ejerc2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int numero1,resultado;
            numero1 = Convert.ToInt32(Txtnum.Text);
            resultado = Math.Abs(numero1);
            lblresul.Text = System.Convert.ToString(resultado);
        }
    }
}