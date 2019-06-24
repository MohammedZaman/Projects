/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledrawer;

import java.awt.Color;
import static java.awt.Color.*;
import java.awt.Point;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Afzal
 */
public class ModelTest {
    Model instance;
    
    int thickness1, thickness2;
    Color color1, color2, color3;
    float brightness1, brightness2, brightness3;
    int rotation1, rotation2, rotation3, rotation4;
    int x1, x2, x3;
    int y1, y2, y3;
    List shape1;
    Point nextPoint = new Point();
    Point newPoint = new Point();
    
    List<Point> currentPoints;
    
    public ModelTest() {
    }
    
    @Before
    public void setUp() {
        instance = new Model();
        
        thickness1 = 0;
        thickness2 = 50;
        
        color1 = new Color(0,0,0);
        color2 = new Color(255,255,255);
        color3 = new Color(255,255, 0);
        
        brightness1 = 0.0F;
        brightness2 = 100.0F;
        brightness3 = -10.0F;
        
        rotation1 = 360;
        rotation2 = -180;
        rotation3 = 0;
        rotation4 = 720;
        
        x1 = 100;
        x2 = -1000;
        x3 = 1000000000;
        
        y1 = -10;
        y2 = 1000000001;
        y3 = 0;
        
        currentPoints = new ArrayList<>();
        nextPoint.x = 10;
        nextPoint.y = 30;
        currentPoints.add(nextPoint);
        
        newPoint.x = -20;
        newPoint.y = -100;
        currentPoints.add(newPoint);
       
        shape1 = new ArrayList<Shape>();
        SimpleLine line = new SimpleLine(currentPoints, color2, 5, ShapeType.LINE);
        SimpleTriangle triangle = new SimpleTriangle(currentPoints, color3, 10, ShapeType.TRIANGLE);
        SimpleSquare square = new SimpleSquare(currentPoints, color1, 20, ShapeType.SQUARE);
        SimpleOval oval = new SimpleOval(currentPoints, color2, 10, ShapeType.OVAL);
       
        
        shape1.add(line);
        shape1.add(triangle);
        shape1.add(square);
        shape1.add(oval);
    }
    
    @Test
    public void testGetCurrentThickness1(){
        System.out.println("getCurrentThickness1");
        instance.setCurrentThickness(thickness1);
        int expResult = thickness1;
        int result = instance.getCurrentThickness();
        assertEquals(expResult, result);
 
    }

    /**
     * Test of getCurrentThickness method, of class Model.
     */
    @Test
    public void testGetCurrentThickness2() {
        System.out.println("getCurrentThickness2");
        int expResult = 5;
        int result = instance.getCurrentThickness();
        assertEquals(expResult, result);
    }

    /**
     * Test of getCurrentColor method, of class Model.
     */
    @Test
    public void testGetCurrentColor() {
        System.out.println("getCurrentColor");
        Color expResult = color1;
        Color result = instance.getCurrentColor();
        assertEquals(expResult, result);
    }

    @Test
    public void testGetCurrentColor1(){
        System.out.println("getCurrentColor1");
        instance.setCurrentColor(color2);
        Color expResult = color2;
        Color result = instance.getCurrentColor();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetCurrentColor2(){
        System.out.println("getCurrentColor2");
        instance.setCurrentColor(color3);
        Color expResult = color3;
        Color result = instance.getCurrentColor();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetCurrentColor3(){
        System.out.println("testGetCurrentColor3");
        instance.setCurrentColor(null);
        Color expResult = null;
        Color result = instance.getCurrentColor();
        assertEquals(expResult, result);
    }
    
   
    /**
     * Test of getCurrentShapeType method, of class Model.
     */
    /*@Test
    public void testGetCurrentShapeType() {
        System.out.println("getCurrentShapeType");
        Model instance = new Model();
        ShapeType expResult = null;
        ShapeType result = instance.getCurrentShapeType();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }*/

    /**
     * Test of getCurrentBrightness method, of class Model.
     */
    @Test
    public void testGetCurrentBrightness() {
        System.out.println("getCurrentBrightness");
        instance.setCurrentBrightness(brightness1);
        float expResult = 0.0F;
        float result = instance.getCurrentBrightness();
        assertEquals(expResult, result, 0.0);
    }
    
    @Test
    public void testGetCurrentBrightness1(){
        System.out.println("getCurrentBrightness1");
        instance.setCurrentBrightness(brightness2);
        float expResult = 100.0F;
        float result = instance.getCurrentBrightness();
        assertEquals(expResult, result, 0.0);
    }
    
    @Test
    public void testGetCurrentBrightness2(){
        System.out.println("getCurrentBrightness2");
        instance.setCurrentBrightness(brightness3);
        float expResult = -10.0F;
        float result = instance.getCurrentBrightness();
        assertEquals(expResult, result, 0.0);
    }
    

    /**
     * Test of getCurrentRotation method, of class Model.
     */
    @Test
    public void testGetCurrentRotation() {
        System.out.println("getCurrentRotation");
        instance.setCurrentRotation(rotation1);
        int expResult = rotation1;
        int result = instance.getCurrentRotation();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetCurrentRotation1(){
        System.out.println("getCurrentRotation1");
        instance.setCurrentRotation(rotation2);
        int expResult = rotation2;
        int result = instance.getCurrentRotation();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetCurrentRotation2(){
        System.out.println("getCurrentRotation2");
        instance.setCurrentRotation(rotation3);
        int expResult = rotation3;
        int result = instance.getCurrentRotation();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetCurrentRotation3(){
        System.out.println("getCurrentRotation3");
        instance.setCurrentRotation(rotation4);
        int expResult = rotation4;
        int result = instance.getCurrentRotation();
        assertEquals(expResult, result);
    }


    /**
     * Test of getCurrentPoints method, of class Model.
     */
    @Test
    public void testGetCurrentPoints() {
        System.out.println("getCurrentPoints");
        instance.setCurrentPoints(currentPoints);
        List<Point> expResult = currentPoints;
        List<Point> result = instance.getCurrentPoints();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetCurrentPoints1(){
        System.out.println("getCurrentPoints1");
        instance.setCurrentPoints(currentPoints);
        List<Point> expResult = currentPoints;
        List<Point> result = instance.getCurrentPoints();
        assertEquals(expResult, result);
    }

    /**
     * Test of getX method, of class Model.
     */
    @Test
    public void testGetX() {
        System.out.println("getX");
        instance.setX(x1);
        int expResult = x1;
        int result = instance.getX();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetX1(){
        System.out.println("getX1");
        instance.setX(x2);
        int expResult = x2;
        int result = instance.getX();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetX2(){
        System.out.println("getX2");
        instance.setX(x2);
        int expResult = x2;
        int result = instance.getX();
        assertEquals(expResult, result);
    }

    /**
     * Test of getY method, of class Model.
     */
    @Test
    public void testGetY() {
        System.out.println("getY");
        instance.setY(y1);
        int expResult = y1;
        int result = instance.getY();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetY1(){
        System.out.println("getY1");
        instance.setY(y2);
        int expResult = y2;
        int result = instance.getY();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetY2(){
        System.out.println("getY2");
        instance.setY(y3);
        int expResult = y3;
        int result = instance.getY();
        assertEquals(expResult, result);
    }

    /**
     * Test of getShapes method, of class Model.
     */
    @Test
    public void testGetShapesLine() {
        System.out.println("getShapesLine");
        instance.setShapes(shape1);
        List expResult = shape1;
        List result = instance.getShapes();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetShapesTriangle(){
        System.out.println("getShapeTriangle");
        instance.setShapes(shape1);
        List expResult = shape1;
        List result = instance.getShapes();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetShapesSquare(){
        System.out.println("getShapeSquare");
        instance.setShapes(shape1);
        List expResult = shape1;
        List result = instance.getShapes();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetShapesOval(){
        System.out.println("getShapeOval");
        instance.setShapes(shape1);
        List expResult = shape1;
        List result = instance.getShapes();
        assertEquals(expResult, result);
    }

    
}
