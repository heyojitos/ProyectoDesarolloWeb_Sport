<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebInicio.aspx.cs" Inherits="ProyectoDW.WebForms.Inicio.WebInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/bootstrap.css") %>" type="text/css" media="all" />
    <link href="../../Content/css/style.css" rel="stylesheet" type="text/css"/>
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/flexslider.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/jquery-ui.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/pignose.layerslider.css") %>" type="text/css" media="all" />
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery-2.1.4.min.jss") %>"></script>
    <script type="text/javascript" src="../../Content/js/jquery.easing.min.js"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src='http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js'></script>
    <script src='http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.5/jquery-ui.min.js'></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.min.js"></script>

    <!-- banner -->
    <div class="banner-grid">
        <div id="visual">
            <div class="slide-visual">
                <!-- Slide Image Area (1000 x 424) -->
                <ul class="slide-group">
                    <li>
                        <img class="img-responsive" src="../../Content/Images/slider1_1.jpg" alt="Dummy Image" /></li>
                    <li>
                        <img class="img-responsive" src="../../Content/Images/slider2_1.jpg" alt="Dummy Image" /></li>
                    <li>
                        <img class="img-responsive" src="../../Content/Images/slider3_1.jpg" alt="Dummy Image" /></li>
                </ul>

                <!-- Slide Description Image Area (276 x 286) -->
                <div class="script-wrap">
                    <ul class="script-group">
                        <li>
                            <div class="inner-script">
                                <img class="img-responsive" src="../../Content/Images/mini_slider1_1.jpg" alt="Dummy Image" />
                            </div>
                        </li>
                        <li>
                            <div class="inner-script">
                                <img class="img-responsive" src="../../Content/Images/mini_slider2_1.jpg" alt="Dummy Image" />
                            </div>
                        </li>
                        <li>
                            <div class="inner-script">
                                <img class="img-responsive" src="../../Content/Images/mini_slider3_1.jpg" alt="Dummy Image" />
                            </div>
                        </li>
                    </ul>
                    <div class="slide-controller">
                        <a href="#" class="btn-prev">
                            <img src="../../Content/Images/btn_prev.png" alt="Prev Slide" /></a>
                        <a href="#" class="btn-play">
                            <img src="../../Content/Images/btn_play.png" alt="Start Slide" /></a>
                        <a href="#" class="btn-pause">
                            <img src="../../Content/Images/btn_pause.png" alt="Pause Slide" /></a>
                        <a href="#" class="btn-next">
                            <img src="../../Content/Images/btn_next.png" alt="Next Slide" /></a>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="clearfix"></div>
        </div>
        <script type="text/javascript" src="../../Content/js/pignose.layerslider.js"></script>
        <script type="text/javascript">
            //<![CDATA[
            $(window).load(function () {
                $('#visual').pignoseLayerSlider({
                    play: '.btn-play',
                    pause: '.btn-pause',
                    next: '.btn-next',
                    prev: '.btn-prev'
                });
            });
	//]]>
        </script>

    </div>
    <!-- //banner -->
    <!-- content -->

    <div class="new_arrivals">
        <div class="container">
            <h3><span>Nuevos </span>Productos</h3>
            <p>Aproveche nuestros nuevos lanzamientos por cambio de temporada</p>
            <div class="new_grids">
                <div class="col-md-4 new-gd-left">
                    <img src="../../Content/Images/front4_1.jpg" alt="" />
                    <div class="wed-brand simpleCart_shelfItem">
                        <h4>Coleccion deportiva</h4>
                        <h5>Mujer</h5>
                    </div>
                </div>
                <div class="col-md-4 new-gd-middle">
                    <div class="new-levis">
                        <div class="mid-img">
                            <img src="../../Content/Images/nike.png" />
                        </div>
                        <div class="mid-text">
                            <h4><span>Catalogo de hombre</span></h4>
                            <a class="hvr-outline-out button2" href="../Productos/Hombre/WebHombre.aspx">Más Info</a>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="new-levis">
                        <div class="mid-text">
                            <h4><span>Catalogo de mujer</span></h4>
                            <a class="hvr-outline-out button2" href="../Productos/Mujer/WebMujer.aspx">Más Info</a>
                        </div>
                        <div class="mid-img">
                            <img src="../../Content/Images/adidas.png" />
                        </div>
                        <div class="clearfix"></div>
                    </div>
                    <div class="clearfix"></div>
                </div>
                <div class="col-md-4 new-gd-left">
                    <img src="../../Content/Images/front3_1.jpg" alt="" />
                    <div class="wed-brandtwo simpleCart_shelfItem">
                        <h4>Coleccion deportiva</h4>
                        <p>Hombre</p>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //content -->

    <!-- content-bottom -->

    <div class="content-bottom">
        <div class="col-md-7 content-lgrid">
            <div class="col-sm-6 content-img-left text-center">
                <div class="content-grid-effect slow-zoom vertical">
                    <div class="img-box">
                        <img src="../../Content/Images/p1_1.jpg" alt="image" class="img-responsive zoom-img">
                    </div>
                    <div class="info-box">
                        <div class="info-content simpleCart_shelfItem">
                            <h4>Calzado Mujer</h4>
                            <span class="separator"></span>
                            <p><span class="item_price">Desde Q.500</span></p>
                            <span class="separator"></span>
                            <a class="item_add hvr-outline-out button2" href="../Productos/Mujer/WebMujerCalzado.aspx">Más Info</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-6 content-img-right">
                <h3>Ofertas especiales<span>Ropa y Calzado</span> Fin de temporada</h3>
            </div>

            <div class="col-sm-6 content-img-right">
                <h3>Adquiere tus productos<span>Últimos Dias</span> Deportivos en tiendas</h3>
            </div>
            <div class="col-sm-6 content-img-left text-center">
                <div class="content-grid-effect slow-zoom vertical">
                    <div class="img-box">
                        <img src="../../Content/Images/p2_1.jpg" alt="image" class="img-responsive zoom-img">
                    </div>
                    <div class="info-box">
                        <div class="info-content simpleCart_shelfItem">
                            <h4>Training Kit</h4>
                            <span class="separator"></span>
                            <p><span class="item_price">Desde Q.400</span></p>
                            <span class="separator"></span>
                            <a class="item_add hvr-outline-out button2" href="../Productos/Deporte/WebDeporteTraining.aspx">Más Info</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="col-md-5 content-rgrid text-center">
            <div class="content-grid-effect slow-zoom vertical">
                <div class="img-box">
                    <img src="../../Content/Images/p4_1.jpg" alt="image" class="img-responsive zoom-img">
                </div>
                <div class="info-box">
                    <div class="info-content simpleCart_shelfItem">
                        <h4>Ropa Hombre</h4>
                        <span class="separator"></span>
                        <p><span class="item_price">Desde Q.300</span></p>
                        <span class="separator"></span>
                        <a class="item_add hvr-outline-out button2" href="../Productos/Hombre/WebHombreRopa.aspx">Más Info</a>
                    </div>
                </div>
            </div>
        </div>
        <div class="clearfix"></div>
    </div>
    <!-- //content-bottom -->  

</asp:Content>
