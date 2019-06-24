<?php


# Read background image
$image = ImageCreateFromPng ("../img/capcha.png");

# Randomise the text colour
$red = rand(80,130);
$green = rand(80,130);
$blue = 320 -$red - $green;
$textColour = ImageColorAllocate($image, $red, $green, $blue);

# Randomly select a character string
$charArray = array('a','b','c','d','e','f','g','h','j','k','m','n','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','J','K','L','M','N','P','Q','R','T','U','V','W','X','Y','Z','2','3','4','6','7','8','9');
shuffle($charArray);
$captchaString = $charArray[0];
for ($i=1; $i<5; $i++) $captchaString .= ' ' . $charArray[$i];
session_start();
$_SESSION["code"] = $captchaString;

# Edit the image
ImageString($image, 5, 10, 10, $captchaString, $textColour);

# Enlarge the image
$bigImage = imagecreatetruecolor(300, 80);
imagecopyresized($bigImage, $image, 0, 0, 0, 0, 300, 80, 100, 40);

# Output the image as a low quality JPEG
header("Content-Type: image/jpeg");
Imagejpeg($bigImage, NULL, 16);

# clean up
ImageDestroy($image);
ImageDestroy($bigImage);
?>