<?php session_start();


			$link = mysql_connect("localhost", "admin", "admin") or die 
			("�� ������ ����������� � ������");
			mysql_select_db ("web") or die ("�� ������ ����������� � ����� "); 
			
			if (isset($_POST['submit_1']))
			{
			
			$F_1 = $_POST['F_1'];
			$F_2 = $_POST['F_2'];
			$F_3 = $_POST['F_3'];
			$F_4 = $_POST['F_4'];
			$F_5 = $_POST['F_5'];
			//$F_6 = $_POST['F_6_3'].'-'.$_POST['F_6_2'].'-'.$_POST['F_6_1'];
			$F_6 = $_POST['F_6'];
			$F_7 = $_POST['F_7'];
			$F_8 = $_POST['F_8'];
			$F_9 = $_POST['F_9'];
			$F_10 = $_POST['F_10'];
			//$F_11 = $_POST['F_11_3'].'-'.$_POST['F_11_2'].'-'.$_POST['F_11_1'];
			$F_11 = $_POST['F_11'];
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
			//$FF_6 = $_POST['FF_6_3'].'-'.$_POST['FF_6_2'].'-'.$_POST['FF_6_1'];
			$FF_6 = $_POST['FF_6'];
			$FF_7 = $_POST['FF_7'];
			$FF_8 = $_POST['FF_8'];
			$FF_9 = $_POST['FF_9'];
			$FF_10 = $_POST['FF_10'];
			//$FF_11 = $_POST['FF_11_3'].'-'.$_POST['FF_11_2'].'-'.$_POST['FF_11_1'];
			$FF_11 = $_POST['FF_11'];
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
<title>������ ������ ���������������� ����������</title>
<link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>



			<?php
			
			//�����������
			
			/* �����������
			����������� */
			
			
			$link = mysql_connect("localhost", "admin", "admin") or die 
			("�� ������ ����������� � ������");
			mysql_select_db ("web") or die ("�� ������ ����������� � ����� "); 

			
			$sql = mysql_query("select * from ernd order by id");
			if(!$sql)
			{
			die("�������� ������ - ".mysql_error()."<br>");
			} 
			
						
			

			echo '
			
			
			<table width="90%" align="center">
			<tr>
			<td style="border: 0px;" valign="top" width="33%">
			
			<h2>��������</h2>
			
			<form style="font-size:14px;" action="index.php" method="post">
			<table>
			<tr>
			
			<td style="border: 0px;">
			������� ����� ����: <br>
			
			<textarea style="font-size:14px;" name="num_user" cols="41" rows="5" required></textarea>
			</td>
			
			</tr>
			
			<tr>
			
			<td style="border: 0px;">
			<br>
			<input style="font-size:14px;" type="submit" value="������� �������" name="delete_profile"/> 
			</td>
			</tr>
			
			<tr>
			<td style="border: 0px;">
			<br>
			<input style="font-size:14px;" type="reset" value="��������">
			</td>
			
			</tr>
			</table>
			</form>
			
			
			<h2>������� �������:</h2>
			<form action="index.php" method="post">
			
			<br><input style="font-size:14px;" type="submit" value="�������� �������" name="clear_tbl"/>
			
			</form>
			</td>		
			
			';
			
			
			echo '
			<td style="border: 0px;" valign="top" width="33%">
			
			<h2>���������� ������</h2>
			
			<form style="font-size:14px;" action="index.php" method="POST">
			
			<p>����� ����:<br><textarea style="font-size:14px;" name="F_1" cols="41" rows="5" required></textarea></p>
						
			<p>����� �������� ����������:<br><textarea style="font-size:14px;" name="F_2" cols="41" rows="5" required></textarea></p>
			
			<p>������������ ���������:<br><textarea style="font-size:14px;" name="F_3" cols="41" rows="5" required></textarea></p>
			
			<p>���������� �����������:<br><textarea style="font-size:14px;" name="F_4" cols="41" rows="5" required></textarea></p>
			
			<p>���������� ������:<br><textarea style="font-size:14px;" name="F_5" cols="41" rows="5" required></textarea></p>	

			<p>���� ��������� ���������� �� ���:<br></p>
			
			<p><input style="font-size:14px;" type="date" name="F_6" value="'.date("Y-m-d").'"><br></p>			
										
						
			<p>����������� ���������� �� ������ � ������ �������� ���������� ���������, � ������� ��������� ��������� (����, ������������ �������, ������������� ��������� �����������):<br><textarea style="font-size:14px;" name="F_7" cols="41" rows="5" required></textarea></p>
			
			<p>��������� ���������� ��� ������ �� ������� �������� ���������� ��������� � ����� �������� ���������� (����, ������������ �������):<br><textarea style="font-size:14px;" name="F_8" cols="41" rows="5" required></textarea></p>
			
			<p>����������� ���������� �� ������ � ��������������� ������������� �������, � ������� ��������� ��������� (����, ������������ �������, ������������� ��������� �����������):<br><textarea style="font-size:14px;" name="F_9" cols="41" rows="5" required></textarea></p>
			
			<p>��������� ���������� ��� ������ �� ���������������� ������������� ������� � ����� �������� ���������� (����, ��������������� ������������� �������):<br><textarea style="font-size:14px;" name="F_10" cols="41" rows="5" required></textarea></p>
			
			<p>���� ������ ���������� ���������:<br></p>
			
			<p><input style="font-size:14px;" type="date" name="F_11" value="'.date("Y-m-d").'"><br></p>
			
			<p>����������:<br><textarea style="font-size:14px;" name="F_12" cols="41" rows="5" required></textarea></p>
			
			<p><input style="font-size:14px;" type="submit" value="�������� ������" name="submit_1" ></p>
			
			<p><input style="font-size:14px;" type="reset" value="��������"></p>
			</form>
			</td>
			
			';
			
			
			
			
			echo '
			<td style="border: 0px;" valign="top" width="33%">
			<h2>�������������� ������</h2>
			
			<form style="font-size:14px;" action="index.php" method="POST">
			
			<p><h3>������� ����� ���� ������, ������� ����� ����������������:</h2><br><textarea style="font-size:14px;" name="FF_1" cols="41" rows="5" required></textarea></p>
						
			<p><h3>������� ����� �������� �����:</h2><br>����� �������� ����������:<br><textarea style="font-size:14px;" name="FF_2" cols="41" rows="5" required></textarea></p>
					
					
			<p>������������ ���������:<br><textarea style="font-size:14px;" name="FF_3" cols="41" rows="5" required></textarea></p>
			
			<p>���������� �����������:<br><textarea style="font-size:14px;" name="FF_4" cols="41" rows="5" required></textarea></p>
			
			<p>���������� ������:<br><textarea style="font-size:14px;" name="FF_5" cols="41" rows="5" required></textarea></p>	

			<p>���� ��������� ���������� �� ���:<br></p>
			
			<p><input style="font-size:14px;" type="date" name="FF_6" value="'.date("Y-m-d").'"><br></p>
			
			<p>����������� ���������� �� ������ � ������ �������� ���������� ���������, � ������� ��������� ��������� (����, ������������ �������, ������������� ��������� �����������):<br><textarea style="font-size:14px;" name="FF_7" cols="41" rows="5" required></textarea></p>
			
			<p>��������� ���������� ��� ������ �� ������� �������� ���������� ��������� � ����� �������� ���������� (����, ������������ �������):<br><textarea style="font-size:14px;" name="FF_8" cols="41" rows="5" required></textarea></p>
			
			<p>����������� ���������� �� ������ � ��������������� ������������� �������, � ������� ��������� ��������� (����, ������������ �������, ������������� ��������� �����������):<br><textarea style="font-size:14px;" name="FF_9" cols="41" rows="5" required></textarea></p>
			
			<p>��������� ���������� ��� ������ �� ���������������� ������������� ������� � ����� �������� ���������� (����, ��������������� ������������� �������):<br><textarea style="font-size:14px;" name="FF_10" cols="41" rows="5" required></textarea></p>
			
			<p>���� ������ ���������� ���������:<br></p>
			
			<p><input style="font-size:14px;" type="date" name="FF_11" value="'.date("Y-m-d").'"><br></p> 
			
			<p>����������:<br><textarea style="font-size:14px;" name="FF_12" cols="41" rows="5" required></textarea></p>
			
			<p><input style="font-size:14px;" type="submit" value="������������� ������" name="submit_2" ></p>
			
			<p><input style="font-size:14px;" type="reset" value="��������"></p>
			</form>
			
			</td>
			</tr>
			</table>
			
			';
			
			
			
			
			
			
			if (mysql_num_rows($sql) > 0) {
			echo '<div align="center"><h2>������ ������ ���������������� ����������:</h2><br><br></div>';
			echo '<table style="font-size:14px;border-collapse: collapse;background-color: #e8e8e8;" align="center" width="90%"><tr>
			<th style="border: 2px solid #aaaaaa;">����� ����</th>
			<th style="border: 2px solid #aaaaaa;">����� �������� ����������</th>
			<th style="border: 2px solid #aaaaaa;">������������ ���������</th>
			<th style="border: 2px solid #aaaaaa;">���������� �����������</th>
			<th style="border: 2px solid #aaaaaa;">���������� ������</th>
			<th style="border: 2px solid #aaaaaa;">���� ��������� ���������� �� ���</th>
			<th style="border: 2px solid #aaaaaa;">����������� ���������� �� ������ � ������ �������� ���������� ���������, � ������� ��������� ��������� (����, ������������ �������, ������������� ��������� �����������)</th>
			<th style="border: 2px solid #aaaaaa;">��������� ���������� ��� ������ �� ������� �������� ���������� ��������� � ����� �������� ���������� (����, ������������ �������)</th>
			<th style="border: 2px solid #aaaaaa;">����������� ���������� �� ������ � ��������������� ������������� �������, � ������� ��������� ��������� (����, ������������ �������, ������������� ��������� �����������)</th>
			<th style="border: 2px solid #aaaaaa;">��������� ���������� ��� ������ �� ���������������� ������������� ������� � ����� �������� ���������� (����, ��������������� ������������� �������)</th>
			<th style="border: 2px solid #aaaaaa;">���� ������ ���������� ���������</th>
			<th style="border: 2px solid #aaaaaa;">����������</th></tr>';
			while ($x = mysql_fetch_array($sql)) {
			echo  '<tr>
			<td style="border: 2px solid #aaaaaa;">'.$x['nomer_kuvd'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['adres_hd'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['name_d'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['kol_e'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['k0l_l'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['date_pdom'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['naprav_doc'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['poluch_doc'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['naprav_doc2'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['poluch_doc2'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['date_vid'].'</td>
			<td style="border: 2px solid #aaaaaa;">'.$x['primech'].'</td></tr>';
			}
			echo '</table><br>'; } else { echo '<div align="center"><h2>������ ������ ���������������� ���������� ����</h2></div>'; }
			
			mysql_close($link);
			
			?>
			




</body>
</html>
