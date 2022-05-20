<!DOCTYPE html>
<html lang="pt-br">
<body bgcolor = "#48D1CC">
    <h1> <center> Salario <p>
    <?php
        $Salario = 1500; 

        if ($Salario >= 5000)
    {
        echo "Aumento de 8 %";
    }

    else if ($Salario >= 2000 && $Salario < 5000)
    {
    echo "Aumento de 10 %";
    }
    else if ($Salario >= 800 && $Salario < 2000)
    {
    echo "Aumento de 12 %";
    }
    else if ($Salario < 800)
    {
    echo "Valor inválido!";
    }

    ?>

</body>
</html>