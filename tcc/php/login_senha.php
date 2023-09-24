<?php
	session_start();	
	include_once("conexao.php");
?>
<!DOCTYPE html>
<html lang="pt-br">
  <head>
      <meta charset="utf-8"> 
  </head>

  
  <body >

   <form  method="POST" action="verificasenha.php">
        <center><h1><p><br><p><br><p><br> Informe os seus dados para acessar o sistema: </h1><p><p><br>
<h2> 
     <!--   <label for="nome" > Nome Completo</label>
        <input type="text" name="nome" id="nome"  placeholder="Nome Completo" required autofocus> <p> -->

 				<label for="login" > Login </label>
        <input type="text" name="login" id="login"  size=50 placeholder="Nome do login para o acesso" required autofocus> <p>

        <label for="senha" > Senha </label>
        <input type="password" name="senha" id="senha" size=30 placeholder="Senha" required autofocus> <br><br>
        
        <!--   <label for="email" > Email </label>
        <input type="email" name="email" id="email"  placeholder="Email" required autofocus> <p>-->

        <button  type="submit"> Acessar </button>
      </form>
	  <p>
		<?php 
		   if(isset($_SESSION['loginErro'])){
				echo $_SESSION['loginErro'];
				unset($_SESSION['loginErro']);
		    }
		?>
		</p> <p>
			<?php 
			if(isset($_SESSION['logindeslogado'])){
				echo $_SESSION['logindeslogado'];
				unset($_SESSION['logindeslogado']);
			}
			?>
		</p>
  
<p>
 <button class="button button2"><a href="login_senha.php">Atualizar a página</a></button>
<p>
  </body>
</html>
