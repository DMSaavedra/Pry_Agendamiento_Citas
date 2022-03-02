<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="HistorialMed.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.HistorialMed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
     Bienvenido: 
    <asp:Label ID="lbl_nombre" runat="server" Text="" Font-Italic="True"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Historial Médico
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
    Historial de Pacientes
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <contenttemplate>
            <div class="container-fluid">
                <center>
                    <table>
                        <tr>
                            <td>Buscar por: </td>
                            <td>&nbsp;
                            <asp:DropDownList ID="ddl_criterio" Width="120px" runat="server">
                                <asp:ListItem Text="Paciente" Value="N" />
                                <asp:ListItem Text="Medico" Value="M" />
                                <asp:ListItem Text="Especialidad" Value="E" />
                            </asp:DropDownList>
                            </td>
                            <td>&nbsp;
                            <asp:TextBox ID="txt_buscar" runat="server" Width="300px"></asp:TextBox>
                            </td>
                            <td>&nbsp;
                            <asp:ImageButton ID="img_lupa" runat="server" ImageUrl="~/Template/Assets/imagenes/search.png" on OnClick="img_lupa_Click" />
                                &nbsp;
                            <asp:ImageButton ID="img_limpiar" runat="server" ImageUrl="~/Template/Assets/imagenes/eliminar.gif" OnClick="img_limpiar_Click" />
                            </td>
                        </tr>
                    </table>
                </center>
                <br />
                <asp:GridView ID="grv_cits_agends" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-responsive" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <columns>
                        <asp:TemplateField HeaderText="NOMBRE Y APELLIDO" ItemStyle-Width="5cm">
                            <itemtemplate>
                                <asp:Label ID="cagn_nombre" runat="server" Text='<%#Eval("cagn_paciente") %>'></asp:Label>
                            </itemtemplate>
                            <ItemStyle Width="5cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="FECHA CITA MEDICA" ItemStyle-Width="3cm">
                            <itemtemplate>
                                <asp:Label ID="cagn_fechaAgen" runat="server" Text='<%#Eval("cagn_fechaAgen") %>'></asp:Label>
                            </itemtemplate>
                            <ItemStyle Width="3cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="HORA CITA MEDICA" ItemStyle-Width="4cm">
                            <itemtemplate>
                                <asp:Label ID="cagn_horaAgen" runat="server" Text='<%#Eval("cagn_horaAgen") %>'></asp:Label>
                            </itemtemplate>
                            <ItemStyle Width="4cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="DOCTOR" ItemStyle-Width="2cm">
                            <itemtemplate>
                                <asp:Label ID="cagn_doctor" runat="server" Text='<%#Eval("cagn_doctor") %>'></asp:Label>
                            </itemtemplate>
                            <ItemStyle Width="2cm" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ESPECIALIDAD" ItemStyle-Width="2cm">
                            <itemtemplate>
                                <asp:Label ID="espc_id" runat="server" Text='<%#Eval("espc_id") %>'></asp:Label>
                            </itemtemplate>
                            <ItemStyle Width="2cm" />
                        </asp:TemplateField>
                    </columns>
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
        </contenttemplate>
    </asp:UpdatePanel>
</asp:Content>
