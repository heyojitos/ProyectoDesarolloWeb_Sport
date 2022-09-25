<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebCategoria.aspx.cs" Inherits="ProyectoDW.WebForms.Mantenimientos.WebCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<link rel="stylesheet" runat="server" media="screen" href="~/Content/StyleWebForm.css" />--%>
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/StyleWebForm.css") %>" type="text/css" />
    <div class="contenedor" id="contenedor">
        <div class="cabecera" id="cabecera">
            <th>Mantenimiento de Categorias</th>
        </div>
        
        <dx:ASPxGridView ID="dxGridCategoria" runat="server" AutoGenerateColumns="false"  ClientInstanceName="dxGridCategoria" KeyFieldName="ID_CATEGORIA" SettingsBehavior-ConfirmDelete ="true" 
            OnRowInserting="dxGridCategoria_RowInserting" OnRowUpdating="dxGridCategoria_RowUpdating" OnRowDeleting="dxGridCategoria_RowDeleting" Width="100%">
            <SettingsAdaptivity AdaptivityMode="HideDataCells" />
            <SettingsPager PageSize="10" />            
            <EditFormLayoutProperties>
                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="600" />
            </EditFormLayoutProperties>            
            <SettingsSearchPanel Visible="true"  />
            <Settings  ShowFooter="True"/>
            <SettingsCommandButton>
                    <EditButton  Text="Editar" Image-Url="~/Content/Images/edit.png" />
                    <NewButton   Text="Nuevo"  Image-Url="~/Content/Images/new.png"/>
                    <DeleteButton   Text="Eliminar"  Image-Url="~/Content/Images/borrar.png"/>
            </SettingsCommandButton>
            <Columns>
                <dx:GridViewCommandColumn ShowEditButton="true" ShowNewButton="true" ShowDeleteButton="true" />  
                               
                <dx:GridViewDataTextColumn Caption="CODIGO" FieldName="ID_CATEGORIA" VisibleIndex="1" ReadOnly="true">                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="CATEGORIA" FieldName="DESCRIPCION" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="PRODUCTO" FieldName="DESCRIPCION" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                
            </Columns>
            <SettingsPager>
                <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
            </SettingsPager>
        </dx:ASPxGridView>       
    </div>
</asp:Content>
