<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="New_Doctor.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.New_Doctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
    Bienvenido: 
    <asp:Label ID="lbl_nombre" runat="server" Text="" Font-Italic="True"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Doctores
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
    Creacion de Nuevo Doctor
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
                        <asp:TextBox ID="txt_Aps_Noms" runat="server" CssClass="form-control" onKeypress="if ((event.keyCode != 32) && (event.keyCode < 65) || (event.keyCode > 90) && (event.keyCode < 97) || (event.keyCode > 122)) event.returnValue = false;" onkeyup="document.getElementById(this.id).value=document.getElementById(this.id).value.toUpperCase()"></asp:TextBox>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Edad<span class="m-0 font-weight-bold text-danger">*</span></label>
                        <asp:TextBox ID="txt_Edad" runat="server" CssClass="form-control" MaxLength="2" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;"></asp:TextBox>
                    </div>
                    <div class="col-md-4 mb-3">
                        <label for="validationCustom01">Cedula</label>
                        <asp:TextBox ID="txt_cedula" runat="server" CssClass="form-control" MaxLength="10" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;"></asp:TextBox>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Celular/Telefono</label>
                        <asp:TextBox ID="txt_telef" runat="server" CssClass="form-control" MaxLength="10" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;"></asp:TextBox>
                    </div>
                </div>
                <br>
                <div class="form row">
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Usuario</label>
                        <asp:TextBox ID="txt_User" runat="server" CssClass="form-control" MaxLength="10" onKeypress="if ((event.keyCode != 32) && (event.keyCode < 65) || (event.keyCode > 90) && (event.keyCode < 97) || (event.keyCode > 122)) event.returnValue = false;"></asp:TextBox>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Contraseña</label>
                        <asp:TextBox ID="txt_passw" runat="server" CssClass="form-control" MaxLength="6" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;"></asp:TextBox>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Genero</label>
                        <asp:DropDownList ID="ddl_genero" runat="server" class="form-control" style="height: 1.2cm;">
                            <asp:ListItem Value="0">Selccione</asp:ListItem>
                            <asp:ListItem Value="M">MASCULINO</asp:ListItem>
                            <asp:ListItem Value="F">FEMENINO</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 mb-3">
                        <label for="validationCustom01">Grupo Sanguineo</label>
                        <asp:DropDownList ID="ddl_grup_sangre" runat="server" class="form-control" style="height: 1.2cm;">
                            <asp:ListItem Value="0">Selccione</asp:ListItem>
                            <asp:ListItem Value="1">O+</asp:ListItem>
                            <asp:ListItem Value="2">O-</asp:ListItem>
                            <asp:ListItem Value="3">AB+</asp:ListItem>
                            <asp:ListItem Value="3">AB-</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-4 mb-3">
                        <label>Correo Electronico<span class="m-0 font-weight-bold text-danger">*</span></label>
                        <asp:TextBox ID="txt_email" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="col-md-3 mb-3">
                        <label>Especialidad<span class="m-0 font-weight-bold text-danger">*</span></label>
                        <asp:DropDownList ID="ddl_especialidad" runat="server" CssClass="form-control" style="height: 1.2cm;"></asp:DropDownList>
                    </div>
                </div>
                <br>
                <asp:Button ID="btn_Save_Med" runat="server" Text="Registrar" CssClass="btn btn-primary" Width="230px" OnClick="btn_Save_Med_Click" />

                <asp:Button ID="btn_Modify_Med" runat="server" Text="Modificar" CssClass="btn btn-warning" Width="230px" OnClick="btn_Modify_Med_Click" Visible="false" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
