﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebCarrito.aspx.cs" Inherits="ProyectoDW.WebForms.Carrito.WebCarrito" %>

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

    <!-- check out -->
    <div class="checkout">
        <div class="container">
            <h3>Mi Carrito</h3>
            <h4>Cambio Dolar a Quetzal:</h4>
            <h4><asp:Label ID="idCambioDolar" runat="server" Text=""></asp:Label></h4>
            <div class="table-responsive checkout-right animated wow slideInUp" data-wow-delay=".5s">
                <asp:GridView ID="gridCarrito" runat="server" CssClass="timetable_sub" AutoGenerateColumns="False" ShowFooter="false" EnableCallBacks="false" OnRowDeleting="gridCarrito_RowDeleting">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="true" ButtonType="Image" DeleteImageUrl="~/Content/Images/close_1.png" />
                        <asp:BoundField DataField="ID_DETALLE_REGISTRO" HeaderText="N° Registro" ReadOnly="true" />
                        <asp:BoundField DataField="ID_PRODUCTO" HeaderText="Codigo_Producto" ReadOnly="true" Visible="false" />
                        <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" ReadOnly="true" />
                        <asp:TemplateField HeaderText="Imagen">
                            <ItemTemplate>
                                <img src="../../<%# Eval("IMAGEN") %>" class="img-responsive" width="140px" height="140px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="PRECIO" HeaderText="Precio" ReadOnly="true" DataFormatString="{0:c}" />
                        <asp:TemplateField HeaderText="Cantidad">
                            <ItemTemplate>
                                <asp:TextBox ID="txtCantidad" runat="server" Text='<%# Eval("CANTIDAD") %>' AutoPostBack="true" OnTextChanged="txtCantidad_TextChanged"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="SUBTOTAL" HeaderText="SubTotal" DataFormatString="{0:c}" ReadOnly="true" />
                    </Columns>
                </asp:GridView>
            </div>

            <div class="checkout-left">
                <div class="checkout-right-basket animated wow slideInRight" data-wow-delay=".5s">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForms/Productos/Hombre/WebHombre.aspx"><span class="glyphicon glyphicon-menu-left" aria-hidden="true"></span>Regresar a comprar</asp:HyperLink>
                </div>

                <div class="checkout-left-basket animated wow slideInLeft" data-wow-delay=".5s">
                    <h4>Resumen</h4>
                    <ul>
                        <li>Total: <i>-</i> <span>
                            <asp:Label ID="idTotal" runat="server" Text=""></asp:Label></span></li>
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
