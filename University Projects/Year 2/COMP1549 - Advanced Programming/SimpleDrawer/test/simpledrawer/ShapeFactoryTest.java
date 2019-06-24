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
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Afzal
 */
public class ShapeFactoryTest {
    ShapeFactory instance;
    int thickness1, thickness2;
    Color color1, color2, color3;
    Point nextPoint = new Point();
    List<Point> currentPoints;
    
    public ShapeFactoryTest() {
    }
    
    @Before
    public void setUp() {
        instance = new ShapeFactory();
       
        thickness1 = 10;
        thickness2 = 30;
        
        color1 = new Color(0, 255, 0);
        color2 = new Color(0, 150, 200);
        color3 = new Color(100, 0, 210);
        
        currentPoints = new ArrayList<>();
        nextPoint.x = 20;
        nextPoint.y = 40;
        currentPoints.add(nextPoint);
             
        SimpleTriangle triangle = new SimpleTriangle(currentPoints, color3, 10, ShapeType.TRIANGLE);
        SimpleSquare square = new SimpleSquare(currentPoints, color1, 20, ShapeType.SQUARE);
        SimpleOval oval = new SimpleOval(currentPoints, color2, 10, ShapeType.OVAL);
       
        
        
    }

    /**
     * Test of getShape method, of class ShapeFactory.
     */
    @Test
    public void testGetShape() {
        System.out.println("getShape");
        List<Point> v = null;
        Color c = null;
        int t = 0;
        ShapeType st = null;
        ShapeFactory instance = new ShapeFactory();
        Shape expResult = null;
        Shape result = instance.getShape(v, c, t, st);
        assertEquals(expResult, result);
    }
    
    @Test
    public void testGetShape1(){
        System.out.println("getShape1");
       // Shape line = new SimpleLine(currentPoints, color1, thickness1, ShapeType.LINE);
        //Shape expResult = line;
        Shape result = instance.getShape(currentPoints, color1, thickness1, ShapeType.LINE);
        //assertEquals(expResult, result);
       assertTrue(result instanceof SimpleLine);

    }
    
    @Test
    public void testGetShape2(){
        System.out.println("getShape2");
       // Shape line = new SimpleLine(currentPoints, color1, thickness1, ShapeType.LINE);
       // Shape expResult = line;
        Shape result = instance.getShape(currentPoints, color1, thickness1, ShapeType.SQUARE);
        //assertEquals(expResult, result);
       assertTrue(result instanceof SimpleSquare);
    }
    
    @Test
    public void testGetShape3(){
        System.out.println("getShape3");
        Shape result = instance.getShape(currentPoints, color2, thickness1, ShapeType.TRIANGLE);
        assertTrue(result instanceof SimpleTriangle);
    } 
    
    @Test
    public void testGetShape4(){
        System.out.println("getShape4");
        Shape result = instance.getShape(currentPoints, color1, thickness1, ShapeType.OVAL);
        assertTrue(result instanceof SimpleOval);
    }
    
}
