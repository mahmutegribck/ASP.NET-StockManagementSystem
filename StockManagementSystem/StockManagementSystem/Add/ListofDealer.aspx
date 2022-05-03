<%@ Page Title="" Language="C#" MasterPageFile="~/smsMP.master" AutoEventWireup="true" CodeFile="ListofDealer.aspx.cs" Inherits="Add_ListofDealer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .addtable {
            border-collapse: collapse;
            border: 1px solid #ff0000;
            padding: 10px;
            width: 88%;
        }

        .addtableheader {
            background: #db6c19;
            text-align: left;
            padding: 10px 15px 10px 15px;
            color: #ffffff;
            font-size: 1.5em;
            border: 1px solid #db6c19;
        }

        .GridView1 {
            background-color: #dddddd;
            padding: 7px 10px 7px 10px;
            margin-top: 10px;
        }

        .Grd_HeaderStyle {
            background: #6699cc;
            color: #ffffff;
            padding: 7px 10px 7px 10px;
        }

        .Grd_row {
            padding: 7px 10px 7px 10px;
        }

        .txtsearch {
            padding: 3px 10px 3px 10px;
            margin: 0px 220px 0px -160px;
            text-align: left;
            float: right;
        }

        .btnsearch {
            margin: 0px -100px 0px -50px;
            padding: 4px 10px 4px 10px;
            background-color:darkcyan;
            color: #ffffff;
            border: 1px solid darkcyan;
            float: right;
        }

    
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <table class="addtable mx-auto mt-5">
            <tr>
                <th class="addtableheader" colspan="3">List Of Dealer's Details : </th>
            </tr>
        </table>
        <div style="float: right; padding: 10px; width: 88%;">
            <asp:TextBox ID="txt_search" CssClass="txtsearch" runat="server" placeholder="Search ..."></asp:TextBox>
            <asp:Button ID="Btn_Search" runat="server" CssClass="btnsearch" Text=" Search "
                OnClick="Btn_Search_Click" />
        </div>

        <asp:GridView ID="GridView1" runat="server" CssClass="GridView1">
            <HeaderStyle CssClass="Grd_HeaderStyle"></HeaderStyle>
        </asp:GridView>
    </div>
</asp:Content>

