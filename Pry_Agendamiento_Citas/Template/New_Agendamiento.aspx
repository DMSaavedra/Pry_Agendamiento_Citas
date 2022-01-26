<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="New_Agendamiento.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.New_Agendamiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
    Bienvenido: 
    <asp:Label ID="lbl_nombre" runat="server" Text="" Font-Italic="True"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Agendamiento
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
    Nuevo Agendamiento de Cita Medica
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="container-fluid">
        <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Green"></asp:Label>
        <div class="form row">
            <div class="col-md-3 mb-3">
                <label for="validationCustom01">
                    Paciente
                    <span class="m-0 font-weight-bold text-danger">*</span></label>
                <asp:DropDownList ID="ddl_pacientes" runat="server" CssClass="form-control" Style="height: 1.2cm;"></asp:DropDownList>
            </div>
            <div class="col-md-3 mb-3">
                <label for="validationCustom01">
                    Doctor<span
                        class="m-0 font-weight-bold text-danger">*</span></label>
                <asp:DropDownList ID="ddl_nom_doc" runat="server" class="form-control" Style="height: 1.2cm;">
                </asp:DropDownList>
            </div>
            <div class="col-md-3 mb-3">
                <label for="validationCustom01">
                    Fecha del Turno<span
                        class="m-0 font-weight-bold text-danger">*</span></label>
                <asp:TextBox ID="txt_fechaRT" runat="server" TextMode="Date" CssClass="form-control" ></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3">
                <label>Hora del Turno</label>
                <asp:TextBox ID="txt_horaRT" runat="server" CssClass="form-control" TextMode="Time"></asp:TextBox>
            </div>

        </div>
        <br>
        <div class="form row">
            <div class="col-md-3 mb-3">
                <label for="validationCustom01">
                    Especialidad<span
                        class="m-0 font-weight-bold text-danger">*</span></label>
                <asp:DropDownList ID="ddl_Especialidad" runat="server" class="form-control" Style="height: 1.2cm;">
                </asp:DropDownList>
            </div>
            

        </div>
        <br />
        <br />
        <asp:Button ID="btn_Save_Agen" runat="server" Text="Registrar" CssClass="btn btn-primary" Width="230px" OnClick="btn_Save_Agen_Click" />

        <asp:Button ID="btn_Modify_Agen" runat="server" Text="Modificar" CssClass="btn btn-warning" Width="230px" OnClick="btn_Modify_Agen_Click" Visible="false" />

        <asp:Button ID="btn_enviarc" runat="server" Text="Enviar Cita" CssClass="btn btn-primary" Width="230px" OnClick="btn_enviarc_Click" />
        <br>
    </div>
</asp:Content>
