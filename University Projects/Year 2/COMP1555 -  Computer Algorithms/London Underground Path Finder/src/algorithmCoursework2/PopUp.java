/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithmCoursework2;

import java.awt.BorderLayout;
import java.awt.Dimension;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import static javax.swing.ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER;
import static javax.swing.ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS;
import static javax.swing.ScrollPaneConstants.VERTICAL_SCROLLBAR_AS_NEEDED;

/**
 *
 * @author johan
 */
public class PopUp extends JFrame{
    
    public static String[] columnNames = {"Station", "Line", "Time to next station", "Total Time"};
    public static Object[][] data;
    
    public JScrollPane table;
    public static JTable resultTable;

    public PopUp(){
        table = new JScrollPane(resultTable, VERTICAL_SCROLLBAR_AS_NEEDED, HORIZONTAL_SCROLLBAR_NEVER);
        setSize(520, 250);
        setTitle("View Details");
        setLayout(new BorderLayout());
        
        table.setPreferredSize(new Dimension(500, 200));
                
        JPanel middle = new JPanel();
        middle.add(table);
        add(BorderLayout.PAGE_START, middle);
        
        setVisible(true);
    } 
}
