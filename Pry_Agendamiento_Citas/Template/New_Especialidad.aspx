<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="New_Especialidad.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.New_Especialidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
    Bienvenido: 
    <asp:Label ID="lbl_nombre" runat="server" Text="" Font-Italic="True"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Especialidades
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
    Creacion de Nueva Especialidad
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="container-fluid">
         <asp:Label ID="lbl_mensaje" runat="server" Text="" ForeColor="Green"></asp:Label>
        <br />
        <br />
        <div class="form row">
            <div class="col-md-3 mb-3">
                <label>Especialidad</label>
                <asp:TextBox ID="txt_especialidad" runat="server" class="form-control form-control-sm"></asp:TextBox>
            </div>
            <div class="col-md-5 mb-3">
                <label>Descripcion Especialidad</label>
                <asp:TextBox ID="txt_despecialidad" runat="server" class="form-control form-control-sm"></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3">
                <label>Edad Dirigida</label>
                 <asp:DropDownList ID="ddl_edad" runat="server" class="form-control">
                            <asp:ListItem>Seleccione</asp:ListItem>
                            <asp:ListItem Value="1">Toda Edad</asp:ListItem>
                            <asp:ListItem Value="2">1 - 4 años</asp:ListItem>
                            <asp:ListItem Value="3">5 - 11 años</asp:ListItem>
                            <asp:ListItem Value="4">12 - 18 años</asp:ListItem>
                            <asp:ListItem Value="5">19 - 22+ años</asp:ListItem>
                        </asp:DropDownList>
            </div>
        </div>
        <br>
        <asp:Button ID="btn_Save_Pac" runat="server" Text="Registrar" CssClass="btn btn-primary" Width="230px" OnClick="btn_Save_Pac_Click" />
                
        <asp:Button ID="btn_Modify_Pac" runat="server" Text="Modificar" CssClass="btn btn-warning" Width="230px" OnClick="btn_Modify_Pac_Click" Visible="false"/>

        <br />
    </div>
</asp:Content>
