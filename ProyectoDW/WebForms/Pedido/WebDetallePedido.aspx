<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebDetallePedido.aspx.cs" Inherits="ProyectoDW.WebForms.Pedido.WebDetallePedido" %>

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
            <h3>Detalle Compra</h3>

            <div class="table-responsive checkout-right animated wow slideInUp" data-wow-delay=".5s">
                <asp:GridView ID="gridPedidos" runat="server" CssClass="timetable_sub" AutoGenerateColumns="False" ShowFooter="false" EnableCallBacks="false">
                    <Columns>
                        <asp:BoundField DataField="ID_DETALLE_PEDIDO" HeaderText="Codigo de Compra" ReadOnly="true" />
                        <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" ReadOnly="true" />
                        <asp:TemplateField HeaderText="Imagen">
                            <ItemTemplate>
                                <img src="../../" class="img-responsive" width="140px" height="140px" />                          
                            </ItemTemplate>
                        </asp:TemplateField>                       
                        <asp:BoundField DataField="CANTIDAD" HeaderText="Cantidad" ReadOnly="true"  />
                        <asp:BoundField DataField="SUBTOTAL" HeaderText="SubTotal" ReadOnly="true" DataFormatString="{0:c}"/>
                    </Columns>
                </asp:GridView>
            </div>
            <div class="checkout-left">
                <div class="checkout-right-basket animated wow slideInRight" data-wow-delay=".5s">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForms/Pedido/WebPedido.aspx"><span class="glyphicon glyphicon-menu-left" aria-hidden="true"></span>Regresar</asp:HyperLink>
                </div>

                <div class="checkout-left-basket animated wow slideInLeft" data-wow-delay=".5s">
                    <ul>
                        <li>Monto Total: <i>-</i> <span><asp:Label ID="idTotal" runat="server" Text=""></asp:Label></span></li>
                    </ul>
                </div>
                <div class="clearfix"></div>
        </div>
    </div>
    <!-- //check out -->
    <!-- //product-nav -->
</asp:Content>
