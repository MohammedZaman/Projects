/*
 * OvalDrawer.java
 *
 *
 * This class can be given a SimpleOval object and draw it using a 
 * Graphics2D object.
 * 
 */
package simpledrawer;


import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.GradientPaint;
import java.awt.Graphics2D;

public class OvalDrawer implements Drawer {

    private SimpleOval oval; // the oval to be drawn

    public OvalDrawer(SimpleOval oval) {
        this.oval = oval;
    }

   
    public void drawShape(Graphics2D g2d, float currentBrightness) {
        // scale the brightness of the colour
        Color c = scaleColour(oval.getColour(), currentBrightness);
      //     GradientPaint redtowhite = new GradientPaint(10,10, Color.cyan, 200, 200,Color.RED);
   // g2d.setPaint(redtowhite);// draw dot where line started
       g2d.setColor(c);
  
        g2d.setStroke(new BasicStroke(oval.getThickness()));

        int xs = oval.getVertices().get(0).x;
        int ys = oval.getVertices().get(0).y;
        
        // draw the oval        
    g2d.drawOval(xs, ys, oval.getVertices().get(1).x - xs,oval.getVertices().get(1).y - ys);
    
    }

    
}

