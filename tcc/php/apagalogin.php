<?php
session_start();
include_once("conexao.php");
$codigo = filter_input(INPUT_GET, 'codigo', FILTER_SANITIZE_NUMBER_INT);
$result_usuario = "SELECT * FROM usuario WHERE codigo = '$codigo'";
$resultado_usuario = mysqli_query($conn, $result_usuario);
$row_usuario = mysqli_fetch_assoc($resultado_usuario);
?>
<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="utf-8">
		<title>Edição do Login</title>		
	</head>
	<body>
		<hr> <p>
		<a href="index.html"> <input type="button"  value="Página Inicial"></a> &nbsp
    	<a href="cadastro.php"> <input type="button"  value= "Cadastrar"></a> &nbsp 
        <a href= "exe_listar.php"> <input type="button"  value="Listar" ></a> &nbsp
       <a href= "listacomp.php"> <input type="button"  value="Listar Dados Completo"></a> &nbsp
       <p><hr><h1>Editar dados do Login</h1> <p> <hr>
		
		<?php
		if(isset($_SESSION['msg'])){
			echo $_SESSION['msg'];
			unset($_SESSION['msg']);
		}
		?>
		<form method="POST" action="apagarlogin.php">
			<input type="hidden" name="codigo" value="<?php echo $row_usuario['codigo']; ?>">
			
			<label>Nome: </label>
			<input type="text" name="nome" placeholder="Digite o nome completo" value="<?php echo $row_usuario['nome']; ?>"><br><br>
			<label>Login: </label>
			<input type="text" name="login" placeholder="Digite o seu login" value="<?php echo $row_usuario['login']; ?>"><br><br>
			<label>Senha: </label>
			<input type="password" name="senha" placeholder="Digite a sua senha" value="<?php echo $row_usuario['senha']; ?>"><br><br>
			<label>Email: </label>
			<input type="text" name="email" placeholder="Digite o email" value="<?php echo $row_usuario['email']; ?>"><br><br>

			<a href= "apagarlogin.php"> <input type="submit"  value="Apagar"></a> 
		</form>
	</body>
</html>