<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="New_Consultorio.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.New_Consultorio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Consultorios
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
    Creacion de Nuevo Consultorio
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="container-fluid">
        <div class="form row">
            <div class="col-md-4 mb-3">
                <label for="validationCustom01">
                    Numero de Consultorio<span class="m-0 font-weight-bold text-danger">
							*</span></label>
                <input type="text" id="clnt" name="clnt" autocomplete="off"
                    onkeyup="document.getElementById(this.id).value=document.getElementById(this.id).value.toUpperCase()"
                    class="form-control form-control-sm" />
            </div>
            <div class="col-md-4 mb-3">
                <label>Imagen</label>
                <asp:FileUpload ID="FileUpload1" runat="server" class="form-control form-control-sm" />
            </div>
        </div>
        <br />
    </div>
</asp:Content>
