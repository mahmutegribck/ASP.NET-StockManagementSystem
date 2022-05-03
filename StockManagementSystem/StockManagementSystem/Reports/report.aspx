<%@ Page Title="" Language="C#" MasterPageFile="~/smsMP.master" AutoEventWireup="true" CodeFile="report.aspx.cs" Inherits="Reports_report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <h3>VIEW REPORTS</h3>
    <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
        DataKeyNames="cust_payID" DataSourceID="SqlDataSource1"
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
        CellPadding="3" CellSpacing="2">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False"
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="cust_payID" HeaderText="cust_payID" ReadOnly="True"
                SortExpression="cust_payID" />
            <asp:BoundField DataField="custID" HeaderText="custID"
                SortExpression="custID" />
            <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
            <asp:BoundField DataField="cust_pay_mode" HeaderText="cust_pay_mode"
                SortExpression="cust_pay_mode" />
            <asp:BoundField DataField="cust_bankname_creditcardno"
                HeaderText="cust_bankname_creditcardno"
                SortExpression="cust_bankname_creditcardno" />
            <asp:BoundField DataField="cust_checkno_trnxno"
                HeaderText="cust_checkno_trnxno" SortExpression="cust_checkno_trnxno" />
            <asp:BoundField DataField="cust_amount" HeaderText="cust_amount"
                SortExpression="cust_amount" />
        </Columns>


        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />


    </asp:GridView>



    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:sms %>"
        SelectCommand="SELECT * FROM [Payment]"></asp:SqlDataSource>

    <br />
    <h3>Dealer Report</h3>
    <asp:GridView ID="GridView2" runat="server" AllowPaging="True"
        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="dealerid"
        DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False"
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="dealerid" HeaderText="dealerid" ReadOnly="True"
                SortExpression="dealerid" />
            <asp:BoundField DataField="dealername" HeaderText="dealername"
                SortExpression="dealername" />
            <asp:BoundField DataField="dealerhouseno" HeaderText="dealerhouseno"
                SortExpression="dealerhouseno" />
            <asp:BoundField DataField="dealerstreetname" HeaderText="dealerstreetname"
                SortExpression="dealerstreetname" />
            <asp:BoundField DataField="dealerarea" HeaderText="dealerarea"
                SortExpression="dealerarea" />
            <asp:BoundField DataField="dealerlandmark" HeaderText="dealerlandmark"
                SortExpression="dealerlandmark" />
            <asp:BoundField DataField="dealercity" HeaderText="dealercity"
                SortExpression="dealercity" />
            <asp:BoundField DataField="dealerstate" HeaderText="dealerstate"
                SortExpression="dealerstate" />
            <asp:BoundField DataField="dealerpincode" HeaderText="dealerpincode"
                SortExpression="dealerpincode" />
            <asp:BoundField DataField="dealercontactno" HeaderText="dealercontactno"
                SortExpression="dealercontactno" />
            <asp:BoundField DataField="dealerlandlineno" HeaderText="dealerlandlineno"
                SortExpression="dealerlandlineno" />
            <asp:BoundField DataField="dealership_since" HeaderText="dealership_since"
                SortExpression="dealership_since" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource2" runat="server"
        ConnectionString="<%$ ConnectionStrings:sms_db %>"
        SelectCommand="SELECT * FROM [Dealers]"></asp:SqlDataSource>
</asp:Content>

