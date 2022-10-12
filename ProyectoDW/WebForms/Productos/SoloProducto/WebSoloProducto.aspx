<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebSoloProducto.aspx.cs" Inherits="ProyectoDW.WebForms.Productos.SoloProducto.WebSoloProducto" %>

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
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.easing.min.js") %>"></script>
    <link rel="stylesheet" href="flexslider.css" type="text/css">
    <script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js"></script>
    <script src="jquery.flexslider.js" type="text/javascript"></script>
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

    <!-- single -->
    <div class="single">
        <asp:DataList ID="dtlistSolo" runat="server" OnItemCommand="dtlistSolo_ItemCommand">
            <ItemTemplate>
                <div class="container">
                    <div class="col-md-6 single-right-left animated wow slideInUp animated" data-wow-delay=".5s" style="visibility: visible; animation-delay: 0.5s; animation-name: slideInUp;">
                        <div class="grid images_3_of_2">
                            <div class="flexslider">
                                <!-- FlexSlider -->
                                <script = "text/javascript" >
                                    // Can also be used with $(document).ready()
                                    $(windows).load(function () {
                                        $('.flexslider').flexslider({
                                            animation: "slide",
                                            controlNav: "thumbnails"
                                        });
                                    });
						        </script>
                                <!-- //FlexSlider-->
                                <ul class="slides">
                                    <li data-thumb="../../../<%# Eval("IMAGEN") %>">
                                        <div class="thumb-image">
                                            <img src="../../../<%# Eval("IMAGEN") %>" data-imagezoom="true" class="img-responsive" />
                                        </div>
                                    </li>
                                </ul>
                                <div class="clearfix"></div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6 single-right-left simpleCart_shelfItem animated wow slideInRight animated" data-wow-delay=".5s" style="visibility: visible; animation-delay: 0.5s; animation-name: slideInRight;">
                        <h3><%# Eval("PRODUCTO") %></h3>
                        <p><span class="item_price"><%# Eval("PRECIO", "{0:c}") %></span></p>
                        <div class="description">
                            <h5><%# Eval("DESCRIPCION") %></h5>
                        </div>
                        
                        <div class="occasional">
                            <div class="clearfix"></div>
                        </div>
                        <div class="occasion-cart">
                            <asp:LinkButton ID="btnAgregar" runat="server" CommandName="Agregar" CommandArgument='<%# Eval("ID_PRODUCTO") %>' Text="Agregar al carrito" CssClass="item_add single-item hvr-outline-out button2"></asp:LinkButton>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </ItemTemplate>
        </asp:DataList>

    </div>
    <!-- //single -->
</asp:Content>
