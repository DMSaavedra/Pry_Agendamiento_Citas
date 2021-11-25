<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_registro.aspx.cs" Inherits="Pry_Agendamiento_Citas.login_registro" %>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<!DOCTYPE html>
<!--[if lt IE 7 ]> <html lang="en" class="no-js ie6 lt8"> <![endif]-->
<!--[if IE 7 ]>    <html lang="en" class="no-js ie7 lt8"> <![endif]-->
<!--[if IE 8 ]>    <html lang="en" class="no-js ie8 lt8"> <![endif]-->
<!--[if IE 9 ]>    <html lang="en" class="no-js ie9"> <![endif]-->
<!--[if (gt IE 9)|!(IE)]><!--> <html lang="en" class="no-js"> <!--<![endif]-->
    <head>
        <meta charset="UTF-8" />
        <!-- <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">  -->
        <title>Login and Registration Form with HTML5 and CSS3</title>
		<link rel="stylesheet" type="text/css" href="stilos/stilos.css" />
		<link href="https://fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet">
		
    </head>
    <body>
        <div class="container">
           
            <header>
                <h2>LOGEO Y REGISTRO DE USUARIOS</h2>
				
            </header>
            <section>				
                <div id="container_demo" >
                    <!-- hidden anchor to stop jump http://www.css3create.com/Astuce-Empecher-le-scroll-avec-l-utilisation-de-target#wrap4  -->
                    <a class="hiddenanchor" id="toregister"></a>
                    <a class="hiddenanchor" id="tologin"></a>
                    <div id="wrapper">
                        <div id="login" class="animate form">
                            <form  runat="server"> 
                                <h1>INICIO CESIÓN</h1> 
                                <p> 
                                    <label for="username" class="uname" > USUARIO </label>
                                    <asp:TextBox ID="txt_usuario" runat="server" placeholder="Ingrese su usuario"></asp:TextBox>
                                </p>
                                <p> 
                                    <label for="password" class="youpasswd"> CONTRASEÑA </label>
                                    <asp:TextBox ID="txt_password" runat="server" placeholder="Ingrese su Contraseña"></asp:TextBox>
                                </p>
                                <p class="keeplogin"> 
									<asp:Button ID="btn_ingresar" runat="server" Text="Ingresar" />
								</p>
                                <p class="login button"> 
                                   <a href="http://cookingfoodsworld.blogspot.in/" target="_blank" ></a>
								</p>
                                <p class="change_link">
									Crear usuarios
									<a href="#toregister" class="to_register">Registrarse</a>
								</p>
                            </form>
                        </div>

                        <div id="register" class="animate form">
                            <form  runat="server"> 
                                <h1> REGISTRARSE </h1> 
                                <p> 
                                    <label for="usernamesignup" class="uname" >Your username</label>
                                    <input id="usernamesignup" name="usernamesignup" required="required" type="text" placeholder="mysuperusername690" />
                                </p>
                                <p> 
                                    <label for="emailsignup" class="youmail"  > Your email</label>
                                    <input id="emailsignup" name="emailsignup" required="required" type="email" placeholder="mysupermail@mail.com"/> 
                                </p>
                                <p> 
                                    <label for="passwordsignup" class="youpasswd" >Your password </label>
                                    <input id="passwordsignup" name="passwordsignup" required="required" type="password" placeholder="eg. X8df!90EO"/>
                                </p>
                                <p> 
                                    <label for="passwordsignup_confirm" class="youpasswd" >Please confirm your password </label>
                                    <input id="passwordsignup_confirm" name="passwordsignup_confirm" required="required" type="password" placeholder="eg. X8df!90EO"/>
                                </p>
                                <p class="signin button"> 
									<input type="submit" value="Sign up"/> 
								</p>
                                <p class="change_link">  
									Crear usuario
									<a href="#tologin" class="to_register"> Go and log in </a>
								</p>
                            </form>
                        </div>
						
                    </div>
                </div>  
            </section>
        </div>
    </body>
</html>
