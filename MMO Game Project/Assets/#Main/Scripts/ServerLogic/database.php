<?php
	$host = "localhost"; // Host name 
	$db_username = "root"; // Mysql username 
	$db_password = ""; // Mysql password 
	$db_name = "mmo_game"; // Database name 

	$mysqli_conection = mysqli_connect($host, $db_username, $db_password, $db_name)or die("cannot connect"); 
?>