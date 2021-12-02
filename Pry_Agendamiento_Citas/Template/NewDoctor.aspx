<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Site1.Master" AutoEventWireup="true" CodeBehind="NewDoctor.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.NewDoctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_titulo" runat="server">
    <h1 class="page-header">Registro Doctores</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="container-fluid">
        <div class="form row">
            <div class="col-md-4 mb-3">
                <label for="validationCustom01">
                    Apellidos y Nombres<span class="m-0 font-weight-bold text-danger">
							*</span></label>
                <input type="text" id="clnt" name="clnt" autocomplete="off"
                    onkeyup="document.getElementById(this.id).value=document.getElementById(this.id).value.toUpperCase()"
                    class="form-control form-control-sm" />
            </div>
            <div class="col-md-2 mb-3">
                <label for="validationCustom01">Fecha de Nacimiento<span class="m-0 font-weight-bold text-danger">*</span></label>
                <input type="date" id="txtFNac" name="txtFNac" class="form-control form-control-sm">
            </div>
            <div class="col-md-2 mb-3">
                <label for="validationCustom01">Cedula/RUC</label>
                <input type="text" maxlength="13" id="ced" name="ced" placeholder="1717171777001" autocomplete="off"
                    onkeypress="if (event.keyCode < 45 || event.keyCode > 57) event.returnValue = false;"
                    class="form-control form-control-sm" />
            </div>
            <div class="col-md-2 mb-3">
                <label for="validationCustom01">Celular/Telefono</label>
                <input type="text" maxlength="10" id="telf" name="telf" placeholder="0987654321" autocomplete="off"
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
            <div class="col-md-4 mb-3">
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

            <div class="col-md-4 mb-3">
                <label for="validationCustom01">Correo Electronico<span class="m-0 font-weight-bold text-danger">*</span></label>
                <input type="email" id="txtCorreo" name="txtCorreo" class="form-control form-control-sm">
            </div>
        </div>
        <br>
        <div class="form row">
            <div class="col-md-4 mb-3">
                <label>Imagen</label>
                <asp:FileUpload ID="FileUpload1" runat="server" class="form-control form-control-sm"/>
            </div>
        </div>
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
