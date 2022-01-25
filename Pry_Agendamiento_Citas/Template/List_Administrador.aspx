<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="List_Administrador.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.List_Administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
    Bienvenido: 
    <asp:Label ID="lbl_nombre" runat="server" Text="" Font-Italic="True"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Administradores
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
    Listado de Administradores
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <contenttemplate>
            <div class="container-fluid">
                <asp:GridView ID="grv_adminis" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="False" OnRowCommand="grv_adminis_RowCommand">
                    <columns>
                        <asp:TemplateField HeaderText="" ItemStyle-Width="1cm">
                            <itemtemplate>
                                <asp:ImageButton ID="img_eliminar" runat="server" ImageUrl="~/Template/Assets/imagenes/eliminar.gif" CommandArgument='<%#Eval("usu_id") %>' CommandName="Eliminar" OnClientClick="return confirm('Esta Seguro de Eliminar el Registro?')" />
                            </itemtemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID" ItemStyle-Width="1cm">
                            <itemtemplate>
                                <asp:Label ID="usu_id" runat="server" Text='<%#Eval("usu_id") %>'></asp:Label>
                            </itemtemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="APELLIDOS Y NOMBRES" ItemStyle-Width="5cm">
                            <itemtemplate>
                                <asp:Label ID="usu_apellido_nombre" runat="server" Text='<%#Eval("usu_apellido_nombre") %>'></asp:Label>
                            </itemtemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CEDULA" ItemStyle-Width="2cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_cedula" runat="server" Text='<%#Eval("usu_cedula") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="EMAIL" ItemStyle-Width="5cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_correo" runat="server" Text='<%#Eval("usu_correo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </columns>
                </asp:GridView>
            </div>
        </contenttemplate>
    </asp:UpdatePanel>
</asp:Content>
