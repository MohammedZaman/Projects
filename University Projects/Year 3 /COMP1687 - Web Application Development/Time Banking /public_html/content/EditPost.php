<?php include 'php/EditPost.php'; ?>


<?php $post = mysqli_fetch_assoc($posts); ?>
<form method="Post" class="formUpdate">
  <div class="group">
      <input class="inputOpen" required name="taskType" type="text" value =" <?=$post['TaskType']?>"><span class="highlight"></span><span class="bar"></span>
      <p class="error" style="display: inline-block;"><?php echo $tasktypeErr;?></p>
     <label>Task Type</label>
  </div>
    
  <div class="group">
    <input value =" <?=$post['SkillsReq']?>"  required class="inputOpen" name="skillsReq" type="text"><span class="highlight"></span><span class="bar"></span>
      <p class="error" style="display: inline-block;"><?php echo $skillReqErr;?></p>
    <label>Skills Required</label>
  </div>
    
    <div class="group">
    <input class="inputOpen" required value =" <?=$post['TaskLocation']?>" name="taskLoc" type="text"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;"><?php echo $taskLocErr;?></p>
    <label>Task Location</label>
  </div>
    
       <div class="group">
    <input class="inputOpen" required value =" <?=$post['CreditAwarded']?>" name="credit"  maxlength="3" type="text"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;"><?php echo $creditErr;?></p>
    <label>Credits Awarded</label>
  </div>
    
   <div class="group">
    <label>Status</label>
    <span class="custom-dropdown big">
    <select name="status">
        
        <?php
        $open = "Open";
        $openNum = 0;
        $completed = "Completed";
        $completedNum = 1;
        if($post['Status'] == 0){
        echo "<option value=".$openNum.">".$open."</option>";
        echo "<option value=".$completedNum.">".$completed."</option>";    
        }elseif($post['Status'] == 1){
        echo "<option value=".$completedNum.">".$completed."</option>";
        echo "<option value=".$openNum.">".$open."</option>";
        }
        
        ?>
    </select>
</span>
        <p class="error" style="display: inline-block;"><?php echo $StatusErr;?></p>
</div>
    
  <button style="margin-top:20px;" type="submit" value="<?=$ID?>" name="update" class="button buttonRed">Update<div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
    
   <p style="color:red;"> <?php echo $notify; ?></p>
</form>