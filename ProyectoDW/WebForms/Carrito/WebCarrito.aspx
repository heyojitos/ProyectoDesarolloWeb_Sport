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
                <asp:GridView ID="gridCarrito" runat="server" CssClass="timetable_sub" AutoGenerateColumns="False" ShowFooter="True" EnableCallBacks="false">
                    <Columns>
                        <asp:TemplateField HeaderText="Eliminar" ItemStyle-CssClass="">
                            <ItemTemplate>
                                <asp:ImageButton ID="eliminarID_DETALLE" runat="server" ImageUrl="~/Content/Images/close_1.png" OnClick="eliminarID_DETALLE_Click" CssClass=""/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ID_DETALLE_REGISTRO" HeaderText="N° Registro" ReadOnly="true"/>
                        <asp:BoundField DataField="ID_PRODUCTO" HeaderText="Codigo_Producto" ReadOnly="true"/>        
                        <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" ReadOnly="true"/>
                        <asp:TemplateField HeaderText="Imagen">
                            <ItemTemplate>
                                <img src="../../<%# Eval("IMAGEN") %>" class="img-responsive" width="150px" height="150px"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="PRECIO" HeaderText="Precio" ReadOnly="true" DataFormatString="{0:c}"/>
                        <asp:TemplateField HeaderText="Cantidad">
                            <ItemTemplate>
                                <asp:TextBox ID="txtCantidad" runat="server" Text='<%# Eval("CANTIDAD") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="SUBTOTAL" HeaderText="SubTotal" DataFormatString="{0:c}" ReadOnly="true"/>
                    </Columns>
                </asp:GridView>
            </div>
            <div class="checkout-left">

                <div class="checkout-right-basket animated wow slideInRight" data-wow-delay=".5s">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForms/Productos/Hombre/WebHombre.aspx"><span class="glyphicon glyphicon-menu-left" aria-hidden="true"></span>Regresar a comprar</asp:HyperLink>
                </div>



                <div class="checkout-left-basket animated wow slideInLeft" data-wow-delay=".5s">
                    <h4>Total</h4>
                    <ul>
                        <li>Subtotal: <i>-</i><asp:Label ID="idSubtotal" runat="server" Text=""></asp:Label><span></span></li>
                        <li>Envio: <i>-</i> <span><asp:Label ID="idEnvio" runat="server" Text=""></asp:Label></span></li>
                        <li>Total: <i>-</i> <span><asp:Label ID="idTotal" runat="server" Text=""></asp:Label></span></li>
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
