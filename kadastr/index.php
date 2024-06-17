<?php session_start();


			$link = mysql_connect("localhost", "admin", "admin") or die 
			("Не удаётся соединиться с хостом");
			mysql_select_db ("web") or die ("Не удаётся соединиться с базой "); 
			
			if (isset($_POST['submit_1']))
			{
			
			$F_1 = $_POST['F_1'];
			$F_2 = $_POST['F_2'];
			$F_3 = $_POST['F_3'];
			$F_4 = $_POST['F_4'];
			$F_5 = $_POST['F_5'];
			$F_6 = $_POST['F_6_3'].'-'.$_POST['F_6_2'].'-'.$_POST['F_6_1'];
			$F_7 = $_POST['F_7'];
			$F_8 = $_POST['F_8'];
			$F_9 = $_POST['F_9'];
			$F_10 = $_POST['F_10'];
			$F_11 = $_POST['F_11_3'].'-'.$_POST['F_11_2'].'-'.$_POST['F_11_1'];
			$F_12 = $_POST['F_12'];
			
					
			
			$query = "INSERT INTO ernd (nomer_kuvd, adres_hd, name_d, kol_e, k0l_l, date_pdom, naprav_doc, poluch_doc, naprav_doc2, poluch_doc2, date_vid, primech) 
			VALUES ('{$F_1}', '{$F_2}', '{$F_3}', '{$F_4}', '{$F_5}', '{$F_6}', '{$F_7}', '{$F_8}', '{$F_9}', '{$F_10}', '{$F_11}', '{$F_12}')";                       
			$result = mysql_query($query) or die(mysql_error());			
			
			
			$ip_d = date("Y-m-d");
			$ip_1=$_SERVER['REMOTE_ADDR'];
			
			mysql_query("insert into persons_ip (ip, date_p) values ('{$ip_1}','{$ip_d}')");
			}
			
			if (isset($_POST['submit_2']))
			{
			
			$FF_1 = $_POST['FF_1'];
			$FF_2 = $_POST['FF_2'];
			$FF_3 = $_POST['FF_3'];
			$FF_4 = $_POST['FF_4'];
			$FF_5 = $_POST['FF_5'];
			$FF_6 = $_POST['FF_6_3'].'-'.$_POST['FF_6_2'].'-'.$_POST['FF_6_1'];
			$FF_7 = $_POST['FF_7'];
			$FF_8 = $_POST['FF_8'];
			$FF_9 = $_POST['FF_9'];
			$FF_10 = $_POST['FF_10'];
			$FF_11 = $_POST['FF_11_3'].'-'.$_POST['FF_11_2'].'-'.$_POST['FF_11_1'];
			$FF_12 = $_POST['FF_12'];
			
					
			
			//mysql_query("update users set status = 'mod' where email = '{$_POST['email_user']}'");
			
			$query = "update ernd set adres_hd='{$FF_2}', name_d='{$FF_3}', kol_e='{$FF_4}', k0l_l='{$FF_5}', date_pdom='{$FF_6}', naprav_doc='{$FF_7}', poluch_doc='{$FF_8}', naprav_doc2='{$FF_9}', poluch_doc2='{$FF_10}', date_vid='{$FF_11}', primech='{$FF_12}' where nomer_kuvd='{$FF_1}'";                       
			$result = mysql_query($query) or die(mysql_error());			
			
			$ip_d = date("Y-m-d");
			$ip_1=$_SERVER['REMOTE_ADDR'];
			
			mysql_query("insert into persons_ip (ip, date_p) values ('{$ip_1}','{$ip_d}')");
			}
			
			if (isset($_POST['clear_tbl'])) 
			{  
		
			mysql_query("truncate table ernd");
			   
			$ip_d = date("Y-m-d");
			$ip_1=$_SERVER['REMOTE_ADDR'];
			
			mysql_query("insert into persons_ip (ip, date_p) values ('{$ip_1}','{$ip_d}')");
			
			}
			
			
			if (isset($_POST['delete_profile'])) 
			{			
			mysql_query("delete from ernd where nomer_kuvd = '{$_POST['num_user']}'");
			
			$ip_d = date("Y-m-d");
			$ip_1=$_SERVER['REMOTE_ADDR'];
			
			mysql_query("insert into persons_ip (ip, date_p) values ('{$ip_1}','{$ip_d}')");
			
			//mysql_close($link);
			//header("Location: index.php");
			}
			
			mysql_close($link);

?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<meta http-equiv="content-type" content="application/xhtml+xml; charset=windows-1251" />
<title>Единый реестр невостребованных документов</title>
<link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>

<div id="container">
	
	<!-- ### Header ### -->
	
	<!-- ### Content ### -->
	
	<div id="contentcontainer">
		
		<div id="content">
	
		<!-- ### Post Entry Begin ###  -->
		
		<div class="post">
					
			<div class="entry">

			<?php
			
			//Комментарий
			
			/* Комментарий
			Комментарий */
			
			
			$link = mysql_connect("localhost", "admin", "admin") or die 
			("Не удаётся соединиться с хостом");
			mysql_select_db ("web") or die ("Не удаётся соединиться с базой "); 

			
			$sql = mysql_query("select * from ernd order by id");
			if(!$sql)
			{
			die("Возникла ошибка - ".mysql_error()."<br>");
			} 
			
						
			if (mysql_num_rows($sql) > 0) {
			echo '<h2>Единый реестр невостребованных документов:</h2><br><br>';
			echo '<table border="1"><tr><th>Номер КУВД</th><th>Адрес хранения документов</th><th>Наименование документа</th><th>Количество экземпляров</th><th>Количество листов</th><th>Дата получения документов от МФЦ</th><th>Направление документов на выдачу в филиал субъекта Российской Федерации, в который обратился заявитель (дата, наименование филиала, идентификатор почтового отправления)</th><th>Получение документов для выдачи из филиала субъекта Российской Федерации – места хранения документов (дата, наименование филиала)</th><th>Направление документов на выдачу в территориальное подразделение филиала, в которое обратился заявитель (дата, наименование филиала, идентификатор почтового отправления)</th><th>Получение документов для выдачи из территориального подразделения филиала – места хранения документов (дата, территориальное подразделение филиала)</th><th>Дата выдачи документов Заявителю</th><th>Примечание</th></tr>';
			while ($x = mysql_fetch_array($sql)) {
			echo  '<tr><td>'.$x['nomer_kuvd'].'</td><td>'.$x['adres_hd'].'</td><td>'.$x['name_d'].'</td><td>'.$x['kol_e'].'</td><td>'.$x['k0l_l'].'</td><td>'.$x['date_pdom'].'</td><td>'.$x['naprav_doc'].'</td><td>'.$x['poluch_doc'].'</td><td>'.$x['naprav_doc2'].'</td><td>'.$x['poluch_doc2'].'</td><td>'.$x['date_vid'].'</td><td>'.$x['primech'].'</td></tr>';
			}
			echo '</table><br>'; } else { echo '<h2>Единый реестр невостребованных документов пуст</h2>'; }

			echo '
			<h2>Удаление</h2>
			
			<form action="index.php" method="post">
			<table>
			<tr>
			
			<td>
			Введите номер КУВД: <br>
			
			<textarea name="num_user" cols="41" rows="5" required></textarea>
			</td>
			
			</tr>
			
			<tr>
			
			<td>
			<br>
			<input type="submit" value="Удалить аккаунт" name="delete_profile"/> 
			</td>
			</tr>
			
			<tr>
			<td>
			<br>
			<input type="reset" value="Очистить">
			</td>
			
			</tr>
			</table>
			</form>
			
			
			<h2>Очистка таблицы:</h2>
			<form action="index.php" method="post">
			
			<br><input type="submit" value="Очистить таблицу" name="clear_tbl"/>
			
			</form>
			
			
			';
			
			
			echo '
			<h2>Добавление записи</h2>
			
			<form action="index.php" method="POST">
			
			<p>Номер КУВД:<br><textarea name="F_1" cols="41" rows="5" required></textarea></p>
						
			<p>Адрес хранения документов:<br><textarea name="F_2" cols="41" rows="5" required></textarea></p>
			
			<p>Наименование документа:<br><textarea name="F_3" cols="41" rows="5" required></textarea></p>
			
			<p>Количество экземпляров:<br><textarea name="F_4" cols="41" rows="5" required></textarea></p>
			
			<p>Количество листов:<br><textarea name="F_5" cols="41" rows="5" required></textarea></p>	

			<p>Дата получения документов от МФЦ:<br></p>
			
			<p>Введите день:
			
			<select name="F_6_1">
			
			<option selected value="1">01</option>
			<option value="2">02</option>
			<option value="3">03</option>
			<option value="4">04</option>
			<option value="5">05</option>
			<option value="6">06</option>
			<option value="7">07</option>
			<option value="8">08</option>
			<option value="9">09</option>
			<option value="10">10</option>
			<option value="11">11</option>
			<option value="12">12</option>
			<option value="13">13</option>
			<option value="14">14</option>
			<option value="15">15</option>
			<option value="16">16</option>
			<option value="17">17</option>
			<option value="18">18</option>
			<option value="19">19</option>
			<option value="20">20</option>
			<option value="21">21</option>
			<option value="22">22</option>
			<option value="23">23</option>
			<option value="24">24</option>
			<option value="25">25</option>
			<option value="26">26</option>
			<option value="27">27</option>
			<option value="28">28</option>
			<option value="29">29</option>
			<option value="30">30</option>
			<option value="31">31</option>
			
			</select>
			</p>
			
			<p>Введите месяц:
			
			<select name="F_6_2">
			
			<option selected value="1">01</option>
			<option value="2">02</option>
			<option value="3">03</option>
			<option value="4">04</option>
			<option value="5">05</option>
			<option value="6">06</option>
			<option value="7">07</option>
			<option value="8">08</option>
			<option value="9">09</option>
			<option value="10">10</option>
			<option value="11">11</option>
			<option value="12">12</option>
						
			</select>
			</p>
			
			
			<p>Введите год:
			<input type="text" name="F_6_3" />
			</p>
			
			
			<p>Направление документов на выдачу в филиал субъекта Российской Федерации, в который обратился заявитель (дата, наименование филиала, идентификатор почтового отправления):<br><textarea name="F_7" cols="41" rows="5" required></textarea></p>
			
			<p>Получение документов для выдачи из филиала субъекта Российской Федерации – места хранения документов (дата, наименование филиала):<br><textarea name="F_8" cols="41" rows="5" required></textarea></p>
			
			<p>Направление документов на выдачу в территориальное подразделение филиала, в которое обратился заявитель (дата, наименование филиала, идентификатор почтового отправления):<br><textarea name="F_9" cols="41" rows="5" required></textarea></p>
			
			<p>Получение документов для выдачи из территориального подразделения филиала – места хранения документов (дата, территориальное подразделение филиала):<br><textarea name="F_10" cols="41" rows="5" required></textarea></p>
			
			<p>Дата выдачи документов Заявителю:<br></p>
			
			<p>Введите день:
			
			<select name="F_11_1">
			
			<option selected value="1">01</option>
			<option value="2">02</option>
			<option value="3">03</option>
			<option value="4">04</option>
			<option value="5">05</option>
			<option value="6">06</option>
			<option value="7">07</option>
			<option value="8">08</option>
			<option value="9">09</option>
			<option value="10">10</option>
			<option value="11">11</option>
			<option value="12">12</option>
			<option value="13">13</option>
			<option value="14">14</option>
			<option value="15">15</option>
			<option value="16">16</option>
			<option value="17">17</option>
			<option value="18">18</option>
			<option value="19">19</option>
			<option value="20">20</option>
			<option value="21">21</option>
			<option value="22">22</option>
			<option value="23">23</option>
			<option value="24">24</option>
			<option value="25">25</option>
			<option value="26">26</option>
			<option value="27">27</option>
			<option value="28">28</option>
			<option value="29">29</option>
			<option value="30">30</option>
			<option value="31">31</option>
			
			</select>
			</p>
			
			<p>Введите месяц:
			
			<select name="F_11_2">
			
			<option selected value="1">01</option>
			<option value="2">02</option>
			<option value="3">03</option>
			<option value="4">04</option>
			<option value="5">05</option>
			<option value="6">06</option>
			<option value="7">07</option>
			<option value="8">08</option>
			<option value="9">09</option>
			<option value="10">10</option>
			<option value="11">11</option>
			<option value="12">12</option>
						
			</select>
			</p>
			
			
			<p>Введите год:
			<input type="text" name="F_11_3" />
			</p>
			
			<p>Примечание:<br><textarea name="F_12" cols="41" rows="5" required></textarea></p>
			
			<p><input type="submit" value="Добавить запись" name="submit_1" ></p>
			
			<p><input type="reset" value="Очистить"></p>
			</form>
			';
			
			
			
			
			echo '
			<h2>Редактирование записи</h2>
			
			<form action="index.php" method="POST">
			
			<p><h2>Введите номер КУВД записи, которая будет отредактированна:</h2><br><textarea name="FF_1" cols="41" rows="5" required></textarea></p>
						
			<p><h2>Введите новые значения полей:</h2><br>Адрес хранения документов:<br><textarea name="FF_2" cols="41" rows="5" required></textarea></p>
					
					
			<p>Наименование документа:<br><textarea name="FF_3" cols="41" rows="5" required></textarea></p>
			
			<p>Количество экземпляров:<br><textarea name="FF_4" cols="41" rows="5" required></textarea></p>
			
			<p>Количество листов:<br><textarea name="FF_5" cols="41" rows="5" required></textarea></p>	

			<p>Дата получения документов от МФЦ:<br></p>
			
			<p>Введите день:
			
			<select name="FF_6_1">
			
			<option selected value="1">01</option>
			<option value="2">02</option>
			<option value="3">03</option>
			<option value="4">04</option>
			<option value="5">05</option>
			<option value="6">06</option>
			<option value="7">07</option>
			<option value="8">08</option>
			<option value="9">09</option>
			<option value="10">10</option>
			<option value="11">11</option>
			<option value="12">12</option>
			<option value="13">13</option>
			<option value="14">14</option>
			<option value="15">15</option>
			<option value="16">16</option>
			<option value="17">17</option>
			<option value="18">18</option>
			<option value="19">19</option>
			<option value="20">20</option>
			<option value="21">21</option>
			<option value="22">22</option>
			<option value="23">23</option>
			<option value="24">24</option>
			<option value="25">25</option>
			<option value="26">26</option>
			<option value="27">27</option>
			<option value="28">28</option>
			<option value="29">29</option>
			<option value="30">30</option>
			<option value="31">31</option>
			
			</select>
			</p>
			
			<p>Введите месяц:
			
			<select name="FF_6_2">
			
			<option selected value="1">01</option>
			<option value="2">02</option>
			<option value="3">03</option>
			<option value="4">04</option>
			<option value="5">05</option>
			<option value="6">06</option>
			<option value="7">07</option>
			<option value="8">08</option>
			<option value="9">09</option>
			<option value="10">10</option>
			<option value="11">11</option>
			<option value="12">12</option>
						
			</select>
			</p>
			
			
			<p>Введите год:
			<input type="text" name="FF_6_3" />
			</p>
			
			<p>Направление документов на выдачу в филиал субъекта Российской Федерации, в который обратился заявитель (дата, наименование филиала, идентификатор почтового отправления):<br><textarea name="FF_7" cols="41" rows="5" required></textarea></p>
			
			<p>Получение документов для выдачи из филиала субъекта Российской Федерации – места хранения документов (дата, наименование филиала):<br><textarea name="FF_8" cols="41" rows="5" required></textarea></p>
			
			<p>Направление документов на выдачу в территориальное подразделение филиала, в которое обратился заявитель (дата, наименование филиала, идентификатор почтового отправления):<br><textarea name="FF_9" cols="41" rows="5" required></textarea></p>
			
			<p>Получение документов для выдачи из территориального подразделения филиала – места хранения документов (дата, территориальное подразделение филиала):<br><textarea name="FF_10" cols="41" rows="5" required></textarea></p>
			
			<p>Дата выдачи документов Заявителю:<br></p>
			
			<p>Введите день:
			
			<select name="FF_11_1">
			
			<option selected value="1">01</option>
			<option value="2">02</option>
			<option value="3">03</option>
			<option value="4">04</option>
			<option value="5">05</option>
			<option value="6">06</option>
			<option value="7">07</option>
			<option value="8">08</option>
			<option value="9">09</option>
			<option value="10">10</option>
			<option value="11">11</option>
			<option value="12">12</option>
			<option value="13">13</option>
			<option value="14">14</option>
			<option value="15">15</option>
			<option value="16">16</option>
			<option value="17">17</option>
			<option value="18">18</option>
			<option value="19">19</option>
			<option value="20">20</option>
			<option value="21">21</option>
			<option value="22">22</option>
			<option value="23">23</option>
			<option value="24">24</option>
			<option value="25">25</option>
			<option value="26">26</option>
			<option value="27">27</option>
			<option value="28">28</option>
			<option value="29">29</option>
			<option value="30">30</option>
			<option value="31">31</option>
			
			</select>
			</p>
			
			<p>Введите месяц:
			
			<select name="FF_11_2">
			
			<option selected value="1">01</option>
			<option value="2">02</option>
			<option value="3">03</option>
			<option value="4">04</option>
			<option value="5">05</option>
			<option value="6">06</option>
			<option value="7">07</option>
			<option value="8">08</option>
			<option value="9">09</option>
			<option value="10">10</option>
			<option value="11">11</option>
			<option value="12">12</option>
						
			</select>
			</p>
			
			
			<p>Введите год:
			<input type="text" name="FF_11_3" />
			</p>
			
			<p>Примечание:<br><textarea name="FF_12" cols="41" rows="5" required></textarea></p>
			
			<p><input type="submit" value="Редактировать запись" name="submit_2" ></p>
			
			<p><input type="reset" value="Очистить"></p>
			</form>
			';
			
			
			mysql_close($link);
			
			?>
			
			</div>

			
		</div>

		<!-- ### Post Entry End ### -->

		<!-- ### Post Entry Begin ###  -->
		
		<!-- ### Post Entry End ###  -->
		
		</div>

		<!-- ### Sidebar Begin ### -->
		
		

		<!-- ### Sidebar End ### -->

	</div>
</div>	



</body>
</html>
