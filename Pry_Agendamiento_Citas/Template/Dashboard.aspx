<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Dashboard
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="row">
        <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
            <div class="panel panel-teal panel-widget border-right">
                <div class="row no-padding">
                    <em class="fa fa-xl fa-shopping-cart color-blue"></em>
                    <div class="large">120</div>
                    <div class="text-muted">New Orders</div>
                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
            <div class="panel panel-blue panel-widget border-right">
                <div class="row no-padding">
                    <em class="fa fa-xl fa-comments color-orange"></em>
                    <div class="large">52</div>
                    <div class="text-muted">Comments</div>
                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
            <div class="panel panel-orange panel-widget border-right">
                <div class="row no-padding">
                    <em class="fa fa-xl fa-users color-teal"></em>
                    <div class="large">24</div>
                    <div class="text-muted">New Users</div>
                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
            <div class="panel panel-red panel-widget ">
                <div class="row no-padding">
                    <em class="fa fa-xl fa-search color-red"></em>
                    <div class="large">25.2k</div>
                    <div class="text-muted">Page Views</div>
                </div>
            </div>
        </div>
    </div>
    <!--/.row-->
    
</asp:Content>
