<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Site1.Master" AutoEventWireup="true" CodeBehind="NewEspecialidad.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.NewEspecialidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_titulo" runat="server">
    <h1 class="page-header">Nueva Especialidad</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="container-fluid">
        <div class="form row">
            <div class="col-md-3 mb-3">
                <label>Especialidad</label>
                <asp:TextBox ID="TextBox1" runat="server" class="form-control form-control-sm"></asp:TextBox>
            </div>
            <div class="col-md-5 mb-3">
                <label>Descripcion Especialidad</label>
                <asp:TextBox ID="TextBox2" runat="server" class="form-control form-control-sm"></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3">
                <label>Edad Dirigida</label>
                <select name="slcDocs" id="slcDocs" class="form-control">
                    <option value="0" selected>Seleccione</option>
                    <option value="1">Toda Edad</option>
                    <option value="2">1 - 4 años</option>
                    <option value="3">5 - 11 años</option>
                    <option value="4">12 - 18 años</option>
                    <option value="5">19 - 22+ años</option>
                </select>
            </div>
        </div>
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
