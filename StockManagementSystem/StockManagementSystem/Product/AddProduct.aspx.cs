using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entities;
using SMS_BAL;

public partial class Product_AddProduct : System.Web.UI.Page
{
    Common_Functions _com_fun_product = new Common_Functions();
    BAL businessLogic = new BAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Fill_Category();
        }
    }
    public void Fill_Category()
    {
        DataSet ds_cid_cname = new DataSet();
        ds_cid_cname = businessLogic.Get_CID_CNAME();
        if (ds_cid_cname.Tables[0].Rows.Count > 0)
        {
            ddl_product_category.DataSource = ds_cid_cname;
            ddl_product_category.DataTextField = "categoryname";
            ddl_product_category.DataValueField = "categoryid";
            ddl_product_category.DataBind();
            ddl_product_category.Items.Insert(0, new ListItem(" Select Category ", "0"));
            ddl_product_category.SelectedIndex = 0;
        }
    }
    protected void ddl_product_category_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet ds_get_dealer = new DataSet();
        _com_fun_product.catid = ddl_product_category.SelectedValue.ToString();
        ds_get_dealer = businessLogic.Get_Product_Dealer(_com_fun_product);
        if (ds_get_dealer.Tables[0].Rows.Count > 0)
        {
            ddl_product_dealer.DataSource = ds_get_dealer;
            ddl_product_dealer.DataTextField = "dealername";
            ddl_product_dealer.DataValueField = "dealerid";
            ddl_product_dealer.DataBind();
            ddl_product_dealer.Items.Insert(0, new ListItem(" Select Dealer ", "0"));
            ddl_product_dealer.SelectedIndex = 0;
            ddl_product_dealer.Enabled = true;
            return;
        }
    }
    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        _com_fun_product.prodid = txt_product_id.Text.Trim();
        _com_fun_product.prodname = txt_product_name.Text.Trim();
        _com_fun_product.prod_company_name = txt_prod_company_name.Text.Trim();
        _com_fun_product.prod_manu_date = txt_prod_manufacture_date.Text.Trim();
        _com_fun_product.prod_manu_exp_date = txt_prod_manufacture_exp_date.Text.Trim();
        _com_fun_product.prod_serial_no = txt_product_serial_number.Text.Trim();
        _com_fun_product.prod_batch_no = txt_product_batch_number.Text.Trim();
        _com_fun_product.prod_price = txt_product_cost.Text.Trim();
        _com_fun_product.prod_qty = txt_product_quantity.Text.Trim();
        _com_fun_product.prod_catid = ddl_product_category.SelectedValue.ToString();
        _com_fun_product.prod_did = ddl_product_dealer.SelectedValue.ToString();
        businessLogic.Insert_Product(_com_fun_product);
        Response.Redirect("~/Product/EditProduct.aspx?ProdID=" + txt_product_id.Text.Trim());
    }
}