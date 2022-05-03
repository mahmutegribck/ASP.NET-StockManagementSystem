using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using Entities;
using SMS_BAL;

public partial class Product_DeleteProduct : System.Web.UI.Page
{
    BAL businessLogic = new BAL();
    Common_Functions _com_fun_delete_prod = new Common_Functions();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btn_get_Dealer_details_Click(object sender, EventArgs e)
    {
        DetailsViewDataBind();
    }

    private void DetailsViewDataBind()
    {
        DataSet ds_del_prod = new DataSet();

        _com_fun_delete_prod.prodid = txt_prod_id.Text.Trim();
        ds_del_prod = businessLogic.Get_Product_ID(_com_fun_delete_prod);
        if (ds_del_prod.Tables[0].Rows.Count > 0)
        {
            DetailsView1.DataSource = ds_del_prod;
            DetailsView1.DataBind();
            lbl_delete_message.Text = "";
        }
        else
        {
            DetailsView1.DataSource = ds_del_prod;
            DetailsView1.DataBind();
            lbl_delete_message.Text = "<span style='background:#800080; color:#ffffff; padding:7px 10px 7px 10px; '> No Records found with these Product ID : <b><u>" + txt_prod_id.Text + "</u></b> </span>";

        }
    }

    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {
        string productID = DetailsView1.DataKey.Value.ToString();
        string ProductName = e.Values["prod_name"].ToString();
        _com_fun_delete_prod.prodid = productID;
        businessLogic.delete_prod_ID(_com_fun_delete_prod);
        DetailsViewDataBind();
        lbl_delete_message.Text = "<span style='background:#800080; color:#ffffff; padding:7px 10px 7px 10px; '> Product ID : <u><b>" + productID + "</b></u> & Product Name : <u><b>" + ProductName + "</b></u>  Deleted Successfully...</span>";
    }
}