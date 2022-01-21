<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Pry_Agendamiento_Citas.login" %>

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
            <h1 class="sign-up__title">Agendamiento de Citas</h1>
            <p class="sign-up__subtitle">Ingrese sus Credenciales</p>
            <form id="form1" runat="server" class="sign-up-form form">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <center>
                            <asp:Label runat="server" Text="" ID="lbl_mensaje"></asp:Label>
                        </center>
                        <label class="form-label-wrapper">
                            <p class="form-label">Usuario</p>
                            <asp:TextBox ID="txt_usuario" class="form-input" placeholder="Ingrese su usuario" runat="server"></asp:TextBox>
                        </label>
                        <label class="form-label-wrapper">
                            <p class="form-label">Cedula</p>
                            <asp:TextBox ID="txt_password" type="password" class="form-input" placeholder="Ingrese su numero de Cedula" runat="server"></asp:TextBox>
                        </label>
                        <asp:LinkButton ID="lnk_olvido" class="link-info forget-link" runat="server">Olvido su Contraseña?</asp:LinkButton>
                        <br />
                        <asp:LinkButton ID="lnk_Registro" runat="server" class="link-info" OnClick="lnk_Registro_Click">Registrarse</asp:LinkButton>
                        <br />
                        <br />
                        <asp:Button ID="btn_ingresar" class="form-btn primary-default-btn transparent-btn" runat="server" Text="Ingresar" OnClick="btn_ingresar_Click" />
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
