<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="Pry_Agendamiento_Citas.Template.dashboard" %>

<!DOCTYPE html>

<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Elegant Dashboard | Dashboard</title>

  <!-- Custom styles -->
  <link rel="stylesheet" href="css/style.min.css">

  <!-- FontAwesome-->
  <link rel="stylesheet" href="https://pro.fontawesome.com/releases/v5.10.0/css/all.css" />

  <!-- Bootstrap-->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">

</head>

<body>
  <div class="layer"></div>
  <!-- ! Body -->
  <a class="skip-link sr-only" href="#skip-target">Skip to content</a>
  <div class="page-flex">
    <!-- ! Sidebar -->
    <aside class="sidebar">
      <div class="sidebar-start">
        <div class="sidebar-head">
          <a href="/" class="logo-wrapper" title="Home">
            <span class="sr-only">Home</span>
            <span class="icon logo" aria-hidden="true"></span>
            <div class="logo-text">
              <span class="logo-title">Elegant</span>
              <span class="logo-subtitle">Dashboard</span>
            </div>

          </a>
          <button class="sidebar-toggle transparent-btn" title="Menu" type="button">
            <span class="sr-only">Toggle menu</span>
            <span class="icon menu-toggle" aria-hidden="true"></span>
          </button>
        </div>
        <div class="sidebar-body">
          <ul class="sidebar-body-menu">
            <li>
              <a class="active" href="/"><span class="icon home" aria-hidden="true"></span>Inicio</a>
            </li>
            <li>
              <a class="show-cat-btn" style="color: whitesmoke;">
                <span class="icon user-3" aria-hidden="true"></span>Pacientes
                <span class="category__btn transparent-btn" title="Open list">
                  <span class="icon arrow-down" aria-hidden="true"></span>
                </span>
              </a>
              <ul class="cat-sub-menu">
                <li>
                  <a href="posts.html" style="color: whitesmoke;">Lista Pacientes</a>
                </li>
                <li>
                  <a href="new-post.html" style="color: whitesmoke;">Nuevo Paciente</a>
                </li>
              </ul>
            </li>

            <li>
              <a class="show-cat-btn" style="color: whitesmoke;">
                <span class="icon folder" aria-hidden="true"></span>Especialidades
                <span class="category__btn transparent-btn" title="Open list">
                  <span class="icon arrow-down" aria-hidden="true"></span>
                </span>
              </a>
              <ul class="cat-sub-menu">
                <li>
                  <a href="posts.html" style="color: whitesmoke;">Lista Especialidades</a>
                </li>
                <li>
                  <a href="new-post.html" style="color: whitesmoke;">Nueva Especialidad</a>
                </li>
              </ul>
            </li>

            <li>
              <a class="show-cat-btn" style="color: whitesmoke;">
                <span class="icon user-3" aria-hidden="true"></span>Doctores
                <span class="category__btn transparent-btn" title="Open list">
                  <span class="icon arrow-down" aria-hidden="true"></span>
                </span>
              </a>
              <ul class="cat-sub-menu">
                <li>
                  <a href="posts.html" style="color: whitesmoke;">Lista Doctores</a>
                </li>
                <li>
                  <a href="new-post.html" style="color: whitesmoke;">Nuevo Doctor</a>
                </li>
              </ul>
            </li>
            
            
          <span class="system-menu__title">CORE</span>

          <ul class="sidebar-body-menu">

            <li>
              <a class="show-cat-btn" style="color: whitesmoke;">
                <span class="icon edit" aria-hidden="true"></span>Agendamiento
                <span class="category__btn transparent-btn" title="Open list">
                  <span class="icon arrow-down" aria-hidden="true"></span>
                </span>
              </a>
              <ul class="cat-sub-menu">
                <li>
                  <a href="posts.html" style="color: whitesmoke;">Por Doctor</a>
                </li>
                <li>
                  <a href="new-post.html" style="color: whitesmoke;">Por Especialidad</a>
                </li>
              </ul>
            </li>
            
            <li>
              <a href="##" style="color: whitesmoke;"><span class="icon setting" aria-hidden="true" ></span>Salir</a>
            </li>
          </ul>
        </div>
      </div>
      <div class="sidebar-footer">
        <a href="##" class="sidebar-user">
          <span class="sidebar-user-img">
            <picture>
              <img
                src="./img/avatar-illustrated-02.png" alt="User name">
            </picture>
          </span>
          <div class="sidebar-user-info">
            <span class="sidebar-user__title">Diego Saavedra</span>
            <span class="sidebar-user__subtitle">Paciente</span>
          </div>
        </a>
      </div>
    </aside>
    <div class="main-wrapper">
      <!-- ! Main nav -->
      <nav class="main-nav--bg">
        <div class="container main-nav">
          <div class="main-nav-end">
            <button class="sidebar-toggle transparent-btn" title="Menu" type="button">
              <span class="sr-only">Toggle menu</span>
              <span class="icon menu-toggle--gray" aria-hidden="true"></span>
            </button>
          </div>
        </div>
      </nav>
      <!-- ! Main -->
      <main class="main users chart-page" id="skip-target">
        <div class="container">
          <h2 class="main-title">Dashboard</h2>
          <div class="row stat-cards">
            <div class="col-md-6 col-xl-3">
              <article class="stat-cards-item">
                <div class="stat-cards-icon primary">
                  <i data-feather="bar-chart-2" aria-hidden="true"></i>
                </div>
                <div class="stat-cards-info">
                  <p class="stat-cards-info__num">1478 286</p>
                  <p class="stat-cards-info__title">Total visits</p>
                  <p class="stat-cards-info__progress">
                    <span class="stat-cards-info__profit success">
                      <i data-feather="trending-up" aria-hidden="true"></i>4.07%
                    </span>
                    Last month
                  </p>
                </div>
              </article>
            </div>
            <div class="col-md-6 col-xl-3">
              <article class="stat-cards-item">
                <div class="stat-cards-icon warning">
                  <i data-feather="file" aria-hidden="true"></i>
                </div>
                <div class="stat-cards-info">
                  <p class="stat-cards-info__num">1478 286</p>
                  <p class="stat-cards-info__title">Total visits</p>
                  <p class="stat-cards-info__progress">
                    <span class="stat-cards-info__profit success">
                      <i data-feather="trending-up" aria-hidden="true"></i>0.24%
                    </span>
                    Last month
                  </p>
                </div>
              </article>
            </div>
            <div class="col-md-6 col-xl-3">
              <article class="stat-cards-item">
                <div class="stat-cards-icon purple">
                  <i data-feather="file" aria-hidden="true"></i>
                </div>
                <div class="stat-cards-info">
                  <p class="stat-cards-info__num">1478 286</p>
                  <p class="stat-cards-info__title">Total visits</p>
                  <p class="stat-cards-info__progress">
                    <span class="stat-cards-info__profit danger">
                      <i data-feather="trending-down" aria-hidden="true"></i>1.64%
                    </span>
                    Last month
                  </p>
                </div>
              </article>
            </div>
            <div class="col-md-6 col-xl-3">
              <article class="stat-cards-item">
                <div class="stat-cards-icon success">
                  <i data-feather="feather" aria-hidden="true"></i>
                </div>
                <div class="stat-cards-info">
                  <p class="stat-cards-info__num">1478 286</p>
                  <p class="stat-cards-info__title">Total visits</p>
                  <p class="stat-cards-info__progress">
                    <span class="stat-cards-info__profit warning">
                      <i data-feather="trending-up" aria-hidden="true"></i>0.00%
                    </span>
                    Last month
                  </p>
                </div>
              </article>
            </div>
          </div>
          
        </div>
      </main>
      
    </div>
  </div>
  <!-- Chart library -->
  <script src="./plugins/chart.min.js"></script>
  <!-- Icons library -->
  <script src="plugins/feather.min.js"></script>
  <!-- Custom scripts -->
  <script src="js/script.js"></script>

  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>

</html>
