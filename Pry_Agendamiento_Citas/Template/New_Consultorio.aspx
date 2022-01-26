<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="New_Consultorio.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.New_Consultorio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
    Bienvenido: 
    <asp:Label ID="lbl_nombre" runat="server" Text="" Font-Italic="True"></asp:Label>
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
        <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Green"></asp:Label>
        <div class="form row">
            <div class="col-md-4 mb-3">
                <label for="validationCustom01">Número Consultorio<span class="m-0 font-weight-bold text-danger">*</span></label>
                <asp:TextBox ID="txt_numconsul" runat="server" CssClass="form-control" MaxLength="3" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;"></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3">
                <label>Imagen</label>
                <asp:FileUpload ID="ful_imagen" runat="server" class="form-control form-control-sm" />
            </div>
        </div>
        <br />
        <asp:Button ID="btn_Save_Consul" runat="server" Text="Registrar" CssClass="btn btn-primary" Width="230px" OnClick="btn_Save_Consul_Click" />

        <asp:Button ID="btn_Modify_Consul" runat="server" Text="Modificar" CssClass="btn btn-warning" Width="230px" OnClick="btn_Modify_Consul_Click" Visible="false" />
    </div>
</asp:Content>
