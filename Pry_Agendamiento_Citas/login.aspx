<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Pry_Agendamiento_Citas.login" %>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Elegant Dashboard | Sign In</title>
  <!-- Favicon -->
  <link rel="shortcut icon" href="imagenes/Logo.svg" type="image/x-icon">
  <!-- Custom styles -->
  <link rel="stylesheet" href="stilos/style.min.css">
</head>

<body>
  <div class="layer"></div>
<main class="page-center">
  <article class="sign-up">
    <h1 class="sign-up__title">AGENDAMIENTO DE CITAS BIENVENIDO</h1>
    <center><p class="sign-up__subtitle">Ingreso de usuario</p></center>
    <form runat="server">
      <label class="form-label-wrapper">
        <p class="form-label">USUARIO</p>
          <asp:TextBox ID="txt_usuario"  class="form-input" placeholder="Ingrese su usuario" runat="server"></asp:TextBox>
      </label>
      <label class="form-label-wrapper">
        <p class="form-label">Contraseña</p>
          <asp:TextBox ID="txt_password"  class="form-input" placeholder="Ingrese su contraseña" runat="server"></asp:TextBox>
       
      </label>
        <asp:LinkButton ID="lnk_olvido" class="link-info forget-link" runat="server">Olvido su Contraseña?</asp:LinkButton>
        <br />
        <asp:Button ID="btn_ingresar" class="form-btn primary-default-btn transparent-btn" runat="server" Text="Ingresar" />
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
