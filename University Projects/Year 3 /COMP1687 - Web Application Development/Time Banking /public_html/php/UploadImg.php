<?php
session_start();
$ID1 = $_SESSION["id"];
$ID = str_replace(array('[', ']'), '', $ID1);



$imgNameEr = "";
$altNameErr = "";
if(isset($_POST["submit"])){
     if($_POST['imgName'] == ""){
     $imgNameErr = "*";
     }
     if($_POST['altName'] == ""){
     $altNameErr = "*"; 
     }else{
      
     
     $notify ="";
     $check = getimagesize($_FILES["image"]["tmp_name"]);
      $check = mysqli_query($conn, "select * from images where PostID ='$ID'");
        $checkrows = mysqli_num_rows($check);


        if ($checkrows != 6) {
     if($check !== false){
        $image = $_FILES['image']['tmp_name'];
        $imgContent = addslashes(file_get_contents($image));
        $imgName = $_POST['imgName'];
        $imgAlt= $_POST['altName'];
        $dataTime = date("Y-m-d H:i:s");
         
   /*   $stmt = $conn->prepare("INSERT into images (PostID,image,created,imgName,imgAlt) VALUES (?,?,?,?)");
        $stmt->bind_param("ibsss",$ID,$imgContent,$dataTime,$imgName,$imgAlt);

       // set parameters and execute
        $stmt->execute();
        $stmt->close();
        $conn->close(); */

     
      

    
        //Insert image content into database
        $insert = $conn->query("INSERT into images (PostID,image,created,imgName,imgAlt) VALUES ('$ID','$imgContent', '$dataTime','$imgName','$imgAlt')");

        if($insert){
            $notify = "File uploaded successfully.";
             header('Location: ' . "MyPosts.php");
        }else{
            $notify = "File upload failed, please try again.";
        
        } 
         
           }else{
        $notify = "Please select an image file to upload.";
    
         }
             }
        
else{
       $notify = "Max Image Capacity reached <br> Delete an Image" ;
     }
     }
         
     }

    
?>