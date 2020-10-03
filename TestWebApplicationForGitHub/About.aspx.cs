using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebApplicationForGitHub
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if(!IsPostBack)
                {
                //You have write the code here if you to load data at the first time only.
                }
        }
    }
}
