/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package simpledrawer;

import java.awt.Color;
import java.awt.Point;
import java.util.ArrayList;
import java.util.List;
import javax.swing.BorderFactory;

/**
 *
 * @author mohammedzaman
 */
public class Model {



  private int level = 0;

 
    // current settings used when drawing
     private  int currentThickness;
    private  Color currentColor;
    private  ShapeType currentShapeType;
    private float currentBrightness;
    private int currentRotation;

    public  List<Point> currentPoints; // x and y points for shape being drawn

    // position of the latest click
    private int x, y;

    // A List that stores the shapes that appear on the JPanel
    public List shapes;  // using
    
   

    /* Constructor used to create a DrawingPanel with a
     * specified line colour, thickness and shape type
     */
      public Model() {
        this(Color.BLACK, 5, ShapeType.LINE);
    }
      public Model(Color c, int t, ShapeType st) {
       
        x = -1;
        y = -1;
        currentColor = c;
        currentThickness = t;
        currentShapeType = st;
        currentRotation = 0;
        currentBrightness = 1;

        // instantiate the ArrayList to store shapes
        shapes = new ArrayList<>();
    }

    public int getCurrentThickness() {
        return currentThickness;
    }

    public void setCurrentThickness(int currentThickness) {
        this.currentThickness = currentThickness;
    }

    public Color getCurrentColor() {
        return currentColor;
    }

    public void setCurrentColor(Color currentColor) {
        this.currentColor = currentColor;
    }

    public ShapeType getCurrentShapeType() {
        return currentShapeType;
    }

    public void setCurrentShapeType(ShapeType currentShapeType) {
        this.currentShapeType = currentShapeType;
    }

    public float getCurrentBrightness() {
        return currentBrightness;
    }

    public void setCurrentBrightness(float currentBrightness) {
        this.currentBrightness = currentBrightness;
    }

    public int getCurrentRotation() {
        return currentRotation;
    }

    public void setCurrentRotation(int currentRotation) {
        this.currentRotation = currentRotation;
    }

    public List<Point> getCurrentPoints() {
        return currentPoints;
    }

    public void setCurrentPoints(List<Point> currentPoints) {
        this.currentPoints = currentPoints;
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }

 public synchronized List getShapes() {
        return shapes;
    }

    public void setShapes(List shapes) {
        this.shapes = shapes;
    }

       public  synchronized int getLevel() {
        return level;
    }

    public synchronized void setLevel(int level) {
        this.level = level;
    }
}