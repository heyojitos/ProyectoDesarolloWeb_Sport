﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebSoloProducto.aspx.cs" Inherits="ProyectoDW.WebForms.Productos.SoloProducto.WebSoloProducto" %>

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

    <!-- single -->
    <div class="single">
        <asp:DataList ID="dtlistSolo" runat="server">
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
                        <p><span class="item_price">Q.<%# Eval("PRECIO") %></span></p>
                        <div class="description">
                            <h5><%# Eval("DESCRIPCION") %></h5>
                        </div>
                        <div class="color-quality">
                            <div class="color-quality-right">
                                <h5>Cantidad :</h5>
                                <div class="quantity">
                                    <div class="quantity-select">
                                        <div class="entry value-minus">&nbsp;</div>
                                        <div class="entry value"><span>1</span></div>
                                        <div class="entry value-plus active">&nbsp;</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="occasional">
                            
                            <div class="clearfix"></div>
                        </div>
                        <div class="occasion-cart">
                            <a href="#" class="item_add hvr-outline-out button2">Agregar al carrito</a>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                    <!--quantity-->
                    <script ="text/javascript">
                        $('.value-plus').on('click', function () {
                            var divUpd = $(this).parent().find('.value'), newVal = parseInt(divUpd.text(), 10) + 1;
                            divUpd.text(newVal);
                        });

                        $('.value-minus').on('click', function () {
                            var divUpd = $(this).parent().find('.value'), newVal = parseInt(divUpd.text(), 10) - 1;
                            if (newVal >= 1) divUpd.text(newVal);
                        });
                    </script>
                    <!--quantity-->
                </div>
            </ItemTemplate>
        </asp:DataList>

    </div>
    <!-- //single -->
</asp:Content>
