<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Pry_Agendamiento_Citas.Registrar" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Agendamiento Citas</title>
    <!-- Favicon -->
    <link rel="shortcut icon" href="imagenes/Logo.svg" type="image/x-icon">
    <!-- Custom styles -->
    <link rel="stylesheet" href="stilos/style.min.css">
</head>

<body>
    <div class="layer"></div>
    <main class="page-center">
        <article class="sign-up">
            <h1 class="sign-up__title">REGISTRO USUARIOS</h1>
            <p class="sign-up__subtitle">Si no posee de un usuario, registrese aqui!.</p>
            <form runat="server" class="sign-up-form form">
                <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="3000" OnTick="Timer1_Tick"></asp:Timer>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <label class="form-label-wrapper">
                            <p class="form-label">Apellido y Nombre</p>
                            <asp:TextBox ID="txt_nombapell" class="form-input" runat="server" placeholder="Ingrese un Apellido y un Nombre" onkeyup="document.getElementById(this.id).value=document.getElementById(this.id).value.toUpperCase()"></asp:TextBox>
                        </label>
                        <label class="form-label-wrapper">
                            <p class="form-label">Cédula</p>
                            <asp:TextBox ID="txt_ced" class="form-input" placeholder="Ingrese su cédula" runat="server"></asp:TextBox>
                        </label>
                        <label class="form-label-wrapper">
                            <p class="form-label">Correo</p>
                            <asp:TextBox ID="txt_correo" class="form-input" placeholder="Ingrese su correo" runat="server" TextMode="Email"></asp:TextBox>
                        </label>
                        <label class="form-label-wrapper">
                            <p class="form-label">Usuario</p>
                            <asp:TextBox ID="txt_usuario" class="form-input" placeholder="Ingrese un usuario" runat="server"></asp:TextBox>
                        </label>
                        <br />
                        <asp:Button ID="btn_registrar" class="form-btn primary-default-btn transparent-btn" runat="server" Text="Registrar" OnClick="btn_registrar_Click"/>
                        <br />
                        <br />
                        <asp:LinkButton ID="lnk_Cancelar" class="link-info" runat="server" OnClick="lnk_Cancelar_Click">Cancelar</asp:LinkButton>
                        <center>
                            <br />
                            <asp:Label runat="server" ID="lbl_mensaje" Text=""></asp:Label>
                        </center>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </form>
        </article>
    </main>
    <!-- Chart library -->
    <script src="js/chart.min.js"></script>
    <!-- Icons library -->
    <script src="js/feather.min.js"></script>
    <!-- Custom scripts -->
    <script src="js/script.js"></script>
</body>

</html>
