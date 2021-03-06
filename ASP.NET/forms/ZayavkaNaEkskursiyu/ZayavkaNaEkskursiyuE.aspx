﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="ZayavkaNaEkskursiyuE.aspx.cs" Inherits="IIS.Product_47130.ЗаявкаНаЭкскурсиюE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Заявка на экскурсию</h2>
        <div class="<%= Constants.FormToolbarCssClass %> <%= Constants.EditFormToolbarCssClass %> <%= Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаLabel" runat="server" Text="Дата" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДата" runat="server"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКоличествоLabel" runat="server" Text="Количество" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlКоличество" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЭкскурсияLabel" runat="server" Text="Экскурсия" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlЭкскурсия" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЭкскурсия_ДатаLabel" runat="server" Text="Дата" EnableViewState="False">
</asp:Label>
<div class="descTxt">
	<asp:TextBox ID="ctrlЭкскурсия_Дата" CssClass="datepicker" runat="server" ReadOnly="true"/>
</div>
</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlУниверситетLabel" runat="server" Text="Университет" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlУниверситет" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlУниверситет_НазваниеLabel" runat="server" Text="Название" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlУниверситет_Название" runat="server" ReadOnly="true">
</asp:TextBox>

</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
