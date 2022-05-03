using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entities;
using SMS_BAL;

public partial class Category_category : System.Web.UI.Page
{
    Common_Functions _com_fun_cat = new Common_Functions();
    BAL bussinessLogic = new BAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridViewCategory();
            Fill_DDL_Dealer();
        }
    }
    protected void Btn_Add_Category_Click(object sender, EventArgs e)
    {
        _com_fun_cat.catid = txt_category_ID.Text.Trim();
        _com_fun_cat.catname = txt_category_name.Text.Trim();
        _com_fun_cat.cat_did = ddl_cat_dealer.SelectedValue.ToString();
        bussinessLogic.Insert_Category(_com_fun_cat);
        FillGridViewCategory();
    }
    public void FillGridViewCategory()
    {
        try
        {
            DataSet ds_cat = new DataSet();
            ds_cat = bussinessLogic.Get_Category();
            if (ds_cat.Tables[0].Rows.Count > 0)
            {
                grd_category.DataSource = ds_cat;
                grd_category.DataBind();
            }
        }
        catch
        {
            //throw;
        }
    }

    public void Fill_DDL_Dealer()
    {
        DataSet ds_did_dname = new DataSet();
        ds_did_dname = bussinessLogic.Get_Did_Dname();
        if (ds_did_dname.Tables[0].Rows.Count > 0)
        {
            ddl_cat_dealer.DataSource = ds_did_dname;
            ddl_cat_dealer.DataTextField = "dealername";
            ddl_cat_dealer.DataValueField = "dealerid";
            ddl_cat_dealer.DataBind();
            ddl_cat_dealer.Items.Insert(0, new ListItem(" Select ", "0"));
            ddl_cat_dealer.SelectedIndex = 0;
        }
    }
}