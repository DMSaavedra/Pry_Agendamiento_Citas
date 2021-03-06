<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Pry_Agendamiento_Citas.login" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Agendamiento Citas</title> 

    <!--Icono de la Ventana-->
<%--    <link rel="icon" type="icon/png" href="https://cdn-icons-png.flaticon.com/512/1314/1314645.png">--%>

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
                <asp:Timer ID="Timer1" runat="server" Enabled="false" Interval="5000" OnTick="Timer1_Tick"></asp:Timer>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <center>
                            <asp:Label runat="server" Text="" ID="lbl_mensaje"></asp:Label>
                        </center>
                        <label class="form-label-wrapper">
                            <asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>
                            <asp:TextBox ID="txt_usuario" MaxLength="10" class="form-input" placeholder="Ingrese su Usuario" runat="server" onKeypress="if ((event.keyCode != 32) && (event.keyCode < 65) || (event.keyCode > 90) && (event.keyCode < 97) || (event.keyCode > 122)) event.returnValue = false;"></asp:TextBox>
                        </label>
                        <label class="form-label-wrapper">
                            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                            <asp:TextBox ID="txt_password" MaxLength="6" class="form-input" placeholder="Ingrese su Contraseña" TextMode="Password" runat="server" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;"></asp:TextBox>
                        </label>
                        <label class="form-label-wrapper">
                            <asp:Label ID="Label4" runat="server" Text="Cedula" Visible="false"></asp:Label>
                            <asp:TextBox ID="txt_cedula" MaxLength="10" class="form-input" Visible="false" placeholder="Ingrese su numero de Cedula" runat="server" onKeypress="if (event.keyCode < 48 || event.keyCode > 57) event.returnValue = false;"></asp:TextBox>
                        </label>
                        <asp:Button ID="btn_ingresar" class="form-btn primary-default-btn transparent-btn" runat="server" Text="Ingresar" OnClick="btn_ingresar_Click" />
                        <asp:Button ID="btn_recuperar" class="form-btn primary-default-btn transparent-btn" runat="server" Text="Recuperar" OnClick="btn_recuperar_Click" Visible="false" />
                        <br />
                        <asp:LinkButton ID="lnk_olvido" class="link-info forget-link" runat="server" Visible="false" OnClick="lnk_olvido_Click">Olvido sus Credenciales?</asp:LinkButton>
                        <br />
                        <asp:LinkButton ID="lnk_Registro" runat="server" class="link-info" OnClick="lnk_Registro_Click">Registrarse</asp:LinkButton>
                        <br />
                        <asp:LinkButton ID="lnk_Cancelar" runat="server" class="link-info" OnClick="lnk_Cancelar_Click" Visible="false">Cancelar</asp:LinkButton>
                        <br />
                        <br />
                        <center>
                            <asp:Label ID="Label1" runat="server" Text="Intentos :"></asp:Label>
                            <b>
                                <asp:Label ID="lbl_intentos" runat="server" Text=""></asp:Label>
                            </b>
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
