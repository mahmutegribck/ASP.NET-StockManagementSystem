using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMS_DAL;
using Entities;
using System.Data;

public partial class Customer_Customer : System.Web.UI.Page
{
    SMS_BAL.BAL businessLogic_product = new SMS_BAL.BAL();
    Common_Functions _com_fn_product = new Common_Functions();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CID"] != null)
            {
                G_D_CID();
                Get_Product();
                Get_Cash_Payment_Mode();
            }
            else
            {
                Get_Date_CustID();
            }
        }
    }

    private void G_D_CID()
    {
        txt_cust_ID.Text = Session["CID"].ToString();
        txt_cust_date.Text = DateTime.Today.Date.ToShortDateString();
    }
    private void Get_Date_CustID()
    {
        DateTime time = DateTime.Now;             // Use current time.
        string format = "MMddyyyyHHmmssfff";   // Use this format.
        //Label1.Text = (time.ToString(format));
        txt_cust_ID.Text = "Cust" + (time.ToString(format));
        Session["CID"] = txt_cust_ID.Text;
        txt_cust_date.Text = DateTime.Today.Date.ToShortDateString();
    }
    private void Get_Product()
    {
        DataSet ds_prod = new DataSet();
        ds_prod = businessLogic_product.Get_ALLProduct();
        if (ds_prod.Tables[0].Rows.Count > 0)
        {
            ddl_cust_prod_ID.DataSource = ds_prod;
            ddl_cust_prod_ID.DataValueField = "prod_id";
            ddl_cust_prod_ID.DataTextField = "prod_name";
            ddl_cust_prod_ID.DataBind();
            ddl_cust_prod_ID.Items.Insert(0, new ListItem(" Select ", "0"));
            ddl_cust_prod_ID.SelectedIndex = 0;
        }
    }
    private void Get_Category_through_ProdID()
    {
        DataSet ds_cid_cname_prodID = new DataSet();

        _com_fn_product.prodid = ddl_cust_prod_ID.SelectedValue.ToString();

        ds_cid_cname_prodID = businessLogic_product.Get_CID_CName_Through_ProdID(_com_fn_product);
        if (ds_cid_cname_prodID.Tables[0].Rows.Count > 0)
        {
            ddl_cust_category.DataSource = ds_cid_cname_prodID;
            ddl_cust_category.DataTextField = "categoryname";
            ddl_cust_category.DataValueField = "categoryid";
            ddl_cust_category.DataBind();
            ddl_cust_category.Items.Insert(0, new ListItem(" Select ", "0"));
            ddl_cust_category.SelectedIndex = 0;
        }
    }
    private void Get_Cash_Payment_Mode()
    {
        DataSet ds_payment_mode = new DataSet();
        ds_payment_mode = businessLogic_product.Get_Mode_Of_Payment();
        if (ds_payment_mode.Tables[0].Rows.Count > 0)
        {
            ddl_cust_cash_mode.DataSource = ds_payment_mode;
            ddl_cust_cash_mode.DataTextField = "payment_type";
            ddl_cust_cash_mode.DataValueField = "paymentID";
            ddl_cust_cash_mode.DataBind();
            ddl_cust_cash_mode.Items.Insert(0, new ListItem(" Select ", "0"));
            ddl_cust_cash_mode.SelectedIndex = 0;
        }
    }

    protected void ddl_cust_prod_ID_SelectedIndexChanged(object sender, EventArgs e)
    {
        Get_Category_through_ProdID();
    }
    protected void Btn_Custom_submit_Click(object sender, EventArgs e)
    {

    }
}