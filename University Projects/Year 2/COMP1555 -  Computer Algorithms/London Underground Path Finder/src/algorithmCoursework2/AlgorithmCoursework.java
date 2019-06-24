 /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithmCoursework2;

import java.awt.BorderLayout;
import java.awt.CardLayout;
import java.awt.Choice;
import java.awt.Container;
import java.awt.Label;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;

/**
 *
 * @author marco
 */
public class AlgorithmCoursework extends JFrame{
    
    public ArrayList<Vertex> nodes = new ArrayList<Vertex>();
    public ArrayList<Edge> edges = new ArrayList<Edge>();
    public Dijkstra dijkstra;
    
    private static FileReaderEdges readEdges = new FileReaderEdges();
    private static FileReaderStations readStations = new FileReaderStations();
   
    public static JFrame frame = new JFrame("Fastest Path Finder");
        
    public void AlgorithmCoursework(Container pane) {
        MainMenu mainFrame = new MainMenu();
        
        frame.getContentPane().removeAll();
        frame.getContentPane().add(mainFrame);
        frame.getContentPane().revalidate();
        frame.pack();
    }
        
    public static void createAndShowGUI() {
        //Create and set up the window.
        
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        //Create and set up the content pane.
        AlgorithmCoursework demo = new AlgorithmCoursework();
        demo.AlgorithmCoursework(frame.getContentPane());
        
        //Display the window.
        frame.pack();
        frame.setResizable(false);
        frame.setVisible(true);
    }
        
    public static void main(String[] args) {
        // TODO code application logic here
        
        /* Use an appropriate Look and Feel */
        try {
            //UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");
            UIManager.setLookAndFeel("javax.swing.plaf.metal.MetalLookAndFeel");
        } catch (UnsupportedLookAndFeelException ex) {
            ex.printStackTrace();
        } catch (IllegalAccessException ex) {
            ex.printStackTrace();
        } catch (InstantiationException ex) {
            ex.printStackTrace();
        } catch (ClassNotFoundException ex) {
            ex.printStackTrace();
        }
        /* Turn off metal's use of bold fonts */
        UIManager.put("swing.boldMetal", Boolean.FALSE);
        
        //Schedule a job for the event dispatch thread:
        //creating and showing this application's GUI.
        javax.swing.SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                createAndShowGUI();
            }
        });
    }
    
    public void addLane(String laneId, String line, Vertex source, Vertex destination, int duration) {        
        Edge lane = new Edge(laneId, line, source, destination, duration );
        Edge backLane = new Edge(laneId, line, destination, source, duration);
        edges.add(lane);
        edges.add(backLane);
    }
    
    public void CreateGraph(){
        readStations.FileReaderStations();
        readEdges.FileReaderEdges();
        
        //Create node for the graph
        for (int i = 0; i < readStations.stations.length; i++) {
            Vertex location = new Vertex(readStations.stations[i], readStations.stations[i]);
            nodes.add(location);
        }
        
        //Create edges for the graph
        for (int i = 0; i < readEdges.edges.length; i++) {
            Vertex source = null;
            Vertex destination = null;
            Vertex[] node = new Vertex[nodes.size()];
            node = nodes.toArray(node);
            
            for(int j = 0; j < nodes.size(); j++){
                if(readEdges.edges[i][1].equals(nodes.get(j).getId())){
                    source = nodes.get(j);
                }
            }
            for(int j = 0; j < nodes.size(); j++){
                if(readEdges.edges[i][2].equals(nodes.get(j).getId())){
                    destination = nodes.get(j);
                }
            }
                
            addLane("00" + i, readEdges.edges[i][0], source, destination, (int) Double.parseDouble(readEdges.edges[i][3]));
        }
        
        
    }
}
