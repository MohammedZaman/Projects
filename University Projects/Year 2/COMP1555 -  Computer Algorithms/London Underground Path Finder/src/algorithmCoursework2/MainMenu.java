/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithmCoursework2;

import static algorithmCoursework2.AlgorithmCoursework.frame;
import java.awt.BorderLayout;
import java.awt.CardLayout;
import java.awt.Choice;
import java.awt.Label;
import java.awt.Point;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;
import javax.swing.GroupLayout;
import static javax.swing.GroupLayout.Alignment.CENTER;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTable;
import javax.swing.LayoutStyle;

/**
 *
 * @author marco
 */
public class MainMenu extends JPanel implements ActionListener {
    
    Choice from = new Choice();
    Choice to = new Choice();
    Choice time = new Choice();
    JButton go = new JButton("Go");
    JButton quit = new JButton("Exit");
    Label title = new Label("Get Me Somewhere");  
    Label start = new Label("Start:");  
    Label end = new Label("End:");  
    Label timeLabel = new Label("Time of Departure:");
    
    public Dijkstra dijkstra;
    
    public static List<Vertex> path;
    public int[] timeMinutes = new int[76];
    public String[] timeHours = new String[76];
    
    private FileReaderEdges readEdges = new FileReaderEdges();
    private FileReaderStations readStations = new FileReaderStations();
    private AlgorithmCoursework ac = new AlgorithmCoursework();
    
    //private String[] stations;
    
    public MainMenu(){
        GroupLayout layout = new GroupLayout(frame.getContentPane());
        frame.getContentPane().setLayout(layout);
        layout.setAutoCreateGaps(true);
        layout.setAutoCreateContainerGaps(true);
        readStations.FileReaderStations();
        
        go.addActionListener(this);
        quit.addActionListener(this);
                
        for(String s : readStations.stations){
            from.addItem(s);
            to.addItem(s);
        }
        
        int fiveAM = 300;
        
        for(int i = 0; i < timeMinutes.length; i++){
            if(i == 0){
                timeMinutes[i] = fiveAM;
            } else{
                fiveAM += 15;
                timeMinutes[i] = fiveAM;
            }
        }
        
        for(int i = 0; i < timeHours.length; i++){
            if(timeMinutes[i] / 60 < 10){
                if(timeMinutes[i] % 60 == 0){
                    int hour = timeMinutes[i] / 60;
                    int minutes = timeMinutes[i] % 60;
                
                    String time = "0" + Integer.toString(hour) + ":" + Integer.toString(minutes) + "0";
                    timeHours[i] = time;
                } else {
                    int hour = timeMinutes[i] / 60;
                    int minutes = timeMinutes[i] % 60;
                
                    String time = "0" + Integer.toString(hour) + ":" + Integer.toString(minutes);
                    timeHours[i] = time;
                }
            } else{
                if(timeMinutes[i] % 60 == 0){
                    int hour = timeMinutes[i] / 60;
                    int minutes = timeMinutes[i] % 60;

                    String time = Integer.toString(hour) + ":" + Integer.toString(minutes) + "0";
                    timeHours[i] = time;
                } else{
                    int hour = timeMinutes[i] / 60;
                    int minutes = timeMinutes[i] % 60;

                    String time = Integer.toString(hour) + ":" + Integer.toString(minutes);
                    timeHours[i] = time;
                }
            }
        }
        
        for(String s : timeHours){
            time.addItem(s);
        }
        
        
        layout.setHorizontalGroup(layout.createSequentialGroup()
                                    .addComponent(start)
                                    .addComponent(from)
                                    .addGroup(layout.createParallelGroup(CENTER)
                                            .addGroup(layout.createSequentialGroup()
                                                    .addPreferredGap(LayoutStyle.ComponentPlacement.UNRELATED, 10, Short.MAX_VALUE)
                                                    .addComponent(title))
                                            .addGroup(layout.createSequentialGroup()
                                                    .addComponent(end)
                                                    .addComponent(to))
                                            .addGroup(layout.createSequentialGroup()
                                                    .addComponent(go)
                                                    .addComponent(quit)))
                                    .addComponent(timeLabel)
                                    .addComponent(time)
        );
        
        layout.setVerticalGroup(layout.createSequentialGroup()
                                            .addComponent(title)
                                    .addGroup(layout.createParallelGroup(CENTER)
                                            .addComponent(start)
                                            .addComponent(from)
                                            .addComponent(end)
                                            .addComponent(to)
                                            .addComponent(timeLabel)
                                            .addComponent(time))
                                    .addGroup(layout.createParallelGroup(CENTER)
                                            .addComponent(go)
                                            .addComponent(quit))
        );
        
        layout.linkSize(from, to, time);
        //layout.linkSize(timeLabel, start, end);
        
        setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == quit) {
            System.exit(0);
        } else if(e.getSource() == go){
            System.out.println(frame.getSize());
            
            /**********************************************************************
                    Create underground map graph and apply algorithm to it
            **********************************************************************/
            ac.CreateGraph();
            
            String timeChosen = time.getSelectedItem();
            int chosenTime = 0;
            for(int i = 0; i < timeHours.length; i++){
                if(timeChosen == timeHours[i]){
                    chosenTime = timeMinutes[i];
                    break;
                }
            }
            
            if(540 < chosenTime && chosenTime < 960){
                for(int i = 0; i < ac.edges.size(); i ++){
                    String line = ac.edges.get(i).getLine();
                    if("Bakerloo".equals(line)){
                        int weight = ac.edges.get(i).getWeight();
                        ac.edges.get(i).setWeight(weight / 2);
                    }
                }
            }
            
            if(1140 < chosenTime && chosenTime < 1440){
                for(int i = 0; i < ac.edges.size(); i ++){
                    String line = ac.edges.get(i).getLine();
                    if("Bakerloo".equals(line)){
                        int weight = ac.edges.get(i).getWeight();
                        ac.edges.get(i).setWeight(weight / 2);
                    }
                }
            }
            
            // Create graph (tube map)
            Graph graph = new Graph(ac.nodes, ac.edges);
            dijkstra = new Dijkstra(graph);
            
            AlgorithmCoursework.createAndShowGUI();
            
            int s = 0;
            int d = 0;
            
            for(int i = 0; i < readStations.stations.length; i++){
                if(from.getSelectedItem().equals(ac.nodes.get(i).getId())){
                    s = i;
                    break;
                }
            }
            
            for(int i = 0; i < readStations.stations.length; i++){
                if(to.getSelectedItem().equals(ac.nodes.get(i).getId())){
                    d = i;
                    break;
                }
            }
            
            dijkstra.execute(ac.nodes.get(s));
            path = dijkstra.getPath(ac.nodes.get(d));

            System.out.println("Path: " + path);

            for (Vertex vertex : path) {
                System.out.print(" [ " + vertex + " ] ");
            }

            chosenTime = 0;
            for(int i = 0; i < timeHours.length; i++){
                if(timeChosen == timeHours[i]){
                    chosenTime = timeMinutes[i];
                    break;
                }
            }
            
            if(chosenTime + Dijkstra.totalTime > 1440){
                JOptionPane.showMessageDialog(null, "Destination cannot be reached at this chosen time \n Choose a different time", "Error", JOptionPane.INFORMATION_MESSAGE);
            } else {
                /**********************************************************************
                            Setting up the table for the view details pop-up
                **********************************************************************/
                PopUp.data = new Object[path.size()][4];            

                for(int i = 0; i < ac.dijkstra.pathLines.size(); i++){
                    PopUp.data[i][0] = path.get(i);
                    PopUp.data[i][1] = Dijkstra.pathLines.get(i);
                    PopUp.data[i][2] = Dijkstra.time.get(i);
                    PopUp.data[i][3] = Dijkstra.totalTimeArray.get(i);
                }

                PopUp.resultTable = new JTable(PopUp.data, PopUp.columnNames);

                /**********************************************************************
                  Setting up the variables to be used in the SearchPerformedJava class
                **********************************************************************/
                int totalTimeToChange = 0;
                int wait = 0;
                List<Integer> waitTimes = new ArrayList<Integer>();
                waitTimes.add(0);
                
                for(int i = 0; i < PopUp.data.length; i++){
                    wait = 0;
                    if(i == 0){
                        System.out.println("");
                    } else if(i == PopUp.data.length - 1){
                        if(PopUp.data[i][1] != PopUp.data[i - 1][1]){
                            totalTimeToChange = chosenTime + (int) PopUp.data[i][3];
                            int remainder = totalTimeToChange % 5;
                            if(remainder != 0){
                                while(remainder != 0){
                                    totalTimeToChange++;
                                    wait++;
                                    remainder = totalTimeToChange % 5;
                                }
                                Dijkstra.totalTime += wait;
                                waitTimes.add(wait);

                            }
                        }
                    } else{
                        if(PopUp.data[i][1] != PopUp.data[i - 1][1]){
                            totalTimeToChange = chosenTime + (int) PopUp.data[i][3];
                            int remainder = totalTimeToChange % 5;
                            if(remainder != 0){
                                while(remainder != 0){
                                    totalTimeToChange++;
                                    wait++;
                                    remainder = totalTimeToChange % 5;
                                }
                                Dijkstra.totalTime += wait;
                                waitTimes.add(wait);

                            }
                        }
                    }
                }       



                int last = Dijkstra.totalTimeArray.size() - 1;

                SearchPerformedJava.travelTime = new JLabel("Total Travel Time: " + Integer.toString(Dijkstra.totalTime) + " minutes");

                //Setting up the data for the journey summary table
                List<Object> stations = new ArrayList<Object>();
                List<Object> lines = new ArrayList<Object>();

                for(int i = 0; i < PopUp.data.length; i++){
                    if(i == 0){
                        stations.add(PopUp.data[0][0]);
                        lines.add(PopUp.data[0][1]);
                    } else if(i == PopUp.data.length - 1){
                        if(PopUp.data[i][1] != PopUp.data[i - 1][1]){
                            lines.add(PopUp.data[i][1]);
                            stations.add(PopUp.data[i][0]);
                        } else{
                            stations.add(PopUp.data[i][0]);
                        }
                    } else{
                        if(PopUp.data[i][1] != PopUp.data[i - 1][1]){
                            stations.add(PopUp.data[i - 1][0]);
                            lines.add(PopUp.data[i][1]);
                        }
                    }
                }

                //Declare the array with the data for the journey summary table
                SearchPerformedJava.summarydata = new Object[path.size()][3];

                //Insert data into the array
                for(int i = 0; i < stations.size(); i++){
                    if(i != stations.size() - 1){
                        String fromTo = stations.get(i) + " - " + stations.get(i + 1);
                        SearchPerformedJava.summarydata[i][0] = fromTo;
                    }
                }

                for(int i = 0; i < lines.size(); i++){
                    SearchPerformedJava.summarydata[i][1] = lines.get(i);
                }
                
                for(int i = 0; i < waitTimes.size(); i++){
                    SearchPerformedJava.summarydata[i][2] = waitTimes.get(i);
                }


                /*start rescaling of the array*/
                int size = 0;

                for(int i = 0; i < SearchPerformedJava.summarydata.length; i++){
                    if(SearchPerformedJava.summarydata[i][0] != null){
                        size += 1;
                    } else if(SearchPerformedJava.summarydata[i][0] == null){
                        break;
                    }
                }

                Object[][] tmp = new Object[size][3];

                for(int i = 0; i < size; i++){
                    for(int j = 0; j < 3; j++){
                        tmp[i][j] = SearchPerformedJava.summarydata[i][j];
                    }
                }

                SearchPerformedJava.summarydata = new Object[size][3];

                for(int i = 0; i < size; i++){
                    for(int j = 0; j < 3; j++){
                        SearchPerformedJava.summarydata[i][j] = tmp[i][j];
                    }
                }
                /*finish rescaling the array*/

                //Create the summary table
                SearchPerformedJava.summaryTable = new JTable(SearchPerformedJava.summarydata, SearchPerformedJava.summaryColumn);

                /**********************************************************************
                            Add the SearchPerformedJava class to the frame
                **********************************************************************/
                SearchPerformedJava search = new SearchPerformedJava();

                int rowCount = 16 + search.summaryTable.getRowCount() * search.summaryTable.getRowHeight();
                frame.setSize(frame.getWidth(), 250 + rowCount);
                frame.getContentPane().add(search);
                frame.getContentPane().revalidate();
                frame.getContentPane().repaint();
            } 
        }    
    }
}
