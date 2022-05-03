using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entities;
using SMS_BAL;

public partial class Add_EditDealer : System.Web.UI.Page
{
    Common_Functions _com_fn_dealer_id = new Common_Functions();
    BAL businessLogic = new BAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Request.QueryString["dealerID"] = "0";
            if (Request.QueryString["dealerID"] != null)
            {
                string ID = Request.QueryString["dealerID"].ToString();
                Get_Dealer_With_ID(ID);
            }
            else
            {
                Reset();
            }
        }
    }
    public void Get_Dealer_With_ID(string Id)
    {
        DataSet ds = new DataSet();
        _com_fn_dealer_id.did = Id;
        ds = businessLogic.Get_Dealer_with_ID(_com_fn_dealer_id);
        if (ds.Tables[0].Rows.Count > 0)
        {
            txt_dealer_id.Text = ds.Tables[0].Rows[0]["dealerid"].ToString();
            txt_dealer_id.ReadOnly = true;
            txt_dealer_id.Style.Add("background", "#fafafa");
            Btn_Get_Details.Visible = false;
            txt_dealer_name.Text = ds.Tables[0].Rows[0]["dealername"].ToString();
            txt_dealer_house_no.Text = ds.Tables[0].Rows[0]["dealerhouseno"].ToString();
            txt_dealer_street_name.Text = ds.Tables[0].Rows[0]["dealerstreetname"].ToString();
            txt_dealer_area.Text = ds.Tables[0].Rows[0]["dealerarea"].ToString();
            txt_dealer_landmark.Text = ds.Tables[0].Rows[0]["dealerlandmark"].ToString();
            txt_dealer_city.Text = ds.Tables[0].Rows[0]["dealercity"].ToString();
            txt_dealer_state.Text = ds.Tables[0].Rows[0]["dealerstate"].ToString();
            txt_dealer_pincode.Text = ds.Tables[0].Rows[0]["dealerpincode"].ToString();
            txt_dealer_contact_No.Text = ds.Tables[0].Rows[0]["dealercontactno"].ToString();
            txt_dealer_landline_no.Text = ds.Tables[0].Rows[0]["dealerlandlineno"].ToString();
            Btn_Update_Dealer.Visible = true;
            Btn_Reset.Visible = true;
            ReadOnlyColorWhite();
        }
    }

    public void TextBoxReadOnlyTrue()
    {
        txt_dealer_name.ReadOnly = true;
        txt_dealer_house_no.ReadOnly = true;
        txt_dealer_street_name.ReadOnly = true;
        txt_dealer_area.ReadOnly = true;
        txt_dealer_landmark.ReadOnly = true;
        txt_dealer_city.ReadOnly = true;
        txt_dealer_state.ReadOnly = true;
        txt_dealer_pincode.ReadOnly = true;
        txt_dealer_contact_No.ReadOnly = true;
        txt_dealer_landline_no.ReadOnly = true;
        ReadOnlyColorChange();
    }
    public void TextBoxReadOnlyFalse()
    {
        txt_dealer_name.ReadOnly = false;
        txt_dealer_house_no.ReadOnly = false;
        txt_dealer_street_name.ReadOnly = false;
        txt_dealer_area.ReadOnly = false;
        txt_dealer_landmark.ReadOnly = false;
        txt_dealer_city.ReadOnly = false;
        txt_dealer_state.ReadOnly = false;
        txt_dealer_pincode.ReadOnly = false;
        txt_dealer_contact_No.ReadOnly = false;
        txt_dealer_landline_no.ReadOnly = false;
        ReadOnlyColorChange();
    }

    public void ReadOnlyColorChange()
    {
        txt_dealer_name.Style.Add("background", "#fafafa");
        txt_dealer_house_no.Style.Add("background", "#fafafa");
        txt_dealer_street_name.Style.Add("background", "#fafafa");
        txt_dealer_area.Style.Add("background", "#fafafa");
        txt_dealer_landmark.Style.Add("background", "#fafafa");
        txt_dealer_city.Style.Add("background", "#fafafa");
        txt_dealer_state.Style.Add("background", "#fafafa");
        txt_dealer_pincode.Style.Add("background", "#fafafa");
        txt_dealer_contact_No.Style.Add("background", "#fafafa");
        txt_dealer_landline_no.Style.Add("background", "#fafafa");
    }

    public void ReadOnlyColorWhite()
    {
        txt_dealer_name.Style.Add("background", "#ffffff");
        txt_dealer_house_no.Style.Add("background", "#ffffff");
        txt_dealer_street_name.Style.Add("background", "#ffffff");
        txt_dealer_area.Style.Add("background", "#ffffff");
        txt_dealer_landmark.Style.Add("background", "#ffffff");
        txt_dealer_city.Style.Add("background", "#ffffff");
        txt_dealer_state.Style.Add("background", "#ffffff");
        txt_dealer_pincode.Style.Add("background", "#ffffff");
        txt_dealer_contact_No.Style.Add("background", "#ffffff");
        txt_dealer_landline_no.Style.Add("background", "#ffffff");
    }

    protected void Btn_Get_Details_Click(object sender, EventArgs e)
    {
        Get_Dealer_With_ID(txt_dealer_id.Text.Trim());
        TextBoxReadOnlyFalse();
        ReadOnlyColorWhite();
    }

    protected void Btn_Reset_Click(object sender, EventArgs e)
    {
        Reset();
    }

    public void Reset()
    {
        ClearData();
        txt_dealer_id.ReadOnly = false;
        txt_dealer_id.Attributes.Add("placeholder", "Please Enter Dealer ID");
        txt_dealer_id.Style.Add("background", "#ffffff");
        Btn_Get_Details.Visible = true;
        Btn_Update_Dealer.Visible = false;
        Btn_Reset.Visible = false;
        TextBoxReadOnlyTrue();
    }
    public void ClearData()
    {
        txt_dealer_id.Text = "";
        txt_dealer_name.Text = "";
        txt_dealer_house_no.Text = "";
        txt_dealer_street_name.Text = "";
        txt_dealer_area.Text = "";
        txt_dealer_landmark.Text = "";
        txt_dealer_city.Text = "";
        txt_dealer_state.Text = "";
        txt_dealer_pincode.Text = "";
        txt_dealer_contact_No.Text = "";
        txt_dealer_landline_no.Text = "";
    }

    protected void Btn_Update_Dealer_Click(object sender, EventArgs e)
    {

    }
}