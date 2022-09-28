<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebCarrito.aspx.cs" Inherits="ProyectoDW.WebForms.Carrito.WebCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/bootstrap.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/style.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/jquery-ui.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/pignose.layerslider.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="//fonts.googleapis.com/css?family=Montserrat:400,700" type="text/css" media="all" />
    <link rel="Stylesheet" href="//fonts.googleapis.com/css?family=Lato:400,100,100italic,300,300italic,400italic,700,900,900italic,700italic" type="text/css" media="all" />
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery-2.1.4.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/imagezoom.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.flexslider.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/simpleCart.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/bootstrap-3.1.1.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.easing.min.js") %>"></script>

    <!-- check out -->
    <div class="checkout">
        <div class="container">
            <h3>Mi Carrito</h3>
            <div class="table-responsive checkout-right animated wow slideInUp" data-wow-delay=".5s">
                <table class="timetable_sub">
                    <thead>
                        <tr>
                            <th>Eliminar</th>
                            <th>Producto</th>
                            <th>Cantidad</th>
                            <th>Nombre Producto</th>
                            <th>Precio</th>
                        </tr>
                    </thead>
                    <tr class="rem1">
                        <td class="invert-closeb">
                            <div class="rem">
                                <div class="close1"></div>
                            </div>
                            <script ="text/javascript">$(document).ready(function (c) {
                                    $('.close1').on('click', function (c) {
                                        $('.rem1').fadeOut('slow', function (c) {
                                            $('.rem1').remove();
                                        });
                                    });
                                });
                            </script>
                        </td>
                        <td class="invert-image"><a href="#">
                            <img src="images/w4.png" alt=" " class="img-responsive" /></a></td>
                        <td class="invert">
                            <div class="quantity">
                                <div class="quantity-select">
                                    <div class="entry value-minus">&nbsp;</div>
                                    <div class="entry value"><span>1</span></div>
                                    <div class="entry value-plus active">&nbsp;</div>
                                </div>
                            </div>
                        </td>
                        <td class="invert">Hand Bag</td>
                        <td class="invert">$45.99</td>
                    </tr>
                    <tr class="rem2">
                        <td class="invert-closeb">
                            <div class="rem">
                                <div class="close2"></div>
                            </div>
                            <script ="text/javascript">$(document).ready(function (c) {
                                    $('.close2').on('click', function (c) {
                                        $('.rem2').fadeOut('slow', function (c) {
                                            $('.rem2').remove();
                                        });
                                    });
                                });
                            </script>
                        </td>
                        <td class="invert-image"><a href="#">
                            <img src="images/ep3.png" alt=" " class="img-responsive" /></a></td>
                        <td class="invert">
                            <div class="quantity">
                                <div class="quantity-select">
                                    <div class="entry value-minus">&nbsp;</div>
                                    <div class="entry value"><span>1</span></div>
                                    <div class="entry value-plus active">&nbsp;</div>
                                </div>
                            </div>
                        </td>
                        <td class="invert">Watches</td>
                        <td class="invert">$45.99</td>

                    </tr>
                    <tr class="rem3">
                        <td class="invert-closeb">
                            <div class="rem">
                                <div class="close3"></div>
                            </div>
                            <script ="text/javascript">$(document).ready(function (c) {
                                    $('.close3').on('click', function (c) {
                                        $('.rem3').fadeOut('slow', function (c) {
                                            $('.rem3').remove();
                                        });
                                    });
                                });
                            </script>
                        </td>
                        <td class="invert-image"><a href="#">
                            <img src="images/w2.png" alt=" " class="img-responsive" /></a></td>
                        <td class="invert">
                            <div class="quantity">
                                <div class="quantity-select">
                                    <div class="entry value-minus">&nbsp;</div>
                                    <div class="entry value"><span>1</span></div>
                                    <div class="entry value-plus active">&nbsp;</div>
                                </div>
                            </div>
                        </td>
                        <td class="invert">Sandals</td>
                        <td class="invert">$45.99</td>

                    </tr>
                    <tr class="rem4">
                        <td class="invert-closeb">
                            <div class="rem">
                                <div class="close4"></div>
                            </div>
                            <script ="text/javascript">$(document).ready(function (c) {
                                    $('.close4').on('click', function (c) {
                                        $('.rem4').fadeOut('slow', function (c) {
                                            $('.rem4').remove();
                                        });
                                    });
                                });
                            </script>
                        </td>
                        <td class="invert-image"><a href="#">
                            <img src="images/w1.png" alt=" " class="img-responsive" /></a></td>
                        <td class="invert">
                            <div class="quantity">
                                <div class="quantity-select">
                                    <div class="entry value-minus">&nbsp;</div>
                                    <div class="entry value"><span>1</span></div>
                                    <div class="entry value-plus active">&nbsp;</div>
                                </div>
                            </div>
                        </td>
                        <td class="invert">Wedges</td>
                        <td class="invert">$45.99</td>

                    </tr>

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
                </table>
            </div>
            <div class="checkout-left">

                <div class="checkout-right-basket animated wow slideInRight" data-wow-delay=".5s">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForms/Productos/Hombre/WebHombre.aspx"><span class="glyphicon glyphicon-menu-left" aria-hidden="true"></span>Regresar a comprar</asp:HyperLink>                    
                </div>

                
                
                <div class="checkout-left-basket animated wow slideInLeft" data-wow-delay=".5s">
                    <h4>Resumen del pedido</h4>
                    <ul>
                        <li>Hand Bag <i>-</i> <span>$45.99</span></li>
                        <li>Watches <i>-</i> <span>$45.99</span></li>
                        <li>Sandals <i>-</i> <span>$45.99</span></li>
                        <li>Wedges <i>-</i> <span>$45.99</span></li>
                        <li>Total <i>-</i> <span>$183.96</span></li>
                    </ul>
                                       
                </div>
                <div class="contact-form2">                        
                    <asp:Button ID="BtnComprar" runat="server" Text="Comprar" />
                    </div> 
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //check out -->
    <!-- //product-nav -->
</asp:Content>
