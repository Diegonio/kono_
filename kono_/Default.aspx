
<%@ Page Title="Inicio de sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="kono_._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-4" style="max-width:420px;">
        <h2>Iniciar sesión</h2>
        <asp:Label ID="lblMessage" runat="server" CssClass="text-danger" />

        <div class="mb-3">
            <asp:Label ID="lblUser" runat="server" AssociatedControlID="txtUsername">Usuario</asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
        </div>

        <div class="mb-3">
            <asp:Label ID="lblPass" runat="server" AssociatedControlID="txtPassword">Contraseña</asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" />
        </div>

        <asp:Button ID="btnLogin" runat="server" Text="Entrar" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
    </div>
</asp:Content>

