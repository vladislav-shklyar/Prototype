﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StudentL.aspx.cs" Inherits="IIS.Product_47130.СтудентL" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.ListFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.ListFormHeaderCssClass %>">Студент</h2>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.ListFormControlsCssClass %>">
            <ac:WebObjectListView ID="WebObjectListView1" runat="server" Visible="true" />
        </div>
    </div>
</asp:Content>
