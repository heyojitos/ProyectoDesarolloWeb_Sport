<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="WebContacto.aspx.cs" Inherits="ProyectoDW.WebForms.Contacto.WebContacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/bootstrap.css") %>" type="text/css" media="all" />
    <link href="../../Content/css/style.css" rel="stylesheet" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/flexslider.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/jquery-ui.css") %>" type="text/css" media="all" />
    <link rel="Stylesheet" href="<%= ResolveUrl("~/Content/css/pignose.layerslider.css") %>" type="text/css" media="all" />
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script = "text/javascript" >
        function Agregado(msg) {
            Swal.fire({
                icon: 'success',
                title: msg
            })
        }
        function Error(msg) {
            Swal.fire({
                icon: 'error',
                title: msg
            })
        }
        function LlenarDatos(msg) {
            Swal.fire({
                icon: 'info',
                title: msg
            })
        }

    </script> 
    <!-- banner -->
    <div class="page-head">
        <div class="container">
            <h3>Contacto</h3>
        </div>
    </div>
    <!-- //banner -->
    <!-- contact -->
    <div class="contact">
        <div class="container">
            <div class="contact-grids">
                <div class="col-md-4 contact-grid text-center animated wow slideInLeft" data-wow-delay=".5s">
                    <div class="contact-grid1">
                        <i class="glyphicon glyphicon-map-marker" aria-hidden="true"></i>
                        <h4>Dirección</h4>
                        <p>Guatemala</p>
                    </div>
                </div>
                <div class="col-md-4 contact-grid text-center animated wow slideInUp" data-wow-delay=".5s">
                    <div class="contact-grid2">
                        <i class="glyphicon glyphicon-earphone" aria-hidden="true"></i>
                        <h4>Llámenos</h4>
                        <p></p>
                    </div>
                </div>
                <div class="col-md-4 contact-grid text-center animated wow slideInRight" data-wow-delay=".5s">
                    <div class="contact-grid3">
                        <i class="glyphicon glyphicon-envelope" aria-hidden="true"></i>
                        <h4>Email</h4>
                        <p>josorioe@miumg.edu.gt<span>amoratayaq@miumg.edu.gt</span><span>malonsoa@miumg.edu.gt</span></p>
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="map wow fadeInDown animated" data-wow-delay=".5s">
                <h3 class="tittle">Vista en el mapa</h3>
                <iframe src="https://www.google.com/maps/embed?pb=!1m10!1m8!1m3!1d2482.432383990807!2d0.028213999961443994!3d51.52362882484525!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2sin!4v1423469959819" frameborder="0" style="border: 0"></iframe>
            </div>
            <h3 class="tittle">Formulario de Contacto</h3>
            <form>
                <div class="contact-form2">
                    <input id="txtNombre" type="text" placeholder="Nombre" value="" onfocus="" onblur="" required="required" runat="server" />
                    <input id="txtEmail" type="email" placeholder="Email" value="" onfocus="" onblur="" required="required" runat="server"/>
                    <textarea id="txtMensaje" placeholder="Mensaje..." cols="20" rows="2" onfocus="" onblur="" required="required" runat="server"></textarea>
                    <asp:Button ID="btnEnviar2" runat="server" Text="Enviar" OnClick="btnEnviar2_Click"/>
                </div>
            </form>
        </div>
    </div>

    <!-- //contact -->
</asp:Content>
