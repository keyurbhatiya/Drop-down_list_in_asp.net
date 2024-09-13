using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            String[] str = new String[] { " Select ", "AVENGER'S LOGO", "IRON_MAN","CAPTAIN_MARVEL","THOR","CAPTAIN_AMERICA","SPIDER_MAN","DOCTOR_STRANGE","NATASHA","WANDA","HULK" };
            for (int i=0; i<str.Length; i++)
            {
                DropDownList1.Items.Add(str[i]);
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String str = DropDownList1.Text;
        Image1.ImageUrl = "/IMG/" + str + ".JPG";
    }
}