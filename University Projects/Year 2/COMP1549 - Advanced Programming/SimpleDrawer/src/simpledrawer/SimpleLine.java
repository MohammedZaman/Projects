/*
 * SimpleLine.java
 *
 *
 * Represents a line that can be drawn on a drawing area
 *
 */
package simpledrawer;

import java.awt.Color;
import java.awt.Point;
import java.awt.Stroke;
import java.util.List;

public class SimpleLine extends Shape{

    

    public SimpleLine(List<Point> v, Color c, int t, ShapeType st) {
        super(v,c,t,st,"shape");
      
    }

    @Override
    public double getArea() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    

    
}
