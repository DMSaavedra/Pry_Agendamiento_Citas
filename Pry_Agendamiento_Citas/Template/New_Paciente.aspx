<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="New_Paciente.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.New_Paciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Pacientes
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
    Creacion de Nuevo Paciente
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="container-fluid">
        <div class="form row">
            <div class="col-md-4 mb-3">
                <label for="validationCustom01">Apellidos y Nombres<span class="m-0 font-weight-bold text-danger">*</span></label>
                <input type="text" id="clnt" name="clnt" autocomplete="off"
                    onkeyup="document.getElementById(this.id).value=document.getElementById(this.id).value.toUpperCase()"
                    class="form-control form-control-sm" />
            </div>
            <div class="col-md-2 mb-3">
                <label for="validationCustom01">Edad<span class="m-0 font-weight-bold text-danger">*</span></label>
                <input type="text" id="txtEdad" name="txtEdad" class="form-control form-control-sm" />
            </div>
            <div class="col-md-2 mb-3">
                <label for="validationCustom01">Cedula/RUC</label>
                <input type="text" maxlength="13" id="ced" name="ced" placeholder="1717171777001"
                    autocomplete="off"
                    onkeypress="if (event.keyCode < 45 || event.keyCode > 57) event.returnValue = false;"
                    class="form-control form-control-sm" />
            </div>
            <div class="col-md-2 mb-3">
                <label for="validationCustom01">Celular/Telefono</label>
                <input type="text" maxlength="10" id="telf" name="telf" placeholder="0987654321"
                    autocomplete="off"
                    onkeypress="if (event.keyCode < 45 || event.keyCode > 57) event.returnValue = false;"
                    class="form-control form-control-sm" />
            </div>
            <div class="col-md-2 mb-3">
                <label for="validationCustom01">Genero</label>
                <select name="slcGenero" id="slcGenero" class="form-control">
                    <option value="0" selected>Seleccione</option>
                    <option value="M">Masculino</option>
                    <option value="F">Femenino</option>
                </select>
            </div>
        </div>
        <br>
        <div class="form row">
            <div class="col-md-2 mb-3">
                <label for="validationCustom01">Grupo Sanguineo</label>
                <select name="slcTpSangre" id="slcTpSangre" class="form-control">
                    <option value="0" selected>Seleccione</option>
                    <option value="1">O+</option>
                    <option value="2">O-</option>
                    <option value="3">AB+</option>
                    <option value="4">AB-</option>
                </select>
            </div>
            <div class="col-md-5 mb-3">
                <label>Correo Electronico<span class="m-0 font-weight-bold text-danger">*</span></label>
                <input type="email" name="txtCorreo" id="txtCorreo" class="form-control form-control-sm">
            </div>
            
        </div>
        <br>
    </div>
</asp:Content>
