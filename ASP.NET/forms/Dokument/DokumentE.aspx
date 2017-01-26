﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="DokumentE.aspx.cs" Inherits="IIS.Product_47130.ДокументE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Документ</h2>
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
  <asp:Label CssClass="descLbl" ID="ctrlПутьLabel" runat="server" Text="Путь" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlПуть" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlНазваниеLabel" runat="server" Text="Название" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlНазвание" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlРасширениеLabel" runat="server" Text="Расширение" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlРасширение" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСобраниеLabel" runat="server" Text="Собрание" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlСобрание" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСобрание_ТемаLabel" runat="server" Text="Тема" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlСобрание_Тема" runat="server" ReadOnly="true">
</asp:TextBox>

</div>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>