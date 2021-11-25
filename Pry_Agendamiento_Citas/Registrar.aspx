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
    <form runat="server">
      <label class="form-label-wrapper">
        <p class="form-label">Nombre y Apellido</p>
         <asp:TextBox ID="txt_nombapell"  class="form-input" placeholder="Ingrese su nombre y apellido" runat="server"></asp:TextBox>
      </label>
      <label class="form-label-wrapper">
        <p class="form-label">Cédula</p>
         <asp:TextBox ID="txt_ced"  class="form-input" placeholder="Ingrese su cédula" runat="server"></asp:TextBox>
      </label>
      <label class="form-label-wrapper">
        <p class="form-label">Teléfono</p>
         <asp:TextBox ID="txt_tel"  class="form-input" placeholder="Ingrese su teléfono" runat="server"></asp:TextBox>
      </label>
         <label class="form-label-wrapper">
        <p class="form-label">Usuario</p>
        <asp:TextBox ID="txt_usuario"  class="form-input" placeholder="Ingrese su usuario" runat="server"></asp:TextBox>
      </label>
      <label class="form-label-wrapper">
        <p class="form-label">Contraseña</p>
       <asp:TextBox ID="txt_password"  class="form-input" placeholder="Ingrese su contraseña" runat="server"></asp:TextBox>
      </label>
     <br />
        <asp:Button ID="btn_registrar" class="form-btn primary-default-btn transparent-btn" runat="server" Text="Registrar" />
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
