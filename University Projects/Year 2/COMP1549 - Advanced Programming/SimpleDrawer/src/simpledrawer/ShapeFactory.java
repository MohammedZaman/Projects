/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledrawer;


import java.awt.Color;
import java.awt.Point;
import java.awt.event.MouseEvent;
import java.util.HashMap;
import java.util.List;

/**
 *
 * @author mohammedzaman
 */
public class ShapeFactory {
   
    
    

public Shape getShape(List<Point> v,Color c, int t, ShapeType st){

      if(st == null){
         return null;
      }		
    switch (st) {
        case OVAL:
            return new SimpleOval(v,c,t,st);
        case LINE:
            return new SimpleLine(v,c,t,st);
        case SQUARE:
            return new SimpleSquare(v,c,t,st);
        case TRIANGLE:
            return new SimpleTriangle(v,c,t,st);
        default:
            break;
    }
      
      return null;
   }
    
}

