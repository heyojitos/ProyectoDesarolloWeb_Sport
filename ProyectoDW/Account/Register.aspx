<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Register.aspx.cs" Inherits="ProyectoDW.Register" %>

<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">

   
    <form style="width: 23rem;"> 

    <div class="accountHeader">
        <h3 class="fw-normal mb-3 pb-3" style="letter-spacing: 1px;">Crear una cuenta nueva</h3>
    </div>
    
    <div class="form-outline mb-4">
        <dx:ASPxTextBox ID="tbUserName" runat="server" Width="400px" Caption="Nombre" CssClass="form-control form-control-lg">
            <CaptionSettings Position="Top" />
            <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                <RequiredField ErrorText="El nombre de usuario es obligatorio." IsRequired="true" />
            </ValidationSettings>
        </dx:ASPxTextBox>
    </div>
    
    <div class="form-outline mb-4">
        <dx:ASPxTextBox ID="tbEmail" runat="server" Width="400px" Caption="E-mail" CssClass="form-control form-control-lg">
            <CaptionSettings Position="Top" />
            <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                <RequiredField ErrorText="E-mail is required." IsRequired="true" />
                <RegularExpression ErrorText="Email validation failed" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
            </ValidationSettings>
        </dx:ASPxTextBox>
    </div>

        <div class="form-outline mb-4">
            <dx:ASPxTextBox ID="tbPassword" ClientInstanceName="Contraseña" Password="true" runat="server" Width="400px" Caption="Password" CssClass="form-control form-control-lg">
                <CaptionSettings Position="Top" />
                <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                    <RequiredField ErrorText="Password is required." IsRequired="true" />
                </ValidationSettings>
            </dx:ASPxTextBox>
        </div>

        <div class="form-outline mb-4">
            <dx:ASPxTextBox ID="tbConfirmPassword" Password="true" runat="server" Width="400px" Caption="Confirme contraseña" CssClass="form-control form-control-lg">
                <CaptionSettings Position="Top" />
                <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                    <RequiredField ErrorText="Confirm Password is required." IsRequired="true" />
                </ValidationSettings>
                <ClientSideEvents Validation="function(s, e) {
            var originalPasswd = Password.GetText();
            var currentPasswd = s.GetText();
            e.isValid = (originalPasswd  == currentPasswd );
            e.errorText = 'The Password and Confirmation Password must match.';
        }" />
            </dx:ASPxTextBox>
        </div>

        <div class="pt-1 mb-4">
            <dx:ASPxButton ID="btnCreateUser" runat="server" Text="Create User" ValidationGroup="RegisterUserValidationGroup" CssClass=" btn-lg" Width="200px"
                OnClick="btnCreateUser_Click">
            </dx:ASPxButton>
        </div>





</asp:content>