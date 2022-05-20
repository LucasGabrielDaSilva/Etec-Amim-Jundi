<!DOCTYPE html>
<html lang="pt-br">
<body bgcolor = "#48D1CC">
    <h1> <center> Consumo de Agua <p>
    <?php
        $Agua = 30; 

        if ($Agua <= 10)
    {
        echo "Tarifa minima de R$20,64";
    }

    else if ($Agua > 10)
    {
    echo "A sua tarifa deverá ser calculada";
    }

    ?>

</body>
</html>