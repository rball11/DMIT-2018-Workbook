<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewAddresses.aspx.cs" Inherits="WebAppCRUD.Admin.ViewAddresses1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Address CRUD</h1>

    <asp:ObjectDataSource ID="AddressDataSource" 
        runat="server" 
        DataObjectTypeName="WestWindSystem.Entities.Supplier" 
        DeleteMethod="DeleteSupplier" 
        InsertMethod="AddSupplier" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="ListAddresses" 
        TypeName="WestWindSystem.BLL.CRUDController" 
        UpdateMethod="UpdateSupplier"></asp:ObjectDataSource>
</asp:Content>
