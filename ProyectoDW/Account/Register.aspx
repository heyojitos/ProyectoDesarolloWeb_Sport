<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Register.aspx.cs" Inherits="ProyectoDW.Register" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>


<asp:content id="RegistroLogin" contentplaceholderid="MainContent" runat="server">
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/bootstrap.css") %>" type="text/css" media="all"/>
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/style.css") %>" type="text/css" media="all"/>
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/flexslider.css") %>" type="text/css" media="all"/>
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/jquery-ui.css") %>" type="text/css" media="all"/>
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/pignose.layerslider.css") %>" type="text/css" media="all"/>
    <div class="accountHeader">
    <h2>Crear Usuario</h2>
    <p style="color:red">
      <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
</div>
   <div class="login"> 
<dx:ASPxTextBox ID="txtNombre" runat="server" Width="200px" Caption="Nombre:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere su nombre" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
    <dx:ASPxTextBox ID="txtApellido" runat="server" Width="200px" Caption="Apellido:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere su apellido" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
<dx:ASPxTextBox ID="txtEmail" runat="server" Width="200px" Caption="Correo electronico:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere su correo" IsRequired="true" />
    <RegularExpression ErrorText="Falla de validacion de correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
  </ValidationSettings>
</dx:ASPxTextBox>
<dx:ASPxTextBox ID="txtContra" ClientInstanceName="Password" Password="true" runat="server" Width="200px" Caption="Contraseña:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere su contraseña" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
<dx:ASPxTextBox ID="txtConfirmContra" Password="true" runat="server" Width="200px" Caption="Confirmar contraseña:">
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
    <dx:ASPxTextBox ID="txtDireccionEnvio" runat="server" Width="200px" Caption="Direccion de envio:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere una direccion" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
    <dx:ASPxTextBox ID="txtDireccionFacturacion" runat="server" Width="200px" Caption="Direccion de facturacion:" ClientInstanceName="txtDirFactura">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere una direccion" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
    <dx:ASPxCheckBox ID="chboxDireccion" runat="server" Width="200px" Text="Desea usar la misma direccion de envio?" AutoPostBack="true" OnCheckedChanged="chboxDireccion_CheckedChanged">
        
    </dx:ASPxCheckBox>
        <dx:ASPxTextBox ID="txtTelefono" runat="server" Width="200px" Caption="Telefono:">
  <CaptionSettings Position="Top" />
  <ValidationSettings ValidationGroup="RegisterUserValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
    <RequiredField ErrorText="Se requiere un numero de telefono" IsRequired="true" />
  </ValidationSettings>
</dx:ASPxTextBox>
       </div>
<br />
<dx:ASPxButton ID="btnCreateUser" runat="server" Text="Crear Usuario" ValidationGroup="RegisterUserValidationGroup"
    OnClick="btnCreateUser_Click">
</dx:ASPxButton>
</asp:content>