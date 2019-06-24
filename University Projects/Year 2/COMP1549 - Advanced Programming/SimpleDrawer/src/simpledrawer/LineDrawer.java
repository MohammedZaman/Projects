/*
 * LineDrawer.java
 *
 *
 * This class can be given a SimpleLine object and draw it using a 
 * Graphics2D object.
 * 
 */
package simpledrawer;


import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.GradientPaint;
import java.awt.Graphics2D;

public class LineDrawer implements Drawer {

    private SimpleLine line; // the line to be drawn

    public LineDrawer(SimpleLine line) {
        this.line = line;
    }


    @Override
    public void drawShape(Graphics2D g2d, float currentBrightness) {
        // scale the brightness of the colour
        Color c = scaleColour(line.getColour(), currentBrightness);
        g2d.setColor(c);
        
        // set the thickness of the line
        g2d.setStroke(new BasicStroke(line.getThickness()));

        // draw the triangle
        g2d.drawLine(line.getVertices().get(0).x, line.getVertices().get(0).y, line.getVertices().get(1).x,line.getVertices().get(1).y);
  
    }
}
