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
public class DrawHouse implements Strategy{
ControlView view;
Model model;
Thread thread;
public DrawHouse(ControlView ControlView,Model myModel){
this.model = myModel; 
this.view = ControlView;
}

 
HashSet gameSquare = new HashSet();
HashSet gameTriangle= new HashSet();
    
    @Override
    public void CheckShapes(ControlView ControlView,Model myModel) {
       
        List<Shape> shapes = myModel.getShapes();
   if(gameSquare.size() == 5 && gameTriangle.size() == 1 ){
          ControlView.getClockDial().suspend();  
              //  ControlView.getClockDial().stopClock();
      playSound(1);
    JOptionPane.showMessageDialog(null,
                        "you won Your time was " + ControlView.getClockDial().getSeconds() + " Seconds" ,
                        "You Won",
                        JOptionPane.DEFAULT_OPTION);
    gameSquare.clear();
    gameTriangle.clear();    
    ControlView.getDrawingPanel().clearDisplay();
    myModel.setLevel(1);
    ControlView.getBtnPlayGame().setEnabled(true);
     thread.stop();
    
   
  
   }
   // loose
   if(ControlView.getClockDial().getSeconds() == 45){
        playSound(0);
    JOptionPane.showMessageDialog(null,
                        "you Lost Try again " ,
                        "You Lost",
                        JOptionPane.DEFAULT_OPTION);
    ControlView.getBtnPlayGame().setEnabled(true);
    ControlView.getClockDial().suspend();
    gameSquare.clear();
    gameTriangle.clear(); 
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
         
     }
    }

    @Override
    public void run() {
             while (true) {
         
        
     CheckShapes(view,model); 
      try {
       Thread.sleep(500);
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
