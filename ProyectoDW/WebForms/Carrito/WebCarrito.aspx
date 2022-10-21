<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebCarrito.aspx.cs" Inherits="ProyectoDW.WebForms.Carrito.WebCarrito" %>

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
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>

    <script = "text/javascript" >
        function MostrarPopUp() {
            dxPopUpProducto.Show();
            //dxPopUpLogin.Show();
        }

        function MostrarCardIn() {
            dxPopUpProducto.Show();
        }

        function EmailNotFound() {
            swal("Correo no encontrado!");
        }
        function Agregado(msg) {
            Swal.fire({
                icon: 'success',
                title: msg
            })
        }
        function Usuario(msg) {
            Swal.fire({
                icon: 'warning',
                title: msg
            })
        }
    </script> 

    <!-- check out -->
    <div class="checkout">
        <div class="container">
            <h3>Mi Carrito</h3>
            <h4>Cambio Dolar a Quetzal:</h4>
            <h4>
                <asp:Label ID="idCambioDolar" runat="server" Text=""></asp:Label></h4>
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
                        <li>Total: <i>-</i> <span><asp:Label ID="idTotal" runat="server" Text=""></asp:Label></span></li>
                        <li>Total USD: <i>-</i> <span><asp:Label ID="idTotalUSD" runat="server" Text=""></asp:Label></span></li>
                    </ul>
                </div>
                <div class="contact-form2">
                    <asp:Button ID="BtnComprar" runat="server" Text="Comprar" OnClientClick="MostrarPopUp(); return false;" />
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!-- //check out -->
    <!-- //product-nav -->    

    <dx:ASPxPopupControl ID="dxPopUpProducto" runat="server" AllowDragging="True" ClientInstanceName="dxPopUpProducto" CloseAction="CloseButton" EnableViewState="False" Modal="true"
        Height="0px" PopupAnimationType="Slide" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" Width="0px" HeaderText="Pago Tarjeta">
        <SettingsAdaptivity Mode="Always" VerticalAlign="WindowCenter" MaxWidth="700px" />
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
                <div class="padding">
                    <div class="row">
                        <div class="col-sm-6">
                            <h2>Datos de envio</h2>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblDireccion" runat="server" Text="Direccion" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label ID="lblContacto" runat="server" Text="Contacto" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtContacto" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label ID="lblTelefono" runat="server" Text="Telefono" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />                    
                </div>
                <div class="padding">
                    <div class="row">
                        <div class="col-sm-6">
                            <div class="card">
                                <div class="card-header">
                                    <strong>Tarjeta de Credito</strong>
                                    <small>Ingrese los detalles de su tarjeta</small>
                                </div>
                                <br />
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <label for="name">Nombre</label>
                                                <input class="form-control" id="name" type="text" placeholder="Ingrese nombre registrado">
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <label for="ccnumber">Numero de tarjeta</label>
                                                <div class="input-group">
                                                    <input class="form-control" type="text" placeholder="0000 0000 0000 0000" autocomplete="email">
                                                    <div class="input-group-append">
                                                        <span class="input-group-text">
                                                            <i class="mdi mdi-credit-card"></i>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="form-group col-sm-4">
                                            <label for="ccmonth">Mes</label>
                                            <select class="form-control" id="ccmonth">
                                                <option>1</option>
                                                <option>2</option>
                                                <option>3</option>
                                                <option>4</option>
                                                <option>5</option>
                                                <option>6</option>
                                                <option>7</option>
                                                <option>8</option>
                                                <option>9</option>
                                                <option>10</option>
                                                <option>11</option>
                                                <option>12</option>
                                            </select>
                                        </div>
                                        <div class="form-group col-sm-4">
                                            <label for="ccyear">Año</label>
                                            <select class="form-control" id="ccyear">
                                                <option>2023</option>
                                                <option>2024</option>
                                                <option>2025</option>
                                                <option>2026</option>
                                            </select>
                                        </div>
                                        <div class="col-sm-4">
                                            <div class="form-group">
                                                <label for="cvv">CVV/CVC</label>
                                                <input class="form-control" id="cvv" type="text" placeholder="123">
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div class="card-footer">
                                    <%--<button class="btn btn-sm btn-success float-right" type="submit">
                                        <i class="mdi mdi-gamepad-circle"></i>Continuar</button>--%>
                                    <dx:ASPxButton ID="dxBtnContinuar" 
                                        runat="server" 
                                        Text="Continuar" 
                                        AutoPostBack="false" 
                                        Font-Bold="true" 
                                        Font-Size="Medium" 
                                        OnClick="btnContinuar_Click" 
                                        UseSubmitBehavior="false">
                                        <ClientSideEvents Click="function(s, e) { dxPopUpProducto.Hide(); }" /> 
                                    </dx:ASPxButton>
                                    <button class="btn btn-sm btn-danger" type="reset">
                                        <i class="mdi mdi-lock-reset"></i>Resetear</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
</asp:Content>
