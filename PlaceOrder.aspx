<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="OrderManagementSystem.PlaceOrder" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

        <h1>Order details</h1><br />


        <table class="auto-style1">

            <tr>
                <td>Category</td>
                <td>
                    <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Product</td>
                <td>
                    <asp:DropDownList ID="ddlProduct" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProduct_SelectedIndexChanged">
                    </asp:DropDownList>
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
                    <asp:TextBox ID="txtQuantity" runat="server" AutoPostBack="true" OnTextChanged="txtQuantity_TextChanged"></asp:TextBox>
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
            <tr>
                <td>RequiredByDate</td>
                <td>
                    <asp:TextBox ID="txtRequiredByDate" runat="server"></asp:TextBox>
                    
                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtRequiredByDate"></asp:CalendarExtender>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Future date shoukd be selected" Type="Date" Operator="GreaterThanEqual"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" style="height: 26px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>


            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
