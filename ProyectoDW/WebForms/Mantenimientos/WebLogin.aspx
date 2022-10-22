<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="ProyectoDW.WebForms.Mantenimientos.WebLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <div>
            
                <div class="accountHeader">
                    <h3 class="fw-normal mb-3 pb-3" style="letter-spacing: 1px;">Iniciar sesion como administrador</h3>
                </div>

                <div class="form-outline mb-4">
                    <dx:ASPxTextBox ID="tbUserNameAdm" runat="server" Width="400px" Caption="Correo Electronico" CssClass="form-control form-control-lg">
                        <CaptionSettings Position="Top" />

                    </dx:ASPxTextBox>
                </div>

                <div class="form-outline mb-4">
                    <dx:ASPxTextBox ID="tbPasswordAdm" runat="server" Password="true" Width="400px" Caption="Clave" CssClass="form-control form-control-lg">
                        <CaptionSettings Position="Top" />

                    </dx:ASPxTextBox>
                </div>
            <br />
                <div class="pt-1 mb-4">
                    <dx:ASPxButton ID="btnLoginAdm" runat="server" Text="Ingresar" ValidationGroup="LoginUserValidationGroup" CssClass=" btn-lg" Width="200px" OnClick="btnLoginAdm_Click">
                    </dx:ASPxButton>
                </div>

        </div>
    </div>
    
</asp:Content>
