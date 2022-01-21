<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="New_Agendamiento.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.New_Agendamiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
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
        <div class="form row">
            <div class="col-md-6 mb-3">
                <label for="validationCustom01">
                    Fecha del Turno<span
                        class="m-0 font-weight-bold text-danger">*</span></label>

                <input type="date" id="txtFechaReg" name="txtFechaReg" class="form-control form-control-sm"
                    >
            </div>
            <div class="col-md-6 mb-3">
                <label for="validationCustom01">
                    Especialidad<span
                        class="m-0 font-weight-bold text-danger">*</span></label>
                <select name="slcEspec" id="slcEspec" class="form-control">
                    <option value="0" selected>Seleccione</option>
                    <option value="1">Medicina General</option>
                    <option value="2">Odontologia</option>
                    <option value="3">Cardiología</option>
                    <option value="4">Alergología</option>
                </select>
            </div>
        </div>
        <br>
        <div class="form row">
            <div class="col-md-3 mb-3">
                <label for="validationCustom01">
                    Doctor<span
                        class="m-0 font-weight-bold text-danger">*</span></label>
                <select name="slcDocs" id="slcDocs" class="form-control">
                    <option value="0" selected>Seleccione</option>
                    <option value="1">Enriquez H.</option>
                    <option value="2">Velasquez V.</option>
                    <option value="3">Mosquera L.</option>
                    <option value="4">Ayala K.</option>
                    <option value="5">Caza N.</option>
                </select>
            </div>
            <div class="col-md-3 mb-3">
                <label>Hora del Turno</label>
                <input type="time" name="" id="" class="form-control form-control-sm">
            </div>
        </div>
        <asp:Button ID="btn_enviar" runat="server" Text="Enviar Cita" />
        <br>
    </div>
</asp:Content>
