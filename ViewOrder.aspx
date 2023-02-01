<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ViewOrder.aspx.cs" Inherits="OrderManagementSystem.ViewOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> VIEW ORDER </h1>
    <table >

            <tr>
                <td>Category</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </tr>
            <tr>
                <td>Product</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Unit price(RS:)</td>
                <td>
                    <asp:TextBox ID="txtUnitprice" runat="server" ReadOnly="True" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Quantity</td>
                <td>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Discount %</td>
                <td>
                    <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>TotalAmount</td>
                <td>
                    <asp:TextBox ID="txtTotalAmount" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <%--<tr>
                <td>RequiredByDate</td>
                <td>
                    <asp:TextBox ID="txtRequiredByDate" runat="server"></asp:TextBox>
                    
                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtRequiredByDate"></asp:CalendarExtender>
                    <%--<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Future date shoukd be selected" Type="Date" Operator="GreaterThanEqual"></asp:CompareValidator>--%>
               <%-- </td>
            </tr>--%>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</asp:Content>
