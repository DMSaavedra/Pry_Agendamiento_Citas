<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="New_Paciente.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.New_Paciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
    Bienvenido: 
    <asp:Label ID="lbl_nombre" runat="server" Text="" Font-Italic="True"></asp:Label>
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
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container-fluid">
                <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Green"></asp:Label>
                <br />
                <br />
                <div class="form row">
                    <div class="col-md-4 mb-3">
                        <label for="validationCustom01">Apellidos y Nombres<span class="m-0 font-weight-bold text-danger">*</span></label>
                        <asp:TextBox ID="txt_Aps_Noms" runat="server" CssClass="form-control" onkeyup="document.getElementById(this.id).value=document.getElementById(this.id).value.toUpperCase()"></asp:TextBox>
<%--                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo es obligatorio" ControlToValidate="txt_Aps_Noms" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Edad<span class="m-0 font-weight-bold text-danger">*</span></label>
                        <asp:TextBox ID="txt_Edad" runat="server" CssClass="form-control" TextMode="Number">0</asp:TextBox>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Cedula/RUC</label>
                        <asp:TextBox ID="txt_cedula" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Celular/Telefono</label>
                        <asp:TextBox ID="txt_telef" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Usuario</label>
                        <asp:TextBox ID="txt_User" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <br>
                <div class="form row">
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Genero</label>
                        <asp:DropDownList ID="ddl_genero" runat="server" class="form-control">
                            <asp:ListItem>Selccione</asp:ListItem>
                            <asp:ListItem Value="M">MASCULINO</asp:ListItem>
                            <asp:ListItem Value="F">FEMENINO</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Grupo Sanguineo</label>
                        <asp:DropDownList ID="ddl_grup_sangre" runat="server" class="form-control">
                            <asp:ListItem>Selccione</asp:ListItem>
                            <asp:ListItem Value="1">O+</asp:ListItem>
                            <asp:ListItem Value="2">O-</asp:ListItem>
                            <asp:ListItem Value="3">AB+</asp:ListItem>
                            <asp:ListItem Value="3">AB-</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-5 mb-3">
                        <label>Correo Electronico<span class="m-0 font-weight-bold text-danger">*</span></label>
                        <asp:TextBox ID="txt_email" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                    </div>
                </div>
                <br>
                <asp:Button ID="btn_Save_Pac" runat="server" Text="Registrar" CssClass="btn btn-primary" Width="230px" OnClick="btn_Save_Pac_Click" />

                <asp:Button ID="btn_Modify_Pac" runat="server" Text="Modificar" CssClass="btn btn-warning" Width="230px" OnClick="btn_Modify_Pac_Click" Visible="false" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
