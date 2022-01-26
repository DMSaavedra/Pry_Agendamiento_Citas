<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Page.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_nom_user" runat="server">
    Bienvenido: 
    <asp:Label ID="lbl_nombre" runat="server" Text="" Font-Italic="True"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_header" runat="server">
    Dashboard
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cph_titulo" runat="server">
    Información Inicial
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cph_contenido" runat="server">
    <div class="row">
        <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
            <div class="panel panel-teal panel-widget border-right">
                <div class="row no-padding">
                    <em class="fa fa-xl fa-shopping-cart color-blue"></em>
                    <div class="large">120</div>
                    <div class="text-muted">New Orders</div>
                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
            <div class="panel panel-blue panel-widget border-right">
                <div class="row no-padding">
                    <em class="fa fa-xl fa-comments color-orange"></em>
                    <div class="large">52</div>
                    <div class="text-muted">Comments</div>
                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
            <div class="panel panel-orange panel-widget border-right">
                <div class="row no-padding">
                    <em class="fa fa-xl fa-users color-teal"></em>
                    <div class="large">24</div>
                    <div class="text-muted">New Users</div>
                </div>
            </div>
        </div>
        <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
            <div class="panel panel-red panel-widget ">
                <div class="row no-padding">
                    <em class="fa fa-xl fa-search color-red"></em>
                    <div class="large">25.2k</div>
                    <div class="text-muted">Page Views</div>
                </div>
            </div>
        </div>
    </div>
    <!--/.row-->
    <br />
    <div class="container-fluid">
        <asp:GridView ID="grv_citas_fchAct" runat="server" CssClass="table table-bordered table-responsive" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="ID" ItemStyle-Width="1cm">
                    <ItemTemplate>
                        <asp:Label ID="cagn_id" runat="server" Text='<%#Eval("cagn_id") %>'></asp:Label>
                    </ItemTemplate>

                    <ItemStyle Width="1cm"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NOMBRE Y APELLIDO" ItemStyle-Width="5cm">
                    <ItemTemplate>
                        <asp:Label ID="cagn_nombre" runat="server" Text='<%#Eval("cagn_paciente") %>'></asp:Label>
                    </ItemTemplate>

                    <ItemStyle Width="5cm"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FECHA CITA MEDICA" ItemStyle-Width="3cm">
                    <ItemTemplate>
                        <asp:Label ID="cagn_fechaAgen" runat="server" Text='<%#Eval("cagn_fechaAgen") %>'></asp:Label>
                    </ItemTemplate>

                    <ItemStyle Width="3cm"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HORA CITA MEDICA" ItemStyle-Width="4cm">
                    <ItemTemplate>
                        <asp:Label ID="cagn_horaAgen" runat="server" Text='<%#Eval("cagn_horaAgen") %>'></asp:Label>
                    </ItemTemplate>

                    <ItemStyle Width="4cm"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DOCTOR" ItemStyle-Width="2cm">
                    <ItemTemplate>
                        <asp:Label ID="cagn_doctor" runat="server" Text='<%#Eval("cagn_doctor") %>'></asp:Label>
                    </ItemTemplate>

                    <ItemStyle Width="2cm"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ESPECIALIDAD" ItemStyle-Width="2cm">
                    <ItemTemplate>
                        <asp:Label ID="espc_id" runat="server" Text='<%#Eval("espc_id") %>'></asp:Label>
                    </ItemTemplate>

                    <ItemStyle Width="2cm"></ItemStyle>
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
</asp:Content>
