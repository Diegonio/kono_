using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace kono_
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Oculta la barra de navegación si no hay usuario en sesión
            try
            {
                var logged = Session != null && Session["User"] != null;
                // mostrar/ocultar navbar
                navBar.Visible = logged;

                // Si no está logueado, evitar que el brand enlace al login
                if (brandLink != null)
                {
                    if (logged)
                    {
                        // cuando está logueado, llevar a la página principal
                        brandLink.HRef = ResolveUrl("~/About");
                    }
                    else
                    {
                        // cuando no está logueado, no enlazar (o enlazar a javascript void)
                        brandLink.HRef = "javascript:void(0);";
                    }
                }
            }
            catch
            {
                // Si falla (por ejemplo en tiempo de diseño), no interrumpir
            }
        }
    }
}
