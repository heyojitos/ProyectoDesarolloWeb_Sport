<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebProducto.aspx.cs" Inherits="ProyectoDW.WebForms.Mantenimientos.WebProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<link rel="stylesheet" runat="server" media="screen" href="~/Content/StyleWebForm.css" />--%>
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/StyleWebForm.css") %>" type="text/css" />
    <div class="contenedor" id="contenedor">
        <div class="cabecera" id="cabecera">
            <th>Mantenimiento de Productos</th>
        </div>
        
        <dx:ASPxGridView ID="dxGridProducto" runat="server" AutoGenerateColumns="false"  ClientInstanceName="dxGridProducto" KeyFieldName="ID_PRODUCTO" SettingsBehavior-ConfirmDelete ="true" 
            OnRowInserting="dxGridProducto_RowInserting" OnRowUpdating="dxGridProducto_RowUpdating" OnRowDeleting="dxGridProducto_RowDeleting" Width="100%">
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
                               
                <dx:GridViewDataTextColumn Caption="CODIGO" FieldName="ID_PRODUCTO" VisibleIndex="1" ReadOnly="true">                    
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="MODELO" FieldName="PRODUCTO" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="PRODUCTO" FieldName="DESCRIPCION" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataComboBoxColumn Caption="CATEGORIA" FieldName="ID_CATEGORIA" VisibleIndex="2">
                    <PropertiesComboBox TextField="DESCRIPCION" ValueField="TIPO_PRODUCTO" ValueType="System.Int32" 
                        DataSourceID="sqlDtsCategoria" EnableSynchronization="False" IncrementalFilteringMode="StartsWith">
                    </PropertiesComboBox>
                    <Settings AllowAutoFilter="False" />
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataTextColumn Caption="PRECIO" FieldName="PRECIO" VisibleIndex="3">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="ILUSTRACION" FieldName="IMAGEN" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="STOCK" FieldName="STOCK" VisibleIndex="5">
                </dx:GridViewDataTextColumn>
            </Columns>
            <SettingsPager>
                <PageSizeItemSettings Visible="true" Items="10, 20, 50" />
            </SettingsPager>
        </dx:ASPxGridView>
        <asp:SqlDataSource ID="sqlDtsCategoria" runat="server" ConnectionString="<%$ ConnectionStrings:SistemaSPORT %>" 
            SelectCommand="SELECT ID_CATEGORIA AS TIPO_PRODUCTO, DESCRIPCION FROM TB_CATEGORIA">

        </asp:SqlDataSource>
    </div>
</asp:Content>
