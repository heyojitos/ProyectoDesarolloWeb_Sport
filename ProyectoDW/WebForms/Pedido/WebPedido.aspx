<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebPedido.aspx.cs" Inherits="ProyectoDW.WebForms.Pedido.WebPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/bootstrap.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/style.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/jquery-ui.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/pignose.layerslider.css") %>" type="text/css" media="all" />
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery-2.1.4.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/imagezoom.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.flexslider.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/simpleCart.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/bootstrap-3.1.1.min.js") %>"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/MaterialDesign-Webfont/3.6.95/css/materialdesignicons.css"></script>

    <script = "text/javascript">

    </script>

    <!-- check out -->
    <div class="checkout">
        <div class="container">
            <h3>Mis Compras</h3>

            <div class="table-responsive checkout-right animated wow slideInUp" data-wow-delay=".5s">
                <asp:GridView ID="gridPedidos" runat="server" CssClass="timetable_sub" AutoGenerateColumns="False" ShowFooter="false" EnableCallBacks="false">
                    <Columns>
                        <asp:BoundField DataField="ID_PEDIDO" HeaderText="Codigo de Compra" ReadOnly="true" />
                        <asp:BoundField DataField="FECHA_PEDIDO" HeaderText="Fecha de Compra" ReadOnly="true" Visible="false" />
                        <asp:BoundField DataField="NOMBRE_CLIENTE" HeaderText="Nombre del cliente" ReadOnly="true" Visible="false" />
                        <asp:BoundField DataField="NIT" HeaderText="Nit del cliente" ReadOnly="true" Visible="false" />
                        <asp:BoundField DataField="MONTO" HeaderText="Total" ReadOnly="true" DataFormatString="{0:c}" />
                        <asp:BoundField DataField="ESTADO" HeaderText="Estado" ReadOnly="true" />
                        <asp:TemplateField HeaderText="">
                            <ItemTemplate>
                                <a href="WebDetallePedido.aspx?codPed=1"></a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
    <!-- //check out -->
    <!-- //product-nav -->
</asp:Content>
