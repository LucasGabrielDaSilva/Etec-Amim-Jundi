<?php
$servidor = "localhost";
$usuario = "root";
$senha = "";
$banco_de_dados = "tcc";

// Conexão com o banco de dados
$conn = new mysqli($servidor, $usuario, $senha, $banco_de_dados);

// Verificar a conexão
if ($conn->connect_error) {
    die("Falha na conexão: " . $conn->connect_error);
}

// Recupere os dados do formulário
$nome = $_POST['nome'];
$telefone = $_POST['telefone'];
$email = $_POST['email'];
$mensagem = $_POST['mensagem'];

// Inserir dados no banco de dados
$sql = "INSERT INTO contato (nome,telefone, email, mensagem) VALUES ('$nome','$telefone', '$email', '$mensagem')";

if ($conn->query($sql) === TRUE) {
    echo '<link rel="stylesheet" type="text/css" href="css/estilo.css">';
    
    // Exiba a mensagem de sucesso com a classe de estilo
    echo '<div class="success-message">Dados inseridos com sucesso.</div>';

    echo "<script>
    setTimeout(function() {
        window.location = 'contact.html';
    }, 2000); // 2000 milissegundos (2 segundos) de atraso
</script>";
} else {
    echo "Erro: " . $sql . "<br>" . $conn->error;
}

// Feche a conexão
$conn->close();
?>
