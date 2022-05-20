<!DOCTYPE html>
<html>
<bg-color="#	
"
<center>
<?php
 $preco = 20;
 if ($preco >= 10 && $preco <=50)
 {
	 echo "Aumento de 10%";
 }
 else if($preco >= 51 && $preco <=100)
 {
	 echo "Aumento de 8%";
 }
 else if ($preco >100)
 {
	 echo"aumento de 6%";
 }
 else if ($preco <10 )
 {
	 echo"Valores não cadastrados."
 }
 ?>
 </html>