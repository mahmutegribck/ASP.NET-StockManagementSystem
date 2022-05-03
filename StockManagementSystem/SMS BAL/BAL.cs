using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using SMS_DAL;
using System.Data;

namespace SMS_BAL
{
    public class BAL
    {

        private DAL dblogic = new DAL();

        public DataSet Get_Dealers() => this.dblogic.Get_All_Dealer();

        public DataSet Get_Did_Dname() => this.dblogic.Get_DID_DName();

        public DataSet Get_Category() => this.dblogic.Get_All_Category();

        public DataSet Get_CID_CNAME() => this.dblogic.Get_CID_CName();

        public DataSet Get_ALLProduct() => this.dblogic.Get_Product_ALL();

        public DataSet Get_Mode_Of_Payment() => this.dblogic.Get_Payment_Mode();

        public DataSet Get_Dealer_with_ID(Common_Functions _com_fun_dealer_id) => this.dblogic.Get_Dealer_ID(_com_fun_dealer_id);

        public DataSet Get_Product_Dealer(Common_Functions _com_fun_prod_dealer) => this.dblogic.Get_Product_Dealer(_com_fun_prod_dealer);

        public DataSet Get_Product_ID(Common_Functions _com_fun_prod_ID) => this.dblogic.Get_Product_ID(_com_fun_prod_ID);
        public DataSet Get_Dealer_ID(Common_Functions _com_fun_delete_dealer) => this.dblogic.Get_Dealer_ID(_com_fun_delete_dealer);

        public DataSet Get_CName_DName_Prod_Edit(Common_Functions _com_fun_cn_dn_prod_edit) => this.dblogic.Get_CName_DName_Product_Edit(_com_fun_cn_dn_prod_edit);

        public DataSet Get_CID_CName_Through_ProdID(Common_Functions _com_fun_cid_cnam_pID) => this.dblogic.Get_CID_CName_Through_ProdID(_com_fun_cid_cnam_pID);

        public void Insert_Dealer(Common_Functions _com_fun_insert_dealer)
        {
            try
            {
                this.dblogic.Insert_Dealer(_com_fun_insert_dealer);
            }
            catch
            {
                throw;
            }
        }

        public void Insert_Category(Common_Functions _con_fun_insert_cat)
        {
            try
            {
                this.dblogic.Insert_Category(_con_fun_insert_cat);
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
                this.dblogic.Insert_Product(_com_fun_insert_prod);
            }
            catch
            {
                throw;
            }
        }

        public void update_prod_ID(Common_Functions _com_fun_update)
        {
            try
            {
                this.dblogic.Update_Product_ID(_com_fun_update);
            }
            catch
            {
                throw;
            }
        }

        public void delete_prod_ID(Common_Functions _com_fun_del_prod)
        {
            try
            {
                this.dblogic.Delete_Product_ID(_com_fun_del_prod);
            }
            catch
            {
                throw;
            }
        }
        public void delete_dealer_ID(Common_Functions _com_fun_delete_dealer)
        {
            try
            {
                this.dblogic.Delete_Dealer_ID(_com_fun_delete_dealer);
            }
            catch
            {
                throw;
            }
        }

    }
}
