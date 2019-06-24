/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithmCoursework2;

import static algorithmCoursework2.AlgorithmCoursework.frame;
import static algorithmCoursework2.MainMenu.path;
import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.GroupLayout;
import static javax.swing.GroupLayout.Alignment.CENTER;
import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.LayoutStyle;

/**
 *
 * @author marco
 */
public class SearchPerformedJava extends JPanel implements ActionListener{
    
    public static String[] summaryColumn = {"Station", "Line", "Wait for train"};
    public static Object[][] summarydata;
    
    
    
    public static JTable summaryTable;
    
    public static JLabel travelTime;
    JLabel journeySummary = new JLabel("Journey Summary: ");
    JButton viewDetails = new JButton("View Details");
            
    public SearchPerformedJava(){
        GroupLayout layout = new GroupLayout(frame.getContentPane());
        frame.getContentPane().setLayout(layout);
        layout.setAutoCreateGaps(true);
        layout.setAutoCreateContainerGaps(true);
        
        viewDetails.addActionListener(this);
        
        layout.setHorizontalGroup(layout.createParallelGroup(CENTER)
                                    .addComponent(travelTime)
                                    .addComponent(journeySummary)
                                    .addComponent(summaryTable.getTableHeader())
                                    .addComponent(summaryTable)
                                    .addComponent(viewDetails)
        );
        
        layout.setVerticalGroup(layout.createParallelGroup(CENTER)
                                    .addGroup(layout.createSequentialGroup()
                                    .addPreferredGap(LayoutStyle.ComponentPlacement.RELATED, 100, Short.MAX_VALUE)
                                    .addComponent(travelTime)
                                    .addComponent(journeySummary)
                                    .addComponent(summaryTable.getTableHeader())
                                    .addComponent(summaryTable)
                                    .addComponent(viewDetails)
                                    )
        );
        
        setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource() == viewDetails){
            new PopUp();
        }
    }

}
