using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Query_Builder
{
    public class Query_Builder
    {
        public static string _GetAll(string case_value)
        {
            string all = string.Empty;
            switch (case_value)
            {
                case "Get_All_Dealer":
                    all = "Select * from Dealers";
                    break;
                case "Get_DID_DName":
                    all = "select dealerid, dealername from Dealers";
                    break;
                case "Get_All_Category":
                    all = "select c.categoryid, c.categoryname, d.dealername  from Category c inner join Dealers d on c.category_did = d.dealerid";
                    break;
                case "Get_CatID_CatName":
                    all = "Select * from Category";
                    break;
                case "Get_ALL_Product":
                    all = "Select * from Product";
                    break;
                case "Get_Payment_Mode":
                    all = "Select * from PaymentMode";
                    break;
            }
            return all;
        }

        public static string _Get_Method(string case_value, Common_Functions _get_com_fun)
        {
            string method = string.Empty;
            switch (case_value)
            {
                case "Get_one_Dealer":
                    method = "Select * from Dealers where dealerid='" + _get_com_fun.did + "'";
                    break;
                case "Get_Product_Dealer":
                    method = "select d.dealerid, d.dealername from Category c inner join Dealers d on c.category_did=d.dealerid where c.categoryid ='" + _get_com_fun.catid + "'";
                    break;
                case "Get_CName_DName_Product_Edit":
                    method = "select c.categoryid, c.categoryname, d.dealerid, d.dealername from Category c inner join Dealers d on c.category_did=d.dealerid where c.categoryid ='" + _get_com_fun.catid + "'";
                    break;
                case "Get_one_Product":
                    method = "Select * from Product where prod_id='" + _get_com_fun.prodid + "'";
                    break;
                case "Get_Dealer_CatID":
                    method = "select dealername from Dealers where dealerid='" + _get_com_fun.cat_did + "'";
                    break;
                case "Get_Category_through_ProductID_Cust":
                    method = "select c.categoryid, c.categoryname from Product p inner join Category c on c.categoryid=p.prod_item_categoryid where p.prod_id='" + _get_com_fun.prodid + "'";
                    break;
            }
            return method;
        }

        public static string _Insert_Method(string case_value, Common_Functions _com_function)
        {
            string str = string.Empty;
            switch (case_value)
            {
                case "Insert_Dealer":
                    str = "Insert into Dealers(dealerid, dealername, dealerhouseno, dealerstreetname, dealerarea, dealerlandmark, dealercity, dealerstate, dealerpincode, dealercontactno, dealerlandlineno, dealership_since) values('" + _com_function.did + "','" + _com_function.dname + "','" + _com_function.dhouseno + "','" + _com_function.dstreetname + "','" + _com_function.darea + "','" + _com_function.dlandmark + "','" + _com_function.dcity + "','" + _com_function.dstate + "','" + _com_function.dpincode + "','" + _com_function.dcontactno + "','" + _com_function.dlandlineno + "','" + _com_function.dship_since + "')";
                    break;
                case "Insert_Category":
                    str = "Insert into Category(categoryid, categoryname, category_did) values('" + _com_function.catid + "','" + _com_function.catname + "','" + _com_function.cat_did + "')";
                    break;
                case "Insert_Product":
                    str = "Insert into Product(prod_id, prod_name, prod_comp_name, prod_manu_date, prod_manu_exp_date, prod_item_serial_no, prod_item_batch_no, prod_item_cost, prod_item_quantity, prod_item_categoryid, prod_item_dealerid) values('" + _com_function.prodid + "','" + _com_function.prodname + "','" + _com_function.prod_company_name + "','" + _com_function.prod_manu_date + "','" + _com_function.prod_manu_exp_date + "','" + _com_function.prod_serial_no + "','" + _com_function.prod_batch_no + "','" + _com_function.prod_price + "','" + _com_function.prod_qty + "','" + _com_function.prod_catid + "','" + _com_function.prod_did + "')";
                    break;
            }
            return str;
        }

        public static string _Update_Method(string case_value, Common_Functions _com_function_update)
        {
            string str = string.Empty;
            switch (case_value)
            {
                case "Update_Product":
                    str = "Update Product set prod_name='" + _com_function_update.prodname + "', prod_comp_name='" + _com_function_update.prod_company_name + "',prod_manu_date='" + _com_function_update.prod_manu_date + "',prod_manu_exp_date='" + _com_function_update.prod_manu_exp_date + "',prod_item_serial_no='" + _com_function_update.prod_serial_no + "',prod_item_batch_no='" + _com_function_update.prod_batch_no + "',prod_item_cost='" + _com_function_update.prod_price + "',prod_item_quantity='" + _com_function_update.prod_qty + "',prod_item_categoryid='" + _com_function_update.prod_catid + "',prod_item_dealerid='" + _com_function_update.prod_did + "' where prod_id='" + _com_function_update.prodid + "'";
                    break;
            }
            return str;
        }

        public static string _Delete_Method(string case_value, Common_Functions _com_function_del)
        {
            string str = string.Empty;
            switch (case_value)
            {
                case "Delete_Product_ID":
                    str = "Delete Product where prod_id='" + _com_function_del.prodid + "'";
                    break;
            }
            return str;
        }
        public static string _Delete_Method_Dealer(string case_value, Common_Functions _com_function_del)
        {
            string str = string.Empty;
            switch (case_value)
            {
                case "Delete_Dealer_ID":
                    str = "Delete Dealers where dealerid='" + _com_function_del.did + "'";
                    break;
            }
            return str;
        }
    }
}
