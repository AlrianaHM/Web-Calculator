<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalculatorForm.aspx.cs" Inherits="Calculator.CalculatorForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="232px" style="padding-left: 5px;padding-top: 5px;padding-right: 5px;padding-bottom: 5px" Width="300px" Wrap="False" BorderStyle="Solid" BackColor="#CCCCCC">
        <br />
        <asp:TextBox ID="ShowBox" runat="server" BorderStyle="Solid" Height="30px" Width="300px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Text="7" Width="50px" OnClick="Button7_Click" />
        &nbsp;<asp:Button ID="Button8" runat="server" Text="8" Width="50px" OnClick="Button8_Click" />
        &nbsp;<asp:Button ID="Button9" runat="server" Text="9" Width="50px" OnClick="Button9_Click" />
        &nbsp;<asp:Button ID="SumButton0" runat="server"  Text="+" Width="50px" OnClick="SumButton0_Click" />
        &nbsp;<asp:Button ID="DeleteButton" runat="server" Text="Del" Width="50px" OnClick="DeleteButton_Click" />
        <br />
        <asp:Button ID="Button4" runat="server" Text="4" Width="50px" OnClick="Button4_Click" />
        &nbsp;<asp:Button ID="Button5" runat="server" Text="5" Width="50px" OnClick="Button5_Click" />
        &nbsp;<asp:Button ID="Button6" runat="server" Text="6" Width="50px" OnClick="Button6_Click" />
        &nbsp;<asp:Button ID="MinusButton" runat="server" Text="-" Width="50px" OnClick="MinusButton_Click" />
        &nbsp;<asp:Button ID="ClearButton" runat="server" Text="C" Width="50px" OnClick="ClearButton_Click" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="1" Width="50px" OnClick="Button1_Click" />
        &nbsp;<asp:Button ID="Button2" runat="server" Text="2" Width="50px" OnClick="Button2_Click" />
        &nbsp;<asp:Button ID="Button3" runat="server" Text="3" Width="50px" OnClick="Button3_Click" />
        &nbsp;<asp:Button ID="MultiplyButton" runat="server" Text="*" Width="50px" OnClick="MultiplyButton_Click" />
        <br />
        <asp:Button ID="Button0" runat="server" Text="0" Width="50px" OnClick="Button0_Click" />
        &nbsp;<asp:Button ID="ComaButton" runat="server" Text="." Width="50px" OnClick="ComaButton_Click" />
        &nbsp;<asp:Button ID="ResultButton" runat="server" Text="=" Width="50px" OnClick="ResultButton_Click"/>
        &nbsp;<asp:Button ID="DivButton" runat="server" Text="/" Width="50px" OnClick="DivButton_Click" />
    </asp:Panel>
</asp:Content>
