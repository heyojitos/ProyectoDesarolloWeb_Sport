<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Register.aspx.cs" Inherits="ProyectoDW.Register" %>

<asp:content id="RegistroLogin" contentplaceholderid="MainContent" runat="server">
    <div class="accountHeader">
    <h2>Crear Usuario</h2>
    <p style="color:red">
      <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
</div>
<dx:ASPxTextBox ID="tbUserName" runat="server" Width="200px" Caption="Nombre:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere su nombre" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
    <dx:ASPxTextBox ID="tbUserName1" runat="server" Width="200px" Caption="Apellido:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere su apellido" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
<dx:ASPxTextBox ID="tbEmail" runat="server" Width="200px" Caption="Correo electr�nico:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere su correo" IsRequired="true" />
    <RegularExpression ErrorText="Falla de validaci�n de correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
  </ValidationSettings>
</dx:ASPxTextBox>
<dx:ASPxTextBox ID="tbPassword" ClientInstanceName="Password" Password="true" runat="server" Width="200px" Caption="Contrase�a:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere su contrase�a" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
<dx:ASPxTextBox ID="tbConfirmPassword" Password="true" runat="server" Width="200px" Caption="Confirmar contrase�a:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere la confirmaci�n de contrase�a" IsRequired="true" />
  </ValidationSettings>
  <ClientSideEvents Validation="function(s, e) {
            var originalPasswd = Password.GetText();
            var currentPasswd = s.GetText();
            e.isValid = (originalPasswd  == currentPasswd );
            e.errorText = 'La contrase�a debe coincidir';
        }" />
</dx:ASPxTextBox>
<br />
<dx:ASPxButton ID="btnCreateUser" runat="server" Text="Crear Usuario" ValidationGroup="RegisterUserValidationGroup"
    OnClick="btnCreateUser_Click">
</dx:ASPxButton>
</asp:content>