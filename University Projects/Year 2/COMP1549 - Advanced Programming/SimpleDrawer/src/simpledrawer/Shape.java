/*
 * ShapeEvent.java
 *
 * @author Gill Windall
 *
 * Represents a shape event holding data for a shape read from file
 *
 */
package simpledrawer;

import java.awt.*;
import java.lang.reflect.Field;

public class Shape {

  protected java.util.List<Point> vertices; 
    protected  Color colour;
    protected int thickness;
    // Type of shape e.g. line or oval
     protected  ShapeType shapeType;

     protected  String eventType; // currently always SHAPE

    public Shape(java.util.List<Point> v,Color c, int t, ShapeType st, String eType) {
        vertices = v;
        colour = c;
        thickness = t;
        shapeType = st;
        eventType = eType;
    }

    /** 
     * Default constructor will create a default shape
     */
    public Shape() {
        this(null, Color.BLACK, 0, ShapeType.LINE, "SHAPE");
    }
  public java.util.List<Point> getVertices() {
        return vertices;
    }
  
    public void setVertices(java.util.List<Point> vertices) {
        this.vertices = vertices;
    }
    public Color getColour() {
        return colour;
    }

    public void setColour(Color colour) {
        this.colour = colour;
    }

    /**
     * The method converts the string representation of the colour passed to it
     * to the corresponding static constant of class Color e.g. "red" will be
     * converted to Color.RED. The strange code is an example of "reflection".
     * See
     * http://stackoverflow.com/questions/5822384/getting-a-color-from-a-string-input
     * for more explanation.
     *
     * @param colour string representation of the Color required
     */
    public void setColourByString(String colour) {
        try {
            Color c;
            Field f = Color.class.getField(colour.toUpperCase());
            this.colour = (Color) f.get(null);
        } catch (NoSuchFieldException | SecurityException | IllegalArgumentException | IllegalAccessException ex) {
            this.colour = Color.BLACK;
        }
    }

    public int getThickness() {
        return thickness;
    }

    public void setThickness(int thickness) {
        this.thickness = thickness;
    }

    public ShapeType getShapeType() {
        return shapeType;
    }

    public void setShapeType(ShapeType shapeType) {
        this.shapeType = shapeType;
    }

    public String getEventType() {
        return eventType;
    }

    public void setEventType(String eventType) {
        this.eventType = eventType;
    }
    
      public double getArea(){
       int line1 = vertices.get(1).x - vertices.get(0).x;
        int line2 = vertices.get(1).y- vertices.get(0).y;
        System.out.println(line1 + ", " + line2 + " " + Math.PI * line1/2 * line2/2);
        return Math.PI * line1/2 * line2/2;
      };
   
    @Override
    public String toString() {
        return "ShapeEvent{" + "vertices="+vertices+", colour=" + colour + ", thickness=" + thickness + ", shapeType=" + shapeType + ", eventType=" + eventType + '}';
    }
    
}
