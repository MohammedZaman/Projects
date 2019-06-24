/*
 * DrawingPanel.java
 *
 * @author Gill Windall
 *
 * A specialised JPanel used as the canvas for simple drawings.
 *
 * NOT created using the NetBeans GUI builder
 */
package simpledrawer;


import com.google.gson.Gson;
import java.awt.Color;
import java.awt.GradientPaint;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.Stroke;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.Reader;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.BorderFactory;
import javax.swing.JPanel;

public class DrawingPanel extends JPanel {


    private float currentBrightness = 1;
    private int currentRotation;
    private int currentThickness;

    public void setCurrentThickness(int currentThickness) {
        this.currentThickness = currentThickness;
    }

   
    private List<Point> currentPoints; // x and y points for shape being drawn
   
    public List<Shape> shapes;  // using a raw type - dangerous !!
    private  Color currentColor;
    
    /* Default constructor.  Sets default values for line colour, thickness 
     * and shape type.
     */


    /* Constructor used to create a DrawingPanel with a
     * specified line colour, thickness and shape type
     */
    public DrawingPanel() {
     
    
    

        // instantiate the ArrayList to store shapes
        shapes = new ArrayList<>();
   
    }

    /*
     * paint the drawing including all shapes drawn so far
     *
     * paintComponent() is invoked when repaint() is called and
     * when the GUI needs redrawing e.g. because it has been covered
     * by another window
     */
    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);

        // Graphics2D needed to set line thickness
        Graphics2D g2d = (Graphics2D) g;
        
        Stroke s = g2d.getStroke(); // save stroke to restore later

        // rotate the drawing by the current rotation amount
        double rotateTheta;
        rotateTheta = currentRotation * Math.PI / 180;
        g2d.rotate(rotateTheta, this.getWidth() / 2, this.getHeight() / 2);
 GradientPaint redtowhite = new GradientPaint(0, 0, Color.YELLOW, 350, 350,
        Color.blue);
 g2d.setPaint(redtowhite);
        // Loop though the ArrayList drawing
        // all the shapes stored in it
        DrawerFactory drawerFactory = new DrawerFactory();
        for (Object aShape : shapes ) {

            // draw the correct sort of shape: line or oval or triangle
            if (aShape instanceof SimpleLine) {
                LineDrawer ld = (LineDrawer) drawerFactory.getDrawer(ShapeType.LINE,(SimpleLine) aShape);
                ld.drawShape(g2d, currentBrightness);
            } else {
                if (aShape instanceof SimpleOval) {
                    OvalDrawer od = (OvalDrawer) drawerFactory.getDrawer(ShapeType.OVAL,(SimpleOval) aShape);
                    od.drawShape(g2d, currentBrightness);
                } else {
                    if (aShape instanceof SimpleTriangle) {
                        TriangleDrawer td = (TriangleDrawer) drawerFactory.getDrawer(ShapeType.TRIANGLE,(SimpleTriangle) aShape);
                        td.drawShape(g2d, currentBrightness);
                    } else {
                    if (aShape instanceof SimpleSquare) {
                        SquareDrawer sq = (SquareDrawer) drawerFactory.getDrawer(ShapeType.SQUARE,(SimpleSquare) aShape);
                        sq.drawShape(g2d, currentBrightness);
                    }
                }
            }
        }
        }
  g2d.setStroke(s);  // restore saved stroke
      if (currentPoints != null ) {
          // draw dot where line started
            g2d.setColor(currentColor);
            g2d.fillOval(currentPoints.get(0).x, currentPoints.get(0).y, 3, 3);
         
              if ( currentPoints.size() >= 2) { // draw dot where line started
               
                g2d.fillOval(currentPoints.get(1).x, currentPoints.get(1).y, 3, 3);
                 
                if ( currentPoints.size() >= 3) { // draw dot where line started
                g2d.fillOval(currentPoints.get(2).x, currentPoints.get(2).y, 3, 3);
                 }
              
              }
               
        } 
        
     
      

    }
 
    public float getCurrentBrightness() {
        return currentBrightness;
    }

    /*
     * currentBrightness is passed in as a number in the range
     * 0 to 1.  In this class it needs to be in the range 0.75 to
     * 1.25 which is what the division by 2 and addition of
     * 0.75 achieves.
     */
    public void setCurrentBrightness(float currentBrightness) {
        this.currentBrightness = (currentBrightness / 2) + 0.75F;
        repaint();
    }




    synchronized public void clearDisplay() {
        // Empty the ArrayList and clear the display.
        shapes.clear();
        repaint();
    }

    /* The whole drawing area can be rotated left or right.
     * The amount passed in is the amount in degrees to rotate.
     * A negative number roates to the left and a positive number to
     * the right
     */
    public void rotate(int amount) {
        currentRotation += amount;
        repaint();
    }

    public void setShapes(List shapes) {
        this.shapes = shapes;
    }
    
  public List getShapes() {
        return shapes;
    }
  
   public List getCurrentPoints() {
        return currentPoints;
    }

    public void setCurrentPoints(List currentPoints) {
        this.currentPoints = currentPoints;
    }
    
    
    
    public Color getCurrentColor() {
        return currentColor;
    }

    public void setCurrentColor(Color currentColor) {
        this.currentColor = currentColor;
    }
    
     public int getCurrentRotation() {
        return currentRotation;
    }

    public void setCurrentRotation(int currentRotation) {
        this.currentRotation = currentRotation;
    }
   

}    
    

   
    

    


    
    

   
    

    


