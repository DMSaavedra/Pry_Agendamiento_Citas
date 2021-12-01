<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="Pry_Agendamiento_Citas.Paciente" %>


<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta content="width=device-width, initial-scale=1.0" name="viewport">
    <title></title>
    <meta content="" name="description">
    <meta content="" name="keywords">


    <link href="../assets/img/key.ico" rel="icon">
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Roboto:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">

    <link href="../assets/vendor/animate.css/animate.min.css" rel="stylesheet">
    <link href="../assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="../assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
    <link href="../assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
    <link href="../assets/vendor/glightbox/css/glightbox.min.css" rel="stylesheet">
    <link href="../assets/vendor/swiper/swiper-bundle.min.css" rel="stylesheet">

    <link href="../assets/css/style.css" rel="stylesheet">
    <link href="../assets/css/stilos.css" rel="stylesheet">

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.css">
    <link rel="stylesheet" href="https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css">
    <style>
        th,td {
            padding: 0.4rem !important;
        }
        body>div {
            box-shadow: 10px 10px 8px #888888;
            border: 2px solid black;
            border-radius: 10px;
        }
    </style>


</head>

<body>

    <div class="contenedor_loader">
        <div class="loader"></div>
    </div>
    <!-- ======= Header ======= -->
    <header id="header" class="fixed-top d-flex align-items-center">
        <div class="container d-flex align-items-center justify-content-between">

            <h1 class="logo"><a>PACIENTES</a></h1>
            <!-- Uncomment below if you prefer to use an image logo -->
            <!-- <a href="index.html" class="logo"><img src="assets/img/logo.png" alt="" class="img-fluid"></a>-->

            

        </div>
    </header><!-- End Header -->
    <a href="#" class="back-to-top d-flex align-items-center justify-content-center"><i class="bi bi-arrow-up-short"></i></a>

    <!-- Vendor JS Files -->
    <script src="../assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="../assets/vendor/glightbox/js/glightbox.min.js"></script>
    <script src="../assets/vendor/isotope-layout/isotope.pkgd.min.js"></script>
    <script src="../assets/vendor/php-email-form/validate.js"></script>
    <script src="../assets/vendor/purecounter/purecounter.js"></script>
    <script src="../assets/vendor/swiper/swiper-bundle.min.js"></script>

    <!-- Template Main JS File -->
    <script src="../assets/js/main.js"></script>
    <script src="../assets/js/script.js"></script>


</body>

<br>
<br>
<br>
<br>
<form action="../controladores/regrequerimiento.php" method="POST">
<div class="container p-2">
    <div class="card card-body">
    
        <div class="row">
            <div class="col-md-6">
                <label for="validationCustom03">Nombre</label>
                <input type="tel" name="nom"  class="form-control" autofocus>
            </div>
            <th>
                <div class="col-md-6 mb-3">
                    <label for="validationCustom03">Cedula</label>
                    <input type="tel" name="pre"  class="form-control" >
                </div>
            </th>
            <th>
                <div class="col-md-6 mb-3">
                    <label for="validationCustom03">Teléfono</label>
                    <input type="tel" name="metra" class="form-control" >
                </div>
            </th>
            <th>
                <div class="col-md-6 mb-3">
                    <label for="validationCustom03">Direccion</label>
                    <input type="tel" name="tel"  class="form-control" >
                </div>
            </th>
            <th>
                <div class="col-md-6 mb-3">
                    <label for="validationCustom03">Edad</label>
                    <input type="sect" name="sect"  class="form-control" >
                </div>
            </th>
            <th>
                <div class="col-md-6 mb-3">
                    <label for="validationCustom03">Grupo Sanguineo</label>
                    <input type="tel" name="direc" class="form-control" >
                </div>
            </th>
            <th>
                <div class="col-md-6 mb-3">
                    <label for="validationCustom03">Fecha de Nacimiento</label>
                    <input type="date" name="forma"  class="form-control" >
                </div>
            </th>
            <th>
                <div class="col-md-6 mb-3">
                    <label for="validationCustom03">Genero</label>
                    <input type="tel" name="obser"  class="form-control" style="width:530px"   >
                </div>
            </th>
<center>
<input type="submit" class="btn btn-primary" id="btnre" name="btnre" value="Registrar Paciente">
</center>

</div>
</div>

<div id="MensajeE">
</div>
</form>
<section class="principal">
<link rel="stylesheet" href="../css/busca.css">
<br>
<br>
<h4>Lista de Pacientes</h4>
   
       <div class="form-1-2">
            <label for="caja_busque">Buscar:</label>
            <input type="text" name="caja_busque" id="caja_busque"></input>
        </div>
        <div id="dat">
        </div>
    </section>
    <script src="../js/jquery.min.js"></script>
    <script src="../js/busca.js"></script>
</body>

</html>