/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledrawer;

import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.Stroke;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.AdjustmentEvent;
import java.awt.event.AdjustmentListener;
import java.awt.event.FocusEvent;
import java.awt.event.FocusListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.image.BufferedImage;
import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;

import java.util.TimerTask;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.imageio.ImageIO;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.swing.BorderFactory;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.Timer;

import javax.swing.filechooser.FileNameExtensionFilter;

/**
 *
 * @author mohammedzaman
 */
public class Controller implements ActionListener,KeyListener, FocusListener,AdjustmentListener,PropertyChangeListener{

    Model myModel;
    ControlView ControlView;
     Context context = new Context(new DrawFace(ControlView, myModel), ControlView, myModel);
    


    public Controller(Model model, ControlView view) {
        myModel = model;
       ControlView = view;
        ControlView.getDrawingPanel().addMouseListener(new MouseWatcher());
       

       

    }

             

    public void actionPerformed(ActionEvent ae) {
        if (ae.getSource() == ControlView.getBtnClear()) {
            ControlView.getDrawingPanel().clearDisplay();
        } else if (ae.getSource() == ControlView.getjButton1()) {
            ControlView.getColorBean().reset();
            myModel.setCurrentColor(ControlView.getColorBean().getCurrentColor());

            ControlView.getTxtThickness().setText("5");
            ControlView.getDrawingPanel().setCurrentThickness(5);
            ControlView.getDrawingPanel().setBackground(Color.white);

        } else if (ae.getSource() == ControlView.getTxtThickness()) {
            int thickness = Integer.parseInt(ControlView.getTxtThickness().getText());

            thickness = thickness < 1 || thickness > 40 ? 5 : thickness;
            ControlView.getDrawingPanel().setCurrentThickness(thickness);

        } else if (ae.getSource() == ControlView.getBtnSetBg()) {
            ControlView.getDrawingPanel().setBackground(myModel.getCurrentColor());
        } else if (ae.getSource() == ControlView.getBtnRestart()) {
                   ControlView.getClockDial().Restart();
           if (myModel.getLevel() == 0) {
                ControlView.getDrawingPanel().clearDisplay();
                context = new Context(new DrawHouse(ControlView, myModel), ControlView, myModel);
                context.executeStrategy();  
            } else if (myModel.getLevel() == 1){
               ControlView.getDrawingPanel().clearDisplay();
               context = new Context(new DrawFace(ControlView, myModel), ControlView, myModel);
               context.executeStrategy();
            }
           ControlView.getBtnRestart().setVisible(false);
     
          
        } else if (ae.getSource() == ControlView.getBtnExit()) {
           ControlView.getClockDial().stopClock();
           ControlView.getClockDial().setVisible(false);
           ControlView.setSize(800,500);
           ControlView.getBtnExit().setVisible(false);
           ControlView.getBtnRestart().setVisible(false);
          ControlView.getBtnPlayGame().setEnabled(true);
           ControlView.getBtnPlayGame().setText("Play game");
            ControlView.getPanDrawingArea().remove(ControlView.getHouseImg());
             ControlView.getPanDrawingArea().remove(ControlView.getFaceImg());
           
           

              
          
        } else if (ae.getSource() == ControlView.getBtnPlayGame()) {
           
            if(ControlView.getClockDial().getSeconds() > 0){
              ControlView.getClockDial().Restart();
            }
            ControlView.getBtnPlayGame().setEnabled(false);
            ControlView.getBtnExit().setVisible(true);
            ControlView.setExtendedState(JFrame.MAXIMIZED_BOTH);
            ControlView.getHouseImg().setVisible(true);
         
            if (myModel.getLevel() == 0) {
                ControlView.getPanDrawingArea().add(ControlView.getHouseImg(),"East");
                ControlView.getClockDial().setVisible(true);
                ControlView.getClockDial().setStop(45);
                ControlView.getBtnPlayGame().setText("Next");
                ControlView.getClockDial().StartClock();
                context = new Context(new DrawHouse(ControlView, myModel), ControlView, myModel);
                context.executeStrategy();
                ControlView.getBtnPlayGame().setEnabled(false);
            } else if (myModel.getLevel() == 1){
                ControlView.getPanDrawingArea().remove(ControlView.getHouseImg());
                ControlView.getPanDrawingArea().add(ControlView.getFaceImg(),"East");
                ControlView.getHouseImg().setVisible(false);
             ControlView.getFaceImg().setVisible(true);
                 ControlView.getBtnExit().setVisible(true);
                ControlView.getBtnPlayGame().setEnabled(false);
                   ControlView.getClockDial().setVisible(true);
                ControlView.getClockDial().Restart();
               context = new Context(new DrawFace(ControlView, myModel), ControlView, myModel);
               context.executeStrategy();
            }

        } else if (ControlView.getRadLine().isSelected()) {
            myModel.setCurrentShapeType(ShapeType.LINE);

        } else if (ControlView.getRadOval().isSelected()) {
            myModel.setCurrentShapeType(ShapeType.OVAL);

        } else if (ControlView.getRadTriangle().isSelected()) {
            myModel.setCurrentShapeType(ShapeType.TRIANGLE);

        } else if (ControlView.getRadSquare().isSelected()) {
            myModel.setCurrentShapeType(ShapeType.SQUARE);

        } else if (ae.getSource() == ControlView.getTxtThickness()) {
            if (!ControlView.getTxtThickness().getText().equals("")) {
                handleThickness();
            }
        }

        if (ae.getSource() == ControlView.getBtnRight()) {
            ControlView.getDrawingPanel().rotate(90);
        } else if (ae.getSource() == ControlView.getBtnLeft()) {
            ControlView.getDrawingPanel().rotate(-90);
        }
        
       
        
      

    }

    private void handleThickness() {
        
       if( ControlView.getTxtThickness().getText().matches("[0-9]+") == true){
        int thickness = Integer.parseInt(ControlView.getTxtThickness().getText());
        ControlView.getLblNumOnly().setText("");
        thickness = thickness < 1 || thickness > 40 ? 5 : thickness;
        myModel.setCurrentThickness(thickness);
       }else {
         ControlView.getLblNumOnly().setText("only Numbers");
         ControlView.getLblNumOnly().setForeground(Color.red);
       }

    }

    

    
  
    
    @Override
    public void keyReleased(KeyEvent e) {
        if (e.getSource() == ControlView.getTxtThickness()) {
            if (!ControlView.getTxtThickness().getText().equals("")) {
                handleThickness();
            }
        }

    }

    @Override
    public void focusLost(FocusEvent e) {
        if (e.getSource() == ControlView.getTxtThickness()) {
            if (!ControlView.getTxtThickness().getText().equals("")) {
                handleThickness();
            }
        }

    }

    @Override
    public void adjustmentValueChanged(AdjustmentEvent e) {
   
    }

    @Override
    public void propertyChange(PropertyChangeEvent evt) {
     if (evt.getPropertyName().equals("color")) // just when setting property changes
       myModel.setCurrentColor(ControlView.getColorBean().getCurrentColor());
       else if(evt.getPropertyName().equals("brightness")){
       ControlView.getDrawingPanel().setCurrentBrightness(ControlView.getColorBean().getBrightness());
       } 
    }


   

   
    

    private class MouseWatcher extends MouseAdapter {

        public void mousePressed(MouseEvent e) {
   ControlView.getDrawingPanel().setCurrentRotation(0);
            ShapeFactory factory = new ShapeFactory();
          
            myModel.shapes = new ArrayList<>();

            // reset the rotation to 0 otherwise things get messy.
            myModel.setCurrentRotation(0);

            if (myModel.getCurrentPoints() == null) { // must be starting a new shape
                myModel.currentPoints = new ArrayList<>();
                Point firstPoint = new Point();
                firstPoint.x = e.getX();
                firstPoint.y = e.getY();
                myModel.currentPoints.add(firstPoint);

            } else { // shape must have already been started
                // decide what to do based on the current shape
                switch (myModel.getCurrentShapeType()) {
                    case LINE:
                        Point nextPoints = new Point();
                        nextPoints.x = e.getX();
                        nextPoints.y = e.getY();
                        myModel.currentPoints.add(nextPoints);
                        if (myModel.getCurrentPoints().size() == 2) {
                            Shape st = factory.getShape(myModel.getCurrentPoints(), myModel.getCurrentColor(), myModel.getCurrentThickness(), ShapeType.LINE);
                            ControlView.getDrawingPanel().shapes.add(st);
                            myModel.shapes.add(st);
                            myModel.currentPoints = null;

                            break;
                        }
                        break;
                    case OVAL: // Draw the oval
                        Point ovalPoint = new Point();
                        ovalPoint.x = e.getX();
                        ovalPoint.y = e.getY();
                        myModel.currentPoints.add(ovalPoint);
                        if (myModel.getCurrentPoints().size() == 2) { // 3 points so must be complete triangle
                            Shape st = factory.getShape(myModel.getCurrentPoints(), myModel.getCurrentColor(), myModel.getCurrentThickness(), ShapeType.OVAL);
                            myModel.shapes.add(st);
                            ControlView.getDrawingPanel().shapes.add(st);
                            myModel.setCurrentPoints(null);
                            break;
                        }
                        break;
                    case TRIANGLE: // May or may not have finished the triangle
                        Point nextPoint = new Point();
                        nextPoint.x = e.getX();
                        nextPoint.y = e.getY();
                        myModel.currentPoints.add(nextPoint);
                        if (myModel.getCurrentPoints().size() == 3) { // 3 points so must be complete triangle
                            Shape st = factory.getShape(myModel.getCurrentPoints(), myModel.getCurrentColor(), myModel.getCurrentThickness(), ShapeType.TRIANGLE);
                            myModel.shapes.add(st);
                            ControlView.getDrawingPanel().shapes.add(st);
                            myModel.setCurrentPoints(null);

                            break;
                        }
                        break;
                    case SQUARE: // May or may not have finished the triangle

                        Point SquarePoint = new Point();
                        SquarePoint.x = e.getX();
                        SquarePoint.y = e.getY();
                        myModel.currentPoints.add(SquarePoint);

                        if (myModel.getCurrentPoints().size() == 4) { // 4  points so must be complete Square
                            Shape st = factory.getShape(myModel.getCurrentPoints(), myModel.getCurrentColor(), myModel.getCurrentThickness(), ShapeType.SQUARE);
                            myModel.shapes.add(st);
                            ControlView.getDrawingPanel().shapes.add(st);

                            myModel.setCurrentPoints(null);
                            break;
                        }
                        break;

                }
            }
            ControlView.getDrawingPanel().setCurrentColor(myModel.getCurrentColor());
            ControlView.getDrawingPanel().setCurrentPoints(myModel.getCurrentPoints());
            ControlView.getDrawingPanel().repaint(); // causes paintComponent() to be called

        }

    }
    


    @Override
    public void keyTyped(KeyEvent e) {
        // throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void keyPressed(KeyEvent e) {
        //   throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void focusGained(FocusEvent e) {
        //  throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
  
  
    
   
 
     public BufferedImage getImage(String pic) throws IOException{
        BufferedImage wPic = ImageIO.read(this.getClass().getResource(pic));
         return wPic;    
     }
  
}
