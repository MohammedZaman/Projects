/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledrawer;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author mohammedzaman
 */
public class DrawerFactory {
   public Drawer getDrawer(ShapeType st, Shape shape){
             if(st == null){
         return null;
      }		
    switch (st) {
        case OVAL:
            return new OvalDrawer((SimpleOval) shape);
        case LINE:
            return new LineDrawer((SimpleLine) shape);
        case SQUARE:
            return new SquareDrawer((SimpleSquare) shape);
        case TRIANGLE:
            return new TriangleDrawer((SimpleTriangle) shape);
        default:
            break;
    }
      
      return null;
   }
       
   }
    

