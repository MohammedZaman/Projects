/*
 * TriangleDrawer.java
 *
 * @author Gill Windall
 *
 * This class can be given a SimpleTriangle object and draw it using a 
 * Graphics2D object.
 * 
 */
package simpledrawer;

import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics2D;

public class SquareDrawer implements Drawer {

    private SimpleSquare square; // the triangle to be drawn

    public SquareDrawer(SimpleSquare square) {
        this.square = square;
    }

    /**
     * Draw the shape using a Graphics2D object
     *
     * @param g2d Graphics2D object used for drawing
     * @param currentBrightness the current brightness being used to draw
     */
    @Override
    public void drawShape(Graphics2D g2d, float currentBrightness) {
        // scale the brightness of the colour
        Color c = scaleColour(square.getColour(), currentBrightness);
        g2d.setColor(c);
        // set the thickness of the line
        g2d.setStroke(new BasicStroke(square.getThickness()));

        // draw the Square
       g2d.drawLine(square.getVertices().get(0).x, square.getVertices().get(0).y, square.getVertices().get(1).x, square.getVertices().get(1).y);
       g2d.drawLine(square.getVertices().get(1).x, square.getVertices().get(1).y, square.getVertices().get(2).x, square.getVertices().get(2).y);
       g2d.drawLine(square.getVertices().get(2).x, square.getVertices().get(2).y, square.getVertices().get(3).x,square.getVertices().get(3).y);
       g2d.drawLine(square.getVertices().get(3).x, square.getVertices().get(3).y, square.getVertices().get(0).x,square.getVertices().get(0).y);
    }

    /* The colour can be made brighter or darker.
     * currentBrightness is a number between 0.75 and 1.25
     * which is used to scale the brightness.  Each of the colours
     * (red, green and blue) have their values mutiplied by
     * currentBrightness.  If currentBrightness is < 1 the colours
     * will get darker.  If it is > 1 they will get brighter.
     * We have to be careful the values don't go over 255 as
     * that's the maximum allowed.
     */
   
}
