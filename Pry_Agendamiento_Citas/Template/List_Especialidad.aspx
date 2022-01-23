<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="List_Especialidad.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.List_Especialidad" %>
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
    Listado de Especialidades
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container-fluid">
                <asp:GridView ID="grv_especialidad" runat="server" AutoGenerateColumns="False" OnRowCommand="grv_especialidad_RowCommand" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:TemplateField HeaderText="" ItemStyle-Width="1cm">
                            <ItemTemplate>
                                <asp:ImageButton ID="img_editar" runat="server" ImageUrl="~/Template/Assets/imagenes/editar10.gif" CommandArgument='<%#Eval("espc_id") %>' CommandName="Editar" />
                            </ItemTemplate>
                            <ItemStyle Width="1cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="" ItemStyle-Width="1cm">
                            <ItemTemplate>
                                <asp:ImageButton ID="img_eliminar" runat="server" ImageUrl="~/Template/Assets/imagenes/eliminar.gif" CommandArgument='<%#Eval("espc_id") %>' CommandName="Eliminar" OnClientClick="return confirm('Esta Seguro de Eliminar el Registro?')" />
                            </ItemTemplate>
                            <ItemStyle Width="1cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID" ItemStyle-Width="1cm">
                            <ItemTemplate>
                                <asp:Label ID="espc_id" runat="server" Text='<%#Eval("espc_id") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="1cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ESPECIALIDADES" ItemStyle-Width="5cm">
                            <ItemTemplate>
                                <asp:Label ID="espc_nombre" runat="server" Text='<%#Eval("espc_nombre") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="5cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DESCRIPCIÓN" ItemStyle-Width="2cm">
                            <ItemTemplate>
                                <asp:Label ID="espc_descripcion" runat="server" Text='<%#Eval("espc_descripcion") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="2cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="EDADES" ItemStyle-Width="2cm">
                            <ItemTemplate>
                                <asp:Label ID="espc_edad_dirg" runat="server" Text='<%#Eval("espc_edad_dirg") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="2cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CONSULTORIO" ItemStyle-Width="3cm">
                            <ItemTemplate>
                                <asp:Label ID="cons_id" runat="server" Text='<%#Eval("cons_id") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="3cm" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
