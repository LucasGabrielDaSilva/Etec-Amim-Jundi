<?php
	session_start();	
	include_once("conexao.php");
		
	if((isset($_POST['usuario'])) && (isset($_POST['senha'])))
	{
		$nome = mysqli_real_escape_string($conn, $_POST['nome']);
		$usuario = mysqli_real_escape_string($conn, $_POST['usuario']);
		$senha = mysqli_real_escape_string($conn, $_POST['senha']);
		$
	
			
		$result_usuario = "SELECT * FROM usuario WHERE usuario = '$usuario' && senha = '$senha' LIMIT 1";
		$resultado_usuario = mysqli_query($conn, $result_usuario);
		$resultado = mysqli_fetch_assoc($resultado_usuario);
		
		if(isset($resultado))
		{
		$_SESSION['usuarioCod'] = $resultado['codigo'];
	    $_SESSION['usuarionome'] = $resultado['nome'];
		$_SESSION['usuario'] = $resultado['usuario'];
		$_SESSION['usuarioSenha'] = $resultado['senha'];
		
	
		//  aqui abaixo carregar a página de Principal
			header("Location: inicial.php");
	  
		}
		
		else
		{	
			$_SESSION['loginErro'] = "Usuário ou senha Inválido";
			header("Location: index.html");
		}
	}
	else
	{
		$_SESSION['loginErro'] = "Usuário ou senha inválido";
		header("Location: index.html");
	}
?>