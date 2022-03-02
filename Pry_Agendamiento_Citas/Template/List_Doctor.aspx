<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="List_Doctor.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.List_Doctor" %>
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
    Listado de Doctores
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container-fluid">
                <asp:GridView ID="grv_doctores" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="False" OnRowCommand="grv_doctores_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="" ItemStyle-Width="1cm">
                            <ItemTemplate>
                                <asp:ImageButton ID="img_editar" runat="server" ImageUrl="~/Template/Assets/imagenes/editar10.gif" CommandArgument='<%#Eval("usu_id") %>' CommandName="Editar" />
                            </ItemTemplate>
                            <ItemStyle Width="1cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="" ItemStyle-Width="1cm">
                            <ItemTemplate>
                                <asp:ImageButton ID="img_eliminar" runat="server" ImageUrl="~/Template/Assets/imagenes/eliminar.gif" CommandArgument='<%#Eval("usu_id") %>' CommandName="Eliminar" OnClientClick="return confirm('Esta Seguro de Eliminar el Registro?')" />
                            </ItemTemplate>
                            <ItemStyle Width="1cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID" ItemStyle-Width="1cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_id" runat="server" Text='<%#Eval("usu_id") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="1cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="APELLIDOS Y NOMBRES" ItemStyle-Width="5cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_apellido_nombre" runat="server" Text='<%#Eval("usu_apellido_nombre") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="5cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="EDAD" ItemStyle-Width="2cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_edad" runat="server" Text='<%#Eval("usu_edad") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="2cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CEDULA" ItemStyle-Width="2cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_cedula" runat="server" Text='<%#Eval("usu_cedula") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="2cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="TELEFONO" ItemStyle-Width="3cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_telefono" runat="server" Text='<%#Eval("usu_telefono") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="3cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="GRUPO SANGUINEO" ItemStyle-Width="4cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_grupo_sanguineo" runat="server" Text='<%#Eval("usu_grupo_sanguineo") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="4cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="GENERO" ItemStyle-Width="2cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_genero" runat="server" Text='<%#Eval("usu_genero") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="2cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="EMAIL" ItemStyle-Width="5cm">
                            <ItemTemplate>
                                <asp:Label ID="usu_correo" runat="server" Text='<%#Eval("usu_correo") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="5cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ESPECIALIDAD" ItemStyle-Width="2cm">
                            <ItemTemplate>
                                <asp:Label ID="espc_id" runat="server" Text='<%#Eval("espc_id") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="2cm" />
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
