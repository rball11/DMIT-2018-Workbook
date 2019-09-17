﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCategories.aspx.cs" Inherits="WebAppCRUD.Admin.ViewCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Categories</h1>

    <asp:Repeater ID="CategoryRepeater" runat="server" DataSourceID="CategoriesDataSource" ItemType="WestWindSystem.Entities.Category">
        <HeaderTemplate><ul></HeaderTemplate>
        <ItemTemplate>
            <li>
                <b><%# Item.CategoryName %></b>
                &mdash;
                <i><%# Item.Description %></i>
                <img src="data:<%# Item.PictureMimeType %>;base64,<%# Convert.ToBase64String(Item.Picture) %>" width="50" />
            </li>
        </ItemTemplate>
        <SeparatorTemplate></SeparatorTemplate>
        <FooterTemplate></ul></FooterTemplate>
    </asp:Repeater>

<%--    <asp:GridView ID="CategoryGridView" runat="server" AutoGenerateColumns="False" DataSourceID="CategoriesDataSource" CssClass="table table-hover" HeaderStyle-BackColor="ControlLight">
        <Columns>
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID"></asp:BoundField>
            <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName"></asp:BoundField>
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description"></asp:BoundField>
            <asp:BoundField DataField="PictureMimeType" HeaderText="PictureMimeType" SortExpression="PictureMimeType"></asp:BoundField>
        </Columns>--
    </asp:GridView>--%>

    <asp:ObjectDataSource runat="server" ID="CategoriesDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListCategories" TypeName="WestWindSystem.BLL.CRUDController"></asp:ObjectDataSource>
</asp:Content>
