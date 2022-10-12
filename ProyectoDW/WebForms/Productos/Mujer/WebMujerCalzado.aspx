<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebMujerCalzado.aspx.cs" Inherits="ProyectoDW.WebForms.Productos.Mujer.WebMujerCalzado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/bootstrap.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/style.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/flexslider.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/jquery-ui.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/pignose.layerslider.css") %>" type="text/css" media="all" />
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <!-- banner -->
            <div class="container">
                <div class="top_nav_right">
                    <div class="cart box_1">
                            <h3>
                                <div class="total">
                                    <i class="glyphicon glyphicon-shopping-cart" aria-hidden="true"></i>
                                    <asp:Label ID="lblIdTotal" runat="server" Text="" CssClass="simple_Cart_total"></asp:Label><asp:Label ID="lblIdCantidad" runat="server" Text=""></asp:Label>
                                </div>
                            </h3>
                        <p><asp:HyperLink ID="linkCarrito" runat="server" Text="Ver Carrito" CssClass="simpleCart_empty" NavigateUrl="~/WebForms/Carrito/WebCarrito.aspx"></asp:HyperLink></p>

                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
        <!-- //banner-top -->
    
    <script = "text/javascript" >
        function Agregado(msg) {
            Swal.fire({
                icon: 'success',
                title: msg
            })
        }
        function Error(msg) {
            Swal.fire({
                icon: 'warning',
                title: msg
            })
        }
        function Repite(msg) {
            Swal.fire({
                icon: 'info',
                title: msg
            })
        }
        function ErrorCatch(msg) {
            Swal.fire({
                icon: 'error',
                title: msg
            })
        }

    </script> 

    <!-- banner -->
    <div class="page-head">
        <div class="container">
            <h3>Calzado para Mujer</h3>
        </div>
    </div>
    <!-- //banner -->
    <div class="clearfix"></div>

    <div class="single-pro">
        <asp:Repeater ID="contenidoProductos" runat="server" OnItemCommand="contenidoProductos_ItemCommand">
            <ItemTemplate>
                <div class="col-md-3 product-men">
                    <div class="men-pro-item simpleCart_shelfItem">
                        <div class="men-thumb-item">
                            <img src="../../../<%# Eval("IMAGEN") %>" alt="" class="pro-image-front" />
                            <img src="../../../<%# Eval("IMAGEN") %>" alt="" class="pro-image-back" />
                            <div class="men-cart-pro">
                                <div class="inner-men-cart-pro">
                                    <a class="link-product-add-cart" href="../SoloProducto/WebSoloProducto.aspx?idProducto=<%# Eval("ID_PRODUCTO") %>">Vista Rapida</a>
                                </div>
                            </div>
                            <!--span class="product-new-top">New</!--span-->
                        </div>
                        <div class="item-info-product ">
                            <h4><a href="#"><%# Eval("PRODUCTO") %></a></h4>
                            <div class="info-product-price">
                                <span class="item_price"><%#  Eval("PRECIO", "{0:c}") %></span>
                            </div>
                            <asp:LinkButton ID="btnAgregar" runat="server" CommandName="Agregar" CommandArgument='<%# Eval("ID_PRODUCTO") %>' Text="Agregar al carrito" CssClass="item_add single-item hvr-outline-out button2"></asp:LinkButton>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <div class="clearfix"></div>
    </div>
</asp:Content>
