<%@ Page Title="" Language="C#" MasterPageFile="~/smsMP.master" AutoEventWireup="true" CodeFile="EditDealer.aspx.cs" Inherits="Add_EditDealer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../CSS/add.css" rel="stylesheet" type="text/css" />
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <div class="container">
        <table class="addtable mx-auto mt-5">
            <tr>
                <th colspan="3" class="addtableheader">Edit Dealer Details : </th>
            </tr>
            <tr>
                <td class="tdrow1">Dearler ID : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_id" runat="server" CssClass="textbox"></asp:TextBox>
                    <asp:Button ID="Btn_Get_Details" runat="server" Text="Get Details"
                        CssClass="Btn" OnClick="Btn_Get_Details_Click" /></td>
            </tr>
            <tr>
                <td class="tdrow1">Dearler Name : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_name" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <th colspan="3" style="background: #db6c19; text-align: left; padding: 5px 15px 5px 15px; color: #ffffff; font-size: 1.3em; border: 1px solid #db6c19;">Address : </th>
            </tr>
            <tr>
                <td class="tdrow1">House No : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_house_no" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdrow1">Street Name : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_street_name" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdrow1">Area : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_area" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdrow1">Landmark : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_landmark" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdrow1">City : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_city" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdrow1">State : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_state" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdrow1">Pincode : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_pincode" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdrow1">Contact | Mobile No : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_contact_No" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="tdrow1">LandLine No : </td>
                <td class="tdrow2">
                    <asp:TextBox ID="txt_dealer_landline_no" runat="server" CssClass="textbox"></asp:TextBox></td>
            </tr>
        </table>
        <div style="width: 70%; padding-top: 20px; text-align: center;">
            <asp:Button ID="Btn_Update_Dealer" runat="server" Text=" Update Dealer "
                CssClass="Btn btn_dealer" OnClick="Btn_Update_Dealer_Click" />&nbsp;&nbsp;&nbsp;<asp:Button ID="Btn_Reset"
                    runat="server" Text=" Reset " CssClass="Btn" OnClick="Btn_Reset_Click" />
        </div>
    </div>
</asp:Content>

