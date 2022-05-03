using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
//using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SMS_DAL
{
    public class DAL
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P4A4V8S;Initial Catalog=sms;Integrated Security=True");
        private SqlDataAdapter da;
        private string sql_query;
        private string case_name;

        public DataSet Get_All_Dealer()
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Get_All_Dealer);
                this.sql_query = Query_Builder.Query_Builder._GetAll(this.case_name);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_DID_DName()
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Get_DID_DName);
                this.sql_query = Query_Builder.Query_Builder._GetAll(this.case_name);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_All_Category()
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Get_All_Category);
                this.sql_query = Query_Builder.Query_Builder._GetAll(this.case_name);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_CID_CName()
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = "Get_CatID_CatName";
                this.sql_query = Query_Builder.Query_Builder._GetAll(this.case_name);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_Product_ALL()
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = "Get_ALL_Product";
                this.sql_query = Query_Builder.Query_Builder._GetAll(this.case_name);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_Payment_Mode()
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Get_Payment_Mode);
                this.sql_query = Query_Builder.Query_Builder._GetAll(this.case_name);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_Dealer_ID(Common_Functions _com_fun_get_dealer_with_ID)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = "Get_one_Dealer";
                this.sql_query = Query_Builder.Query_Builder._Get_Method(this.case_name, _com_fun_get_dealer_with_ID);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_Product_Dealer(Common_Functions _com_fun_prod_dealer)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Get_Product_Dealer);
                this.sql_query = Query_Builder.Query_Builder._Get_Method(this.case_name, _com_fun_prod_dealer);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_Product_ID(Common_Functions _com_fun_prodID)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = "Get_one_Product";
                this.sql_query = Query_Builder.Query_Builder._Get_Method(this.case_name, _com_fun_prodID);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_CName_DName_Product_Edit(Common_Functions _com_fun_cn_dn_prod_edit)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Get_CName_DName_Product_Edit);
                this.sql_query = Query_Builder.Query_Builder._Get_Method(this.case_name, _com_fun_cn_dn_prod_edit);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Get_CID_CName_Through_ProdID(Common_Functions _com_fun_cid_cname_prodID)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = "Get_Category_through_ProductID_Cust";
                this.sql_query = Query_Builder.Query_Builder._Get_Method(this.case_name, _com_fun_cid_cname_prodID);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public void Insert_Dealer(Common_Functions _com_fun_insert_dealer)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Insert_Dealer);
                this.sql_query = Query_Builder.Query_Builder._Insert_Method(this.case_name, _com_fun_insert_dealer);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
            }
            catch
            {
                throw;
            }
        }

        public void Insert_Category(Common_Functions _com_fun_insert_cat)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Insert_Category);
                this.sql_query = Query_Builder.Query_Builder._Insert_Method(this.case_name, _com_fun_insert_cat);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
            }
            catch
            {
                throw;
            }
        }

        public void Insert_Product(Common_Functions _com_fun_insert_prod)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Insert_Product);
                this.sql_query = Query_Builder.Query_Builder._Insert_Method(this.case_name, _com_fun_insert_prod);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
            }
            catch
            {
                throw;
            }
        }

        public DataSet Update_Product_ID(Common_Functions _com_fun_Update_prod)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = "Update_Product";
                this.sql_query = Query_Builder.Query_Builder._Update_Method(this.case_name, _com_fun_Update_prod);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Delete_Product_ID(Common_Functions _com_fun_del_prod)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Delete_Product_ID);
                this.sql_query = Query_Builder.Query_Builder._Delete_Method(this.case_name, _com_fun_del_prod);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }

        public DataSet Delete_Dealer_ID(Common_Functions _com_fun_del_dealer)
        {
            try
            {
                DataSet dataSet = new DataSet();
                this.case_name = nameof(Delete_Dealer_ID);
                this.sql_query = Query_Builder.Query_Builder._Delete_Method_Dealer(this.case_name, _com_fun_del_dealer);
                this.con.Open();
                this.da = new SqlDataAdapter(this.sql_query, this.con);
                this.da.Fill(dataSet);
                this.con.Close();
                return dataSet;
            }
            catch
            {
                throw;
            }
        }
    }
}
