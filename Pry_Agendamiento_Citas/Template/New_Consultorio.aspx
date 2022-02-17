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
                <asp:FileUpload ID="ful_imagen" accept=".jpg" runat="server" CssClass="form-control form-control-sm" />
            </div>
        </div>
        <br />
        <asp:Button ID="btn_Save_Consul" runat="server" Text="Registrar" CssClass="btn btn-primary" Width="230px" OnClick="btn_Save_Consul_Click" />

        <asp:Button ID="btn_Modify_Consul" runat="server" Text="Modificar" CssClass="btn btn-warning" Width="230px" OnClick="btn_Modify_Consul_Click" Visible="false" />
    </div>
    <br />
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    Listado de Imagenes de Consultorios
                </div>
                <div class="panel-body">
                    <div class="col-md-12">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <div class="col-md-4">
                                    <img class="img-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem, "cons_imagen")) %>" />
                                    Num Consultorio: <b><%# DataBinder.Eval(Container.DataItem, "cons_numero") %></b>
<%--                                    <asp:ImageButton ID="img_eliminar" runat="server" ImageUrl="~/Template/Assets/imagenes/eliminar.gif" CommandArgument='<%#Eval("cons_id") %>' CommandName="Eliminar" OnClientClick="return confirm('Esta Seguro de Eliminar el Registro?')" />--%>

                                    <br />
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                        <%--<center>
                        <table style="width: 100%;">
                            <tr>
                                <td>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                            </tr>
                        </table>
                    </center>--%>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

