<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebMantenimientos.aspx.cs" Inherits="ProyectoDW.WebForms.Mantenimientos.WebMantenimientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <br />
    <div class="pt-1 mb-4">
        <dx:ASPxButton ID="btnRedirectCategoria" runat="server" Text="Mantenimiento de Categorias" CssClass=" btn-lg" Width="200px"
            OnClick="btnRedirectCategoria_Click">
        </dx:ASPxButton>
    </div>
      <br />
    <div class="pt-1 mb-4">
        <dx:ASPxButton ID="btnRedirectCliente" runat="server" Text="Mantenimiento de Clientes" CssClass=" btn-lg" Width="200px"
            OnClick="btnRedirectCliente_Click">
        </dx:ASPxButton>
    </div>
          <br />

    <div class="pt-1 mb-4">
        <dx:ASPxButton ID="btnRedirectProducto" runat="server" Text="Mantenimiento de Productos" CssClass=" btn-lg" Width="200px"
            OnClick="btnRedirectProducto_Click">
        </dx:ASPxButton>
    </div>
</asp:Content>
