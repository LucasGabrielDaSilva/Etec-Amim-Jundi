<?php
session_start();
include_once("conexao.php");
?>
<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="utf-8">
		<link rel="stylesheet" href="">
		 <center><title style="border:2px solid Violet;">Lista Login </title>		
	</head>
	<body>
		<div class="topnav">
		<a href="inicial.html">Início</a>
  <a href="cadastro.html">Cadastro De Agenda</a>
  <a href="cadevento.html">Cadastro De Evento </a>
  <a href="listalogin.php">Lista Agenda</a>
  <a href="listinha.php">Lista Evento</a>
  <a href="listacomp.php">Lista Completa</a>
  <a href="listalogin.php">Lista Login</a>
</div><br>
		<p><hr><h1>Listar Login</h1> <p> <hr> <h3>
		<?php
		if(isset($_SESSION['msg']))
		{
			echo $_SESSION['msg'];
			unset($_SESSION['msg']);
			echo "<br>";
		}
		
		//Receber o número da página
		$pagina_atual = filter_input(INPUT_GET,'pagina', FILTER_SANITIZE_NUMBER_INT);		
		$pagina = (!empty($pagina_atual)) ? $pagina_atual : 1;
		
		//Setar a quantidade de itens por pagina
		$qnt_result_pg = 3;
		
		//calcular o inicio visualização
		$inicio = ($qnt_result_pg * $pagina) - $qnt_result_pg;
		
		$result_usuarios = "SELECT * FROM usuario LIMIT $inicio, $qnt_result_pg";
		$resultado_usuarios = mysqli_query($conn, $result_usuarios);
		while($row_usuario = mysqli_fetch_assoc($resultado_usuarios)){
			echo "  Código: " . $row_usuario['codigo'] . "<br>";
			echo "  Nome: " . $row_usuario['nome'] . "<br>";
			echo "  Login:: " . $row_usuario['login'] . "<br>";
			echo "  Senha: " . $row_usuario['senha'] . "<br>";
            echo "  Email: " . $row_usuario['email'] . "<br>";
			echo "<a href='alteralogin.php?codigo=" . $row_usuario['codigo'] . "'>Editar</a><br>";
			echo "<a href='apagalogin.php?codigo=" . $row_usuario['codigo'] . "'>Apagar</a><br><hr>";
			echo "<hr> <br>";
		   
		}
		
		//Paginção - Somar a quantidade de usuários
		$result_pg = "SELECT COUNT(codigo) AS num_result FROM usuario";
		$resultado_pg = mysqli_query($conn, $result_pg);
		$row_pg = mysqli_fetch_assoc($resultado_pg);
		//echo $row_pg['num_result'];
		//Quantidade de pagina 
		$quantidade_pg = ceil($row_pg['num_result'] / $qnt_result_pg);
		
		//Limitar os link antes depois
		$max_links = 2;
		echo "<a href='listalogin.php?pagina=1'>Primeira</a> ";
		
		for($pag_ant = $pagina - $max_links; $pag_ant <= $pagina - 1; $pag_ant++){
			if($pag_ant >= 1){
				echo "<a href='listalogin.php?pagina=$pag_ant'>$pag_ant</a> ";
			}
		}
			
		echo "$pagina ";
		
		for($pag_dep = $pagina + 1; $pag_dep <= $pagina + $max_links; $pag_dep++){
			if($pag_dep <= $quantidade_pg){
				echo "<a href='listalogin.php?pagina=$pag_dep'>$pag_dep</a> ";
			}
		}
		
		echo "<a href='listalogin.php?pagina=$quantidade_pg'>Ultima</a>";
		
		?>		
	</body>
</html>