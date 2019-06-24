/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package coursework;
import java.awt.*;
import java.awt.event.*;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import javax.swing.*;
import javax.swing.JTextArea;

/**
 *
 * @author mohammedzaman
 */
public class Createvidlist extends JPanel implements ActionListener {

JTextField trackNo_cvl = new JTextField(2);
JTextArea information_cvl = new JTextArea(10, 50);
JButton Add = new JButton("Add");
JButton delete = new JButton("Delete");
JButton Play = new JButton("Play");
JButton Reset = new JButton("Reset");
JButton Save = new JButton("Save");
JButton Load = new JButton("Load");
ArrayList<String> tracks = new ArrayList<>();// this is the old code 
String s[] = information_cvl.getText().split("\\r?\\n");
ArrayList<String>arrList = new ArrayList<>(Arrays.asList(s)); //  array list of lines 
 

    public Createvidlist(){ 
        // borderlayout
       setLayout(new BorderLayout());
        // all the components that are added to the middle j frame
        JPanel middle_cvl = new JPanel();
        add("Center", middle_cvl);
        middle_cvl.add(information_cvl);
        middle_cvl.add(new JScrollPane(information_cvl));
        information_cvl.setColumns (40);
        information_cvl.setLineWrap (true);
        information_cvl.setWrapStyleWord (false);
        information_cvl.setEditable(false);
        
        //all the components that are added to the middle j frame
        JPanel bottom_cvl = new JPanel();
        add("South", bottom_cvl);
        bottom_cvl.add(Save);
        bottom_cvl.add(Load);
        
        //all the components that are added to the top j frame
        JPanel top_cvl = new JPanel();
        add("North", top_cvl);
        top_cvl.add(new JLabel("Enter Video Number:"));
        top_cvl.add(trackNo_cvl);
        top_cvl.add(Add);
        top_cvl.add(delete);
        top_cvl.add(Play);
        top_cvl.add(Reset);
        
        
        // action listeners 
        Add.addActionListener(this);
        Play.addActionListener(this);
        Reset.addActionListener(this);
        delete.addActionListener(this);
        Save.addActionListener(this);
        Load.addActionListener(this); 
        
     

    }

    @Override
    public void actionPerformed(ActionEvent e) {
   String key = trackNo_cvl.getText();
        String name = VideoData.getName(key);
        
        if (e.getSource() == Add){
        if (name == null) {
        JOptionPane.showMessageDialog(new JFrame(), "Enter valid video numbers" + "\ne.g.01");
        }else{
        add_track();
           }
        } else if (e.getSource() == Reset){
            reset_playlist();
         }else if(e.getSource() == Play){
          if(information_cvl.getText().equals("")){
        JOptionPane.showMessageDialog(new JFrame(), "Add videos to the playlist"+"\nby entering a video number in the enter video number "); 
           
        }else{
        JOptionPane.showMessageDialog(new JFrame(), "your video have been played"+ "\ngo to the check video tab to see the playcount"); 
        play_TrackNEW();   
        }
        
         
        
        }else if (e.getSource() == delete){
        Delete();
              
        
               
        }else if (e.getSource() == Save){  
       Save_track();
       
        
          
        }else if(e.getSource() == Load){
          Load_track();
             
             
      } 
           
    }
      public void add_track(){
    // add tracks to the videodata and to the Jtextbox 
    String key = trackNo_cvl.getText();
    String name = VideoData.getName(key);    
    String director = VideoData.getDirector(key);
    information_cvl.append(key + " " +name + "-" + director + "\n");
    //tracks.add(key);
    
    }
      
   public void Play_all_tracks(){// old function not needed 
       // this is not used in the program 
        tracks.forEach((track) -> {
            VideoData.incrementPlayCount(track);
    });
   }
    public void Save_track(){
         if (information_cvl.getText().equals("") ){
            JOptionPane.showMessageDialog(new JFrame(), "no text found in the textbox");
        } else{ 
        
        try {
                String save = information_cvl.getText();
                String filename = VideoData.SetFileName();
                BufferedWriter writer = new BufferedWriter(new FileWriter(filename + ".txt"));
                writer.write(save);
                writer.close();
                JOptionPane.showMessageDialog(new JFrame(), "succesful save");
            } catch (Exception ex) {
                JOptionPane.showMessageDialog(new JFrame(), "file could not be saved");
            }
          }
    }
    public void Load_track(){
        int dialogButton = JOptionPane.YES_NO_OPTION;
             int dialog = JOptionPane.showConfirmDialog (null, "By loading a playlist the current playlist will be deleted" + "\n" + "would you like to continue","",dialogButton);
             if(dialog == JOptionPane.YES_OPTION){
             
                JFileChooser FC = new JFileChooser();
                FC.setCurrentDirectory(new File(System.getProperty("user.home")));// gets file paths 
                int Result = FC.showOpenDialog(this);
                if(Result == JFileChooser.APPROVE_OPTION){
                try {
                String selectedfile = FC.getSelectedFile().getName();// the selected file loaction
                java.io.File file= new java.io.File(selectedfile);
                Scanner input = new Scanner(file);// here the text file is getting scneed and then being placed in a variable 
                information_cvl.setText("");
                while(input.hasNext()){
                String num = input.nextLine();// the file is being read all the way to the end so all inputs come up
                information_cvl.append(num + "\n");// the data is being placd on the textarea 
                }
                } catch (Exception ex) {
                JOptionPane.showMessageDialog(new JFrame(), "file could not be loaded");//  if the file fails to load error message appears
                }
            }
    }
        
     
 }
    public void Delete() {
     if (information_cvl.getText().equals("")){
     JOptionPane.showMessageDialog(new JFrame(), "No videos to delete"+"\nadd videos by entering a video number e.g. 01");
     }else{
    String s[] = information_cvl.getText().split("\\r?\\n");
    ArrayList<String>arrListL = new ArrayList<>(Arrays.asList(s)) ;//array list of lines 
    int array_size = arrListL.size();//size of array list
    int Key = array_size - 1;  
    String str = arrListL.get(Key);
    int LL_length = str.length();// length of last line 
    String info_length = information_cvl.getText();
    int info = info_length.length();// length of charaters of the whole J text area 
    int start_of_ll =  info - LL_length - 1 ;// start of the last line 
    information_cvl.replaceRange("", start_of_ll, info);//replaces the the characters from selected points 
    //tracks.remove(tracks.size() - 1);
     
     }
     
    }
    public void play_TrackNEW(){
    String s[] = information_cvl.getText().split("\\r?\\n");
    ArrayList<String>arrList = new ArrayList<>(Arrays.asList(s));//  array list of lines
    for (int x=0; x<arrList.size(); x++){
    String nl = arrList.get(x);// going through the array
    String b [] = nl.split("(?!^)");// spliting each element of the array characters 
    ArrayList<String>arrList2 = new ArrayList<>(Arrays.asList(b));//loading the characters of each element of the array list into an another array
    String trckno = arrList2.get(0) + arrList2.get(01);// selecting the first two characters of each line then declairing it as a string 
    VideoData.incrementPlayCount(trckno);// playing the track
       }
  }  
  public void reset_playlist(){
      // validation on the exit 
        int dialogButton = JOptionPane.YES_NO_OPTION;
             int dialog = JOptionPane.showConfirmDialog (null, "Are you sure you want to reset" + "\n" + "All the data in the text box will be deleted","",dialogButton);
             if(dialog == JOptionPane.YES_OPTION){
             information_cvl.setText("");
    }

  }
   
}

