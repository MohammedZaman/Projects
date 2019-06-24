/*
 * JSONShapeREader.java
 *
 *
 * Used to read shapes from a file stored in JSON format.  Uses the Gson
 * library to convert the JSON from the file into Java objects in memory.
 * You can read more about Gson at https://code.google.com/p/google-gson/
 *
 */
package simpledrawer;

import com.google.gson.*;
import java.awt.Color;
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.Reader;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

public class JSONShapeReader {

    // ListOfShapeEvents is an inner class used to wrap a list of 
    // ShapeEvent objects which hold shape details
    static class ListOfShapeEvents {

        List<Shape> listOfShapeEvents;
    }

    
    private List<Shape> shapes; // list of lines
  

    private Gson gson; // gson object used to "parse" the JSON

    public JSONShapeReader() {
        gson = new Gson();
       shapes= new ArrayList<>();
       
    }


    public void storeShapes(String fileSource) {

      

        try (Reader reader = new FileReader(fileSource)) {

			// Convert JSON to Java Object
                   Shape[] listOfShapes = gson.fromJson(reader, Shape[].class);
                   
           for (int i = 0; i < listOfShapes.length ; i++) {
            
            switch (listOfShapes[i].shapeType) {
                case LINE:
           //         SimpleLine l = new SimpleLine(listOfShapes[i].vertices, listOfShapes[i].colour, listOfShapes[i].thickness,listOfShapes[i].shapeType);
         //           shapes.add(l);
                    break;
                case OVAL:
                    SimpleOval o = new SimpleOval(listOfShapes[i].vertices, listOfShapes[i].colour, listOfShapes[i].thickness,listOfShapes[i].shapeType);
                    shapes.add(o);
                      break;
                case TRIANGLE:
                    SimpleTriangle st = new SimpleTriangle(listOfShapes[i].vertices, listOfShapes[i].colour, listOfShapes[i].thickness,ShapeType.OVAL);
                    shapes.add(st);
                      break;
                case SQUARE:
                    SimpleSquare sq = new SimpleSquare(listOfShapes[i].vertices, listOfShapes[i].colour, listOfShapes[i].thickness,listOfShapes[i].shapeType);
                    shapes.add(sq);
             
                   
            }
        }
           
         }
        catch (FileNotFoundException ex) {
            Logger.getLogger(Controller.class.getName()).log(Level.SEVERE, null, ex);
        } catch (IOException ex) {
            Logger.getLogger(Controller.class.getName()).log(Level.SEVERE, null, ex);
        }
    }


       public void JsonSave(String writetToFile, List<Shape> allShapes ) {
       // convert the shape list into a json string
        String json = gson.toJson(allShapes);
        //System.out.println(json);
           try(FileWriter fw = new FileWriter(writetToFile)) {
    fw.write(json);
    }catch (IOException ex) {
        Logger.getLogger(Controller.class.getName()).log(Level.SEVERE, null, ex);
    }
           
           
    }
    public List<Shape> getSlList() {
        return shapes;
    }

   
}
