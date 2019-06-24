package simpledrawer;

import java.io.File;
import java.util.HashSet;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.swing.JOptionPane;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author mohammedzaman
 */
public class DrawFace implements Strategy{

ControlView ControlView;
Model myModel;
 Thread thread;
 
public DrawFace(ControlView ControlView,Model myModel){
    this.ControlView = ControlView ;
    this.myModel = myModel;
   
}
 
HashSet gameSquare = new HashSet();
HashSet gameTriangle= new HashSet();
HashSet gameOval= new HashSet();
HashSet gameLine= new HashSet();
    
    @Override
    public void CheckShapes(ControlView ControlView,Model myModel) {
        List<Shape> shapes = myModel.getShapes();
        
   if(gameOval.size() == 3 && gameTriangle.size() == 2 && gameLine.size() == 1){
      ControlView.getClockDial().suspend();
      playSound(1);
    JOptionPane.showMessageDialog(null,
                        "you won Your time was " + ControlView.getClockDial().getSeconds() + " Seconds" ,
                        "You Won",
                        JOptionPane.DEFAULT_OPTION);
    gameSquare.clear();
    gameTriangle.clear();
    gameOval.clear();
    gameLine.clear();
    ControlView.getDrawingPanel().clearDisplay();
    thread.stop();
 


    
 
   }
   // loose
   if(ControlView.getClockDial().getSeconds() == 45){
       playSound(0);
    JOptionPane.showMessageDialog(null,
                        "you Lost Try again " ,
                        "You Lost",
                        JOptionPane.DEFAULT_OPTION);
 
   ControlView.getClockDial().suspend();
   ControlView.getBtnRestart().setVisible(true);
   
    thread.stop();
  
  
    
   }
     for (Shape shape : shapes) {

         if (shape.getShapeType() == ShapeType.SQUARE) {  
             gameSquare.add(shape);
             gameSquare.size();     
         }
         
         if (shape.getShapeType() == ShapeType.TRIANGLE) {  
             gameTriangle.add(shape);
             gameTriangle.size();     
         }
         
          if (shape.getShapeType() == ShapeType.OVAL) {  
             gameOval.add(shape);
             gameOval.size();     
         }
          
            if (shape.getShapeType() == ShapeType.LINE) {  
             gameLine.add(shape);
             gameLine.size();     
         }
         
     }
    }
    
    public void restartClock(ControlView view){
        view.getClockDial().Restart();   
    
    }

    @Override
    public void run() {
             while (true) {
         
        
     CheckShapes(ControlView,myModel); 
      try {
       Thread.sleep(50);
      } catch (InterruptedException e) {
        e.printStackTrace();
      }
      }
    }
    
@Override
     public void startSearch(){
      thread = new Thread(this);
      thread.start();
     
   
    }
     
  


  

  
    
}
