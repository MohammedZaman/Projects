/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithmCoursework2;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;
import org.apache.poi.hssf.usermodel.HSSFWorkbook;
 
import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.CellType;
import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.ss.usermodel.Sheet;
import org.apache.poi.ss.usermodel.Workbook;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

/**
 *
 * @author marco
 */
public class FileReaderEdges {
    
    static String FILE_NAME = "LUD.xlsx";
    public final String appDir = System.getProperty("user.dir"); //Get directory of the project
    public String[][] edges;
    
    
    public void FileReaderEdges() {

        try {

            FileInputStream excelFile = new FileInputStream(new File(appDir + "//" + FILE_NAME)); //Get excel file from within the Projects directory
            XSSFWorkbook workbook = new XSSFWorkbook(excelFile); //Create workbook with the excel file
            Sheet datatypeSheet = workbook.getSheetAt(0); //Get the first sheet in the workbook
            Iterator<Row> iterator = datatypeSheet.iterator();
            
            int rows = datatypeSheet.getLastRowNum();
            String[] edge = new String[4];
            edges = new String[rows + 1][4];

            //Check if current row is the last one with something inside
            while (iterator.hasNext()) {

                Row currentRow = iterator.next();
                Iterator<Cell> cellIterator = currentRow.iterator();
                int rowNum = currentRow.getRowNum();

                //Check if current cell is the last cell with someting inside
                while (cellIterator.hasNext()) {

                    Cell currentCell = cellIterator.next();
                    //Check the type of variable inside the cell
                    //Either String
                    if (currentCell.getCellTypeEnum() == CellType.STRING) {
                        //Add what's inside the cell to the Array edge
                        for(int i = 0; i < edge.length; i++){
                            if(edge[i] == null){
                                edge[i] = currentCell.getStringCellValue();
                                break;
                            }
                        }
                    } 
                    //Or number (double)
                    else if (currentCell.getCellTypeEnum() == CellType.NUMERIC) {
                        //Add what's inside the cell to the Array edge
                        for(int i = 0; i < edge.length; i++){
                            if(edge[i] == null){
                                edge[i] = Double.toString(currentCell.getNumericCellValue()) ;
                                break;
                            }
                        }                    
                    }
                }
                //Add the element of the Array edge to the 2d Array edges
                //The 2d Array edges will be used to create the edges/lanes of the graph
                for(int i = rowNum; i <= rows;){
                    for(int j = 0; j < edge.length; j++){
                        if (edges[i][j] == null){
                            edges[i][j] = edge[j];
                            edge[j] = null;
                        }
                    }
                    break;
                }
            }            
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
