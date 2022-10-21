<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Login.aspx.cs" Inherits="ProyectoDW.Login" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">

    <div class="container">
        <div class="abs-center">
            <form style="width: 23rem;">
                <div class="accountHeader">
                    <h3 class="fw-normal mb-3 pb-3" style="letter-spacing: 1px;">Iniciar sesion</h3>
                </div>

                <div class="form-outline mb-4">
                    <dx:ASPxTextBox ID="tbUserName" runat="server" Width="400px" Caption="Correo Electronico" CssClass="form-control form-control-lg">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="LoginUserValidationGroup" ErrorTextPosition="Bottom" Display="Dynamic" ErrorDisplayMode="Text">
                            <RegularExpression ErrorText="Falla de validación de correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                            <RequiredField ErrorText="Completa este campo." IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>

                <div class="form-outline mb-4">
                    <dx:ASPxTextBox ID="tbPassword" runat="server" Password="true" Width="400px" Caption="Clave" CssClass="form-control form-control-lg">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="LoginUserValidationGroup" ErrorTextPosition="Bottom" Display="Dynamic" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="Completa este campo." IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </div>

                <div class="form-outline mb-4">
                </div>
                <div class="form-outline mb-4">
                    <p>
                        <a href="Register.aspx">Crear una cuenta.</a>
                    </p>
                </div>

                <div class="pt-1 mb-4">
                    <dx:ASPxButton ID="btnLogin" runat="server" Text="Ingresar" ValidationGroup="LoginUserValidationGroup" CssClass=" btn-lg" Width="200px"
                        OnClick="btnLogin_Click">
                    </dx:ASPxButton>
                </div>
            </form>
        </div>
    </div>

    

    <%-- Enable this once you have account confirmation enabled for password reset functionality
<br />
<dx:ASPxHyperLink runat="server" NavigateUrl="~/Account/ForgotPassword.aspx" Text="Forgot your password?" />
    --%>
    <br />
    <%--<uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />--%>

    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>


</asp:Content>

