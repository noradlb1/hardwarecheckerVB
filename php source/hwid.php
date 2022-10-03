<?php
	/*
	 * Part of hardwarechecker demo by gigajew
	 */
	 
	$hardwareList = getcwd().'/hardware-ids.txt';
	$valid = false;
	
	if (isset($_GET['hwid']) && !empty($_GET['hwid']))
	{
		$id = trim($_GET['hwid']);
		$handle = fopen($hardwareList, 'r');
		while (($buffer = fgets($handle)) !== false) {
			if (strpos($buffer, $id) !== false) {
				$valid = true;
				break;
			}      
		}
		fclose($handle);
		
		// optionally set cookies to remember user session etc. if valid
		// if ($valid) ....
	}
	
	// print byte (valid or invalid) 0x01, 0x00
	header('Content-Type: application/octet-stream');
	header('Content-Transfer-Encoding: binary');
	header('Expires: 0');
	header('Cache-Control: must-revalidate, post-check=0, pre-check=0');
	header('Pragma: public');
	ob_clean();
	flush();
	print(
		pack('C', $valid)
	);
	
	exit;
?>