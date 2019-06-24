/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledrawer;

import java.awt.Color;
import java.awt.Point;
import java.util.List;

public class SimpleSquare extends Shape implements ShapeArea{

  

    public SimpleSquare(List<Point> v, Color c, int t, ShapeType st) {
        super(v,c,t,st,"shape");
    }
    
   

       public double getArea() {
        int term1 = vertices.get(0).x * (vertices.get(1).y - vertices.get(2).y);
        int term2 = vertices.get(1).x * (vertices.get(2).y - vertices.get(0).y);
        int term3 = vertices.get(2).x * (vertices.get(0).y - vertices.get(1).y);

        return Math.abs((term1 + term2 + term3) / 2.0);
    }

    /**
     *
     * @return the area in pixels of the triangle. Does this work okay?
     */
    
}