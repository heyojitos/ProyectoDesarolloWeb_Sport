<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebDatosCliente.aspx.cs" Inherits="ProyectoDW.WebForms.Carrito.WebDatosCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container well contenedor">
        
        
            <div class="row">
            <div class="col-xs-12">
                <h2>Datos de envio</h2>
            </div>
        </div>
            <div class="form-group">
                <asp:Label ID="lblDireccion" runat="server" Text="Direccion" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>            

            <div class="form-group">
                <asp:Label ID="lblContacto" runat="server" Text="Nombre de Contacto" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtContacto" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="lblTelefono" runat="server" Text="Telefono" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="form-group">
                <asp:Button ID="btnContinuar" runat="server" Text="btnContinuar" CssClass="form-control btn btn-primary" OnClick="btnContinuar_Click" />
            </div>

        
    </div>
</asp:Content>
