using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entities;
using SMS_BAL;

public partial class Product_EditProduct : System.Web.UI.Page
{
    Common_Functions _com_fun_prod_edit = new Common_Functions();
    BAL businessLogic = new BAL();
    string cname, dname;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["ProdID"] != null)
            {
                ReadOnly();
                Get_prod_ID();
                BackgroundColor_ReadOnly();
                Btn_Update.Visible = false;
                Btn_Get_Product.Visible = false;
            }
            else
            {
                Btn_add_product.Visible = false;
                Btn_Cancel.Visible = false;
                Btn_Edit.Visible = false;
                Btn_Update.Visible = false;
                Btn_Get_Product.Visible = true;

                txt_product_id.ReadOnly = false;
                txt_product_name.ReadOnly = true;
                txt_prod_company_name.ReadOnly = true;
                txt_prod_manufacture_date.ReadOnly = true;
                txt_prod_manufacture_exp_date.ReadOnly = true;
                txt_product_serial_number.ReadOnly = true;
                txt_product_batch_number.ReadOnly = true;
                txt_product_cost.ReadOnly = true;
                txt_product_quantity.ReadOnly = true;
                ddl_prod_category_edit.Enabled = false;
                ddl_prod_dealer_edit.Enabled = false;


                txt_product_name.Style.Add("background", "#dddddd");
                txt_prod_company_name.Style.Add("background", "#dddddd");
                txt_prod_manufacture_date.Style.Add("background", "#dddddd");
                txt_prod_manufacture_exp_date.Style.Add("background", "#dddddd");
                txt_product_serial_number.Style.Add("background", "#dddddd");
                txt_product_batch_number.Style.Add("background", "#dddddd");
                txt_product_cost.Style.Add("background", "#dddddd");
                txt_product_quantity.Style.Add("background", "#dddddd");
                ddl_prod_category_edit.Style.Add("background", "#dddddd");
                ddl_prod_dealer_edit.Style.Add("background", "#dddddd");

            }
        }
    }
    public void ReadOnly()
    {
        txt_product_id.ReadOnly = true;
        txt_product_name.ReadOnly = true;
        txt_prod_company_name.ReadOnly = true;
        txt_prod_manufacture_date.ReadOnly = true;
        txt_prod_manufacture_exp_date.ReadOnly = true;
        txt_product_serial_number.ReadOnly = true;
        txt_product_batch_number.ReadOnly = true;
        txt_product_cost.ReadOnly = true;
        txt_product_quantity.ReadOnly = true;
        ddl_prod_category_edit.Enabled = false;
        ddl_prod_dealer_edit.Enabled = false;


    }
    public void ReadOnlyfalse()
    {
        // Allow to Enter some Text
        txt_product_id.ReadOnly = true;
        txt_product_name.ReadOnly = false;
        txt_prod_company_name.ReadOnly = false;
        txt_prod_manufacture_date.ReadOnly = false;
        txt_prod_manufacture_exp_date.ReadOnly = false;
        txt_product_serial_number.ReadOnly = false;
        txt_product_batch_number.ReadOnly = false;
        txt_product_cost.ReadOnly = false;
        txt_product_quantity.ReadOnly = false;
        ddl_prod_category_edit.Enabled = true;
        ddl_prod_dealer_edit.Enabled = true;


    }
    protected void Btn_add_product_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Product/AddProduct.aspx");
    }
    protected void Btn_Edit_Click(object sender, EventArgs e)
    {
        Get_prod_ID();
        BackgroundColor_White();
        ReadOnlyfalse();
        //DDL_Category();
        //DDL_Dealer();
        Btn_add_product.Visible = false;
        Btn_Edit.Visible = false;
        Btn_Get_Product.Visible = false;
        Btn_Update.Visible = true;
    }
    public void Get_prod_ID()
    {
        DataSet ds_prod_edit = new DataSet();

        if (Request.QueryString["ProdID"] != null)
        {
            string pid = Request.QueryString["ProdID"].ToString();
            _com_fun_prod_edit.prodid = pid.ToString();
            ds_prod_edit = businessLogic.Get_Product_ID(_com_fun_prod_edit);
            if (ds_prod_edit.Tables[0].Rows.Count > 0)
            {
                txt_product_id.Text = ds_prod_edit.Tables[0].Rows[0]["prod_id"].ToString();
                txt_product_name.Text = ds_prod_edit.Tables[0].Rows[0]["prod_name"].ToString();
                txt_prod_company_name.Text = ds_prod_edit.Tables[0].Rows[0]["prod_comp_name"].ToString();
                txt_prod_manufacture_date.Text = ds_prod_edit.Tables[0].Rows[0]["prod_manu_date"].ToString();
                txt_prod_manufacture_exp_date.Text = ds_prod_edit.Tables[0].Rows[0]["prod_manu_exp_date"].ToString();
                txt_product_serial_number.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_serial_no"].ToString();
                txt_product_batch_number.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_batch_no"].ToString();
                txt_product_cost.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_cost"].ToString();
                txt_product_quantity.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_quantity"].ToString();
                string cid = ds_prod_edit.Tables[0].Rows[0]["prod_item_categoryid"].ToString();
                _com_fun_prod_edit.catid = cid.ToString();
                DataSet ds_cid = new DataSet();
                ds_cid = businessLogic.Get_CName_DName_Prod_Edit(_com_fun_prod_edit);
                if (ds_cid.Tables[0].Rows.Count > 0)
                {
                    cname = ds_cid.Tables[0].Rows[0]["categoryname"].ToString();
                    dname = ds_cid.Tables[0].Rows[0]["dealername"].ToString();

                    Fill_Category(cname);

                    ddl_prod_dealer_edit.Items.Insert(0, new ListItem(dname));
                    ddl_prod_dealer_edit.SelectedIndex = 0;
                }


            }
        }
        else
        {
            string pid = txt_product_id.Text.Trim();
            _com_fun_prod_edit.prodid = pid.ToString();
            ds_prod_edit = businessLogic.Get_Product_ID(_com_fun_prod_edit);
            if (ds_prod_edit.Tables[0].Rows.Count > 0)
            {
                txt_product_id.Text = ds_prod_edit.Tables[0].Rows[0]["prod_id"].ToString();
                txt_product_name.Text = ds_prod_edit.Tables[0].Rows[0]["prod_name"].ToString();
                txt_prod_company_name.Text = ds_prod_edit.Tables[0].Rows[0]["prod_comp_name"].ToString();
                txt_prod_manufacture_date.Text = ds_prod_edit.Tables[0].Rows[0]["prod_manu_date"].ToString();
                txt_prod_manufacture_exp_date.Text = ds_prod_edit.Tables[0].Rows[0]["prod_manu_exp_date"].ToString();
                txt_product_serial_number.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_serial_no"].ToString();
                txt_product_batch_number.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_batch_no"].ToString();
                txt_product_cost.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_cost"].ToString();
                txt_product_quantity.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_quantity"].ToString();
                string cid = ds_prod_edit.Tables[0].Rows[0]["prod_item_categoryid"].ToString();
                _com_fun_prod_edit.catid = cid.ToString();
                DataSet ds_cid = new DataSet();
                ds_cid = businessLogic.Get_CName_DName_Prod_Edit(_com_fun_prod_edit);
                if (ds_cid.Tables[0].Rows.Count > 0)
                {
                    cname = ds_cid.Tables[0].Rows[0]["categoryname"].ToString();
                    dname = ds_cid.Tables[0].Rows[0]["dealername"].ToString();

                    Fill_Category(cname);

                    ddl_prod_dealer_edit.Items.Insert(0, new ListItem(dname));
                    ddl_prod_dealer_edit.SelectedIndex = 0;
                }


            }
        }
    }
    public void BackgroundColor_ReadOnly()
    {
        txt_product_id.Style.Add("background", "#dddddd");
        txt_product_name.Style.Add("background", "#dddddd");
        txt_prod_company_name.Style.Add("background", "#dddddd");
        txt_prod_manufacture_date.Style.Add("background", "#dddddd");
        txt_prod_manufacture_exp_date.Style.Add("background", "#dddddd");
        txt_product_serial_number.Style.Add("background", "#dddddd");
        txt_product_batch_number.Style.Add("background", "#dddddd");
        txt_product_cost.Style.Add("background", "#dddddd");
        txt_product_quantity.Style.Add("background", "#dddddd");
        ddl_prod_category_edit.Style.Add("background", "#dddddd");
        ddl_prod_dealer_edit.Style.Add("background", "#dddddd");
    }
    public void BackgroundColor_White()
    {
        txt_product_id.Style.Add("background", "#dddddd");
        txt_product_name.Style.Add("background", "#ffffff");
        txt_prod_company_name.Style.Add("background", "#ffffff");
        txt_prod_manufacture_date.Style.Add("background", "#ffffff");
        txt_prod_manufacture_exp_date.Style.Add("background", "#ffffff");
        txt_product_serial_number.Style.Add("background", "#ffffff");
        txt_product_batch_number.Style.Add("background", "#ffffff");
        txt_product_cost.Style.Add("background", "#ffffff");
        txt_product_quantity.Style.Add("background", "#ffffff");
        ddl_prod_category_edit.Style.Add("background", "#ffffff");
        ddl_prod_dealer_edit.Style.Add("background", "#ffffff");
    }

    protected void Btn_Get_Product_Click(object sender, EventArgs e)
    {
        DataSet ds_prod_edit = new DataSet();


        string pid = txt_product_id.Text.Trim();
        _com_fun_prod_edit.prodid = pid.ToString();
        ds_prod_edit = businessLogic.Get_Product_ID(_com_fun_prod_edit);
        if (ds_prod_edit.Tables[0].Rows.Count > 0)
        {
            txt_product_id.Text = ds_prod_edit.Tables[0].Rows[0]["prod_id"].ToString();
            txt_product_name.Text = ds_prod_edit.Tables[0].Rows[0]["prod_name"].ToString();
            txt_prod_company_name.Text = ds_prod_edit.Tables[0].Rows[0]["prod_comp_name"].ToString();
            txt_prod_manufacture_date.Text = ds_prod_edit.Tables[0].Rows[0]["prod_manu_date"].ToString();
            txt_prod_manufacture_exp_date.Text = ds_prod_edit.Tables[0].Rows[0]["prod_manu_exp_date"].ToString();
            txt_product_serial_number.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_serial_no"].ToString();
            txt_product_batch_number.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_batch_no"].ToString();
            txt_product_cost.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_cost"].ToString();
            txt_product_quantity.Text = ds_prod_edit.Tables[0].Rows[0]["prod_item_quantity"].ToString();
            string cid = ds_prod_edit.Tables[0].Rows[0]["prod_item_categoryid"].ToString();
            _com_fun_prod_edit.catid = cid.ToString();
            DataSet ds_cid = new DataSet();
            ds_cid = businessLogic.Get_CName_DName_Prod_Edit(_com_fun_prod_edit);
            if (ds_cid.Tables[0].Rows.Count > 0)
            {
                cname = ds_cid.Tables[0].Rows[0]["categoryname"].ToString();
                dname = ds_cid.Tables[0].Rows[0]["dealername"].ToString();

                Fill_Category(cname);

                ddl_prod_dealer_edit.Items.Insert(0, new ListItem(dname));
                ddl_prod_dealer_edit.SelectedIndex = 0;


            }
            ReadOnly();
            BackgroundColor_ReadOnly();
            Btn_Update.Visible = false;
            Btn_Get_Product.Visible = false;
            Btn_add_product.Visible = true;
            Btn_Edit.Visible = true;
            Btn_Cancel.Visible = true;
        }

    }
    protected void Btn_Update_Click(object sender, EventArgs e)
    {
        _com_fun_prod_edit.prodid = txt_product_id.Text.Trim();
        _com_fun_prod_edit.prodname = txt_product_name.Text.Trim();
        _com_fun_prod_edit.prod_company_name = txt_prod_company_name.Text.Trim();
        _com_fun_prod_edit.prod_manu_date = txt_prod_manufacture_date.Text.Trim();
        _com_fun_prod_edit.prod_manu_exp_date = txt_prod_manufacture_exp_date.Text.Trim();
        _com_fun_prod_edit.prod_serial_no = txt_product_serial_number.Text.Trim();
        _com_fun_prod_edit.prod_batch_no = txt_product_batch_number.Text.Trim();
        _com_fun_prod_edit.prod_price = txt_product_cost.Text.Trim();
        _com_fun_prod_edit.prod_qty = txt_product_quantity.Text.Trim();
        _com_fun_prod_edit.prod_catid = ddl_prod_category_edit.SelectedValue.ToString();
        _com_fun_prod_edit.prod_did = ddl_prod_dealer_edit.SelectedValue.ToString();
        businessLogic.update_prod_ID(_com_fun_prod_edit);
        Btn_add_product.Visible = true;
        Btn_Edit.Visible = true;
        Btn_Cancel.Visible = true;
        Btn_Get_Product.Visible = false;
        Btn_Update.Visible = false;
        ReadOnly();
        BackgroundColor_ReadOnly();
    }

    public void Fill_Category(string catergoryname)
    {
        DataSet ds_cid_cname = new DataSet();
        ds_cid_cname = businessLogic.Get_CID_CNAME();
        if (ds_cid_cname.Tables[0].Rows.Count > 0)
        {
            ddl_prod_category_edit.DataSource = ds_cid_cname;
            ddl_prod_category_edit.DataTextField = "categoryname";
            ddl_prod_category_edit.DataValueField = "categoryid";
            ddl_prod_category_edit.DataBind();
            ddl_prod_category_edit.Items.Insert(0, new ListItem(catergoryname));
            ddl_prod_category_edit.SelectedIndex = 0;

        }
    }

    protected void ddl_prod_category_edit_SelectedIndexChanged1(object sender, EventArgs e)
    {
        DataSet ds_get_dealer = new DataSet();
        _com_fun_prod_edit.catid = ddl_prod_category_edit.SelectedValue.ToString();
        ds_get_dealer = businessLogic.Get_Product_Dealer(_com_fun_prod_edit);
        if (ds_get_dealer.Tables[0].Rows.Count > 0)
        {
            ddl_prod_dealer_edit.DataSource = ds_get_dealer;
            ddl_prod_dealer_edit.DataTextField = "dealername";
            ddl_prod_dealer_edit.DataValueField = "dealerid";
            ddl_prod_dealer_edit.DataBind();
            ddl_prod_dealer_edit.Items.Insert(0, new ListItem(" Select Dealer ", "0"));
            ddl_prod_dealer_edit.SelectedIndex = 0;
            ddl_prod_dealer_edit.Enabled = true;
            return;
        }
    }
}