<%@ Page Title="" Language="C#" MasterPageFile="~/smsMP.master" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="Product_AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../CSS/css_prod.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <table class="tbprod mx-auto mt-5">
            <tr>
                <th colspan="3" class="tbprod_th">Add Product </th>
            </tr>
            <tr>
                <td class="tbprod_td1">Product ID </td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_product_id" runat="server" CssClass="text_prod"></asp:TextBox>&nbsp;&nbsp;&nbsp;( example : Product ID should be : Prod123456 )</td>
            </tr>
            <tr>
                <td class="tbprod_td1">Name </td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_product_name" runat="server" CssClass="text_prod"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tbprod_td1">Company Name</td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_prod_company_name" runat="server" CssClass="text_prod"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tbprod_td1">Manu. Date</td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_prod_manufacture_date" runat="server" CssClass="text_prod" placeholder=" Date "></asp:TextBox>&nbsp;&nbsp;&nbsp;( Manufacture Date )</td>
            </tr>
            <tr>
                <td class="tbprod_td1">Manu. Expire Date</td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_prod_manufacture_exp_date" runat="server" CssClass="text_prod" placeholder=" Date "></asp:TextBox>&nbsp;&nbsp;&nbsp;( Manufacture Expire Date )</td>
            </tr>
            <tr>
                <td class="tbprod_td1">Serial Number</td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_product_serial_number" runat="server" CssClass="text_prod"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tbprod_td1">Batch Number</td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_product_batch_number" runat="server" CssClass="text_prod"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tbprod_td1">MRP Price</td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_product_cost" runat="server" CssClass="text_prod"></asp:TextBox>&nbsp;&nbsp;&nbsp;( Cost of Product )</td>
            </tr>
            <tr>
                <td class="tbprod_td1">Quantity</td>
                <td class="tbprod_td2">
                    <asp:TextBox ID="txt_product_quantity" runat="server" CssClass="text_prod"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tbprod_td1">Product Category</td>
                <td class="tbprod_td2">
                    <asp:DropDownList ID="ddl_product_category" runat="server"
                        CssClass="text_prod" Width="275px" AutoPostBack="True"
                        OnSelectedIndexChanged="ddl_product_category_SelectedIndexChanged">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td class="tbprod_td1">Product Dealer </td>
                <td class="tbprod_td2">
                    <asp:DropDownList ID="ddl_product_dealer" runat="server"
                        CssClass="text_prod" Width="275px" Enabled="False">
                    </asp:DropDownList></td>
            </tr>
        </table>
        <div style="margin: 10px 50px 10px 330px;">
            <asp:Button ID="Btn_Submit" runat="server" Text=" Submit " CssClass="btn_submit"
                OnClick="Btn_Submit_Click" />&nbsp;&nbsp;&nbsp;
  <asp:Button ID="Btn_Cancel" runat="server" Text=" Cancel " CssClass="btn_submit" />
        </div>
    </div>
</asp:Content>

