<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebMujerRopa.aspx.cs" Inherits="ProyectoDW.WebForms.Productos.Mujer.WebMujerRopa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/bootstrap.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/style.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/flexslider.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/jquery-ui.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/pignose.layerslider.css") %>" type="text/css" media="all" />

    <!-- banner -->
    <div class="page-head">
        <div class="container">
            <h3>Ropa para Mujer</h3>
        </div>
    </div>
    <!-- //banner -->
    <div class="clearfix"></div>

    <div class="single-pro">
        <asp:Repeater ID="contenidoProductos" runat="server">
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
                                <span class="item_price"><%# Eval("PRECIO", "{0:c}") %></span>
                            </div>
                            <a href="../../Carrito/WebCarrito.aspx?idProducto=<%# Eval("ID_PRODUCTO") %>" class="item_add single-item hvr-outline-out button2">Agregar al carrito</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <div class="clearfix"></div>
    </div>
</asp:Content>
