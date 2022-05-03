using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using System.Data;
using SMS_BAL;

public partial class Add_ListofDealer : System.Web.UI.Page
{
    Common_Functions _com_fun_gridview = new Common_Functions();
    BAL businessLogic = new BAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridview();
        }
    }
    public void FillGridview()
    {
        try
        {
            DataTable dt = new DataTable();
            DataColumn dc;
            DataRow dw;
            DataView dv;
            DataSet ds_grd = new DataSet();
            ds_grd = businessLogic.Get_Dealers();

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "Dealer ID";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "Name";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "H.No";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "Street Name";
            dt.Columns.Add(dc);
           

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "Area";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "City";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "State";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "Pincode";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "Mobile No";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "LandLine No";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.String");
            dc.ColumnName = "MemberShip";
            dt.Columns.Add(dc);

            if (ds_grd.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_grd.Tables[0].Rows.Count; i++)
                {
                    dw = dt.NewRow();
                    dw["Dealer ID"] = ds_grd.Tables[0].Rows[i]["dealerid"].ToString();
                    dw["Name"] = ds_grd.Tables[0].Rows[i]["dealername"].ToString();
                    dw["H.No"] = ds_grd.Tables[0].Rows[i]["dealerhouseno"].ToString();
                    dw["Street Name"] = ds_grd.Tables[0].Rows[i]["dealerstreetname"].ToString();
                    dw["Area"] = ds_grd.Tables[0].Rows[i]["dealerarea"].ToString();
                    
                    dw["City"] = ds_grd.Tables[0].Rows[i]["dealercity"].ToString();
                    dw["State"] = ds_grd.Tables[0].Rows[i]["dealerstate"].ToString();
                    dw["Pincode"] = ds_grd.Tables[0].Rows[i]["dealerpincode"].ToString();
                    dw["Mobile No"] = ds_grd.Tables[0].Rows[i]["dealercontactno"].ToString();
                    dw["LandLine No"] = ds_grd.Tables[0].Rows[i]["dealerlandlineno"].ToString();
                    dw["MemberShip"] = ds_grd.Tables[0].Rows[i]["dealership_since"].ToString();
                    dt.Rows.Add(dw);
                }
                dv = new DataView(dt);
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }
        }
        catch
        {
            throw;
        }
    }

    protected void Btn_Search_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_search.Text != "")
            {
                DataTable dt = new DataTable();
                DataColumn dc;
                DataRow dw;
                DataView dv;

                _com_fun_gridview.did = txt_search.Text.Trim();

                DataSet ds_grd = new DataSet();
                ds_grd = businessLogic.Get_Dealer_with_ID(_com_fun_gridview);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "Dealer ID";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "Name";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "H.No";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "Street Name";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "Area";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "LandMark";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "City";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "State";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "Pincode";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "Mobile No";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "LandLine No";
                dt.Columns.Add(dc);

                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "MemberShip";
                dt.Columns.Add(dc);

                if (ds_grd.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds_grd.Tables[0].Rows.Count; i++)
                    {
                        dw = dt.NewRow();
                        dw["Dealer ID"] = ds_grd.Tables[0].Rows[i]["dealerid"].ToString();
                        dw["Name"] = ds_grd.Tables[0].Rows[i]["dealername"].ToString();
                        dw["H.No"] = ds_grd.Tables[0].Rows[i]["dealerhouseno"].ToString();
                        dw["Street Name"] = ds_grd.Tables[0].Rows[i]["dealerstreetname"].ToString();
                        dw["Area"] = ds_grd.Tables[0].Rows[i]["dealerarea"].ToString();
                        dw["LandMark"] = ds_grd.Tables[0].Rows[i]["dealerlandmark"].ToString();
                        dw["City"] = ds_grd.Tables[0].Rows[i]["dealercity"].ToString();
                        dw["State"] = ds_grd.Tables[0].Rows[i]["dealerstate"].ToString();
                        dw["Pincode"] = ds_grd.Tables[0].Rows[i]["dealerpincode"].ToString();
                        dw["Mobile No"] = ds_grd.Tables[0].Rows[i]["dealercontactno"].ToString();
                        dw["LandLine No"] = ds_grd.Tables[0].Rows[i]["dealerlandlineno"].ToString();
                        dw["MemberShip"] = ds_grd.Tables[0].Rows[i]["dealership_since"].ToString();
                        dt.Rows.Add(dw);
                    }
                    dv = new DataView(dt);
                    GridView1.DataSource = dv;
                    GridView1.DataBind();
                }
            }
            else
            {
                FillGridview();
            }
        }
        catch
        {
            throw;
        }
    }

}