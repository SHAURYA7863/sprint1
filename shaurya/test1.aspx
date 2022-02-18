<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="test1.aspx.cs" Inherits="shaurya.test1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" cellpadding="10" style="width: 60%;">
    <tr>
        <td colspan="3">
            <strong>US 1 TASK (Test on Green Background)</strong></td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:TextBox ID="Txt1" runat="server" style="margin-top: 2px" 
                meta:resourcekey="Txt1Resource1"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Font-Bold="True" 
                onclick="btnSubmit_Click" Text="Submit" 
                meta:resourcekey="btnSubmitResource1" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Label ID="lblResult" runat="server" Font-Bold="True" 
                meta:resourcekey="lblResultResource1" style="font-size: xx-large"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
