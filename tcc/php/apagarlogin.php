<?php
session_start();
include_once("conexao.php");

$codigo = filter_input(INPUT_POST, 'codigo', FILTER_SANITIZE_NUMBER_INT);
if(!empty($codigo))
$result_usuario = "DELETE from  usuario WHERE codigo='$codigo'";
$resultado_usuario = mysqli_query($conn, $result_usuario);


if(mysqli_affected_rows($conn)){
	$_SESSION['msg'] = "<p style='color:green;'>Usuario excluido com sucesso</p>";
	header("Location: listalogin.php");
}else{
	$_SESSION['msg'] = "<p style='color:red;'>Usuario não foi excluido com sucesso</p>";
	header("Location: alteralogin.php?codigo=$codigo");
}