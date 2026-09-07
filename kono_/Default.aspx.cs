using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kono_
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;

            // Usuarios de ejemplo en memoria
            // Daniela -> Daniela@123
            // Gerber  -> Gerber@123
            // Diego   -> Diego@123
            var users = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Daniela", "Daniela@123" },
                { "Gerber", "Gerber@123" },
                { "Diego", "Diego@123" }
            };

            if (users.TryGetValue(user, out var storedPass) && storedPass == pass)
            {
                Session["User"] = user;
                Response.Redirect("~/About.aspx");
            }
            else
            {
                lblMessage.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}