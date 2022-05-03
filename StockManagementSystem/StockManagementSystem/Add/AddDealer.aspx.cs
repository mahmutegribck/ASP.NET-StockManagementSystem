using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMS_BAL;
using Entities;

public partial class Add_AddDealer : System.Web.UI.Page
{
    BAL businessLogic = new BAL();
    Common_Functions com_fn = new Common_Functions();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btn_Add_Dealer_Click(object sender, EventArgs e)
    {
        try
        {
            string dealer_registered_date = DateTime.Today.Date.ToShortDateString();
            com_fn.did = txt_did.Text.Trim();
            com_fn.dname = txt_dealer_name.Text.Trim();
            com_fn.dhouseno = txt_dealer_house_no.Text.Trim();
            com_fn.dstreetname = txt_dealer_street_name.Text.Trim();
            com_fn.darea = txt_dealer_area.Text.Trim();
            com_fn.dlandmark = txt_dealer_landmark.Text.Trim();
            com_fn.dcity = txt_dealer_city.Text.Trim();
            com_fn.dstate = txt_dealer_state.Text.Trim();
            com_fn.dpincode = txt_dealer_pincode.Text.Trim();
            com_fn.dcontactno = txt_dealer_contact_No.Text.Trim();
            com_fn.dlandlineno = txt_dealer_landline_no.Text.Trim();
            com_fn.dship_since = dealer_registered_date;
            businessLogic.Insert_Dealer(com_fn);
            Response.Redirect("~/Add/ViewDealer.aspx?dealerID=" + txt_did.Text);
        }
        catch
        {
            lbldate.Text = "Error ";
        }
    }
}