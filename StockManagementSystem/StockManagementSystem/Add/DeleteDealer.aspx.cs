using Entities;
using SMS_BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Add_DeleteDealer : System.Web.UI.Page
{
    BAL businessLogic = new BAL();
    Common_Functions _com_fun_delete_dealer = new Common_Functions();
    protected void Page_Load(object sender, EventArgs e)
    {

        //SqlCommand cmdDel = new SqlCommand("Delete From dbo.Dealers where dealerid = @p1", Connection.cnntn);
        //if (cmdDel.Connection.State != ConnectionState.Open)
        //{
        //    cmdDel.Connection.Open();
        //}
        //cmdDel.Parameters.AddWithValue("@p1", parameterDel);
        //return cmdDel.ExecuteNonQuery() > 0;
    }

    protected void Btn_get_Dealer_details_Click(object sender, EventArgs e)
    {
        DetailsViewDataBind0();
    }
    private void DetailsViewDataBind0()
    {
        DataSet ds_del_dealer = new DataSet();

        _com_fun_delete_dealer.did = txt_dealer_id.Text.Trim();
        ds_del_dealer = businessLogic.Get_Dealer_ID(_com_fun_delete_dealer);
        if (ds_del_dealer.Tables[0].Rows.Count > 0)
        {
            DetailsView1.DataSource = ds_del_dealer;
            DetailsView1.DataBind();
            lbl_delete_message.Text = "";
        }
        else
        {
            DetailsView1.DataSource = ds_del_dealer;
            DetailsView1.DataBind();
            lbl_delete_message.Text = "<span style='background:#800080; color:#ffffff; padding:7px 10px 7px 10px; '> No Records found with these Product ID : <b><u>" + txt_dealer_id.Text + "</u></b> </span>";

        }
    }
    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {
        string dealerID = DetailsView1.DataKey.Value.ToString();
        string DealerName = e.Values["dealername"].ToString();
        _com_fun_delete_dealer.did = dealerID;
        businessLogic.delete_dealer_ID(_com_fun_delete_dealer);
        DetailsViewDataBind0();
        lbl_delete_message.Text = "<span style='background:#800080; color:#ffffff; padding:7px 10px 7px 10px; '> Dealer ID : <u><b>" + dealerID + "</b></u> & Dealer Name : <u><b>" + DealerName + "</b></u>  Deleted Successfully...</span>";
    }
}