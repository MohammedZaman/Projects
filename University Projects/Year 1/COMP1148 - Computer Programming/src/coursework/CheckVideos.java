package coursework;// this is the package where the class is saved 

import java.awt.*;// this gives you the classes to create Grapfical interfaces 
import java.awt.event.*;//the classes which allow you to create event with the components 
import javax.swing.*;
import javax.swing.JTextArea;// classes for the JTextarea 



// public classes can be accessed anywhere from the program 
public class CheckVideos extends JPanel implements ActionListener {

// all the components for create video
JTextField trackNo = new JTextField(2);// a new button is being created called trackNo
JTextArea information = new JTextArea(10, 50);// a new text area is created which has its size set to 10 rows and 50 coloums
JButton list = new JButton("List All Videos");// new button being created called list all videos
JButton check = new JButton("Check Video");// new button being created called list all videos
JLabel image = new JLabel();//new label being created called image because thats where the image is being displayed 
ImageIcon music1 = new ImageIcon(getClass().getResource("music1.png"));// location of the images beiing declared, i imported it all into the sourcefile so it gets found 
ImageIcon music2 = new ImageIcon(getClass().getResource("music2.png"));// location of the images beiing declared
ImageIcon music3 = new ImageIcon(getClass().getResource("music3.png"));// location of the images beiing declared
ImageIcon music4 = new ImageIcon(getClass().getResource("music4.png"));// location of the images beiing declared
ImageIcon music5 = new ImageIcon(getClass().getResource("music5.png"));// location of the images beiing declared
ImageIcon error = new ImageIcon(getClass().getResource("error.png"));// location of the images beiing declared



    public CheckVideos() {
 
      
 
      
//actionlistener and layout for check video
      setLayout(new BorderLayout());// this is the layout of the j panel this used for the placement of the components
      JPanel top = new JPanel();// createing a new Jpanel
      add("North", top);// setting the Jpanel to the north of the layout
      top.add(new JLabel("Enter Video Number:"));// adding a new label to the JPanel called top 
      top.add(trackNo);// adding the trackNo button to the JPanel called top
      top.add(check);// adding the check button to the JPanel called top 
      top.add(list);// adding the list button to the Jpanel called top 
      list.addActionListener(this);// adding the action listener to the list buttton
      check.addActionListener(this);// adding action listener to the check button
      JPanel middle = new JPanel();// creating a new Jpanel called middle 
      add("Center", middle);// settign the JPanel called midddle on the center of the border layout 
      middle.add(information);// adding JTextarea called information to the JPanel middle 
      information.setText(VideoData.listAll());// list all the videos on the JTextarea 
      information.setEditable(false);// setting the JTextArea as not editable 
      information.setColumns (40);// setting the columns of the JTextarea 
      information.setLineWrap (true);// 
      information.setWrapStyleWord (false);    
      middle.add(new JScrollPane(information));// adding a scrol bar on the Jtextarea 
      JPanel left = new JPanel();// creating a Jpanel called left 
      add("West", left);// adding the Jpanel to the West of the border layout 
      left.add(image);// adding the label image to the Jpanel called left 
     
       setVisible(true);// setting frame to visible so it can be seen 
    }
    

    public void actionPerformed(ActionEvent e) {// this is a action performed event 
        String key_CV = trackNo.getText();// varibale that contains trackNo text
        String name_CV = VideoData.getName(key_CV);// function that gets name of the video 
        if (e.getSource() == list) {// testing to see if list has been clicked 
        List_videos();// function that lists all videos 
        
       
    }else if (name_CV == null) {
                information.setText("No such video number"+"\ne.g 01 ");
                image.setIcon(error);// validation 
       
       }else{
        
    display_videos();// functions that displays the data of the selected video 
     Get_image();  // function that displays images    
    }
       
    }
    
    
    
   
    // Check video methods
    private String stars(int rating) {
        String stars = "";
        for (int i = 0; i < rating; ++i) {// this outputs stars based on the rating number 
            stars += "*";
        }
        return stars;
    }
    public void Get_image(){
        //here the image is being set based on the imput of the TrackNo
                String S = trackNo.getText();// declareing the input for the case statement 
                int N1 = Integer.parseInt(S);
                switch (N1) {
                    case 01:
                        image.setIcon(music1);// setting the icon of the label 
                        break;
                    case 02:
                        image.setIcon(music2);
                        break;
                    case 03:
                        image.setIcon(music3);
                        break;
                    case 04: 
                        image.setIcon(music4);
                        break;
                    case 05:
                        image.setIcon(music5);
                        break;
                    default:
                        break;
                }
    }
    public void display_videos(){
        String key = trackNo.getText();// geting the data within trackNo
        String name = VideoData.getName(key);// getting the Video name 
        information.setText(name + " - " + VideoData.getDirector(key));// displaying the text on the JTextarea 
        information.append("\nRating: "// append means adding it on to the current text
        // \n this means new line         
        + stars(VideoData.getRating(key)));// displaying the rating 
        information.append("\nPlay count: " + VideoData.getPlayCount(key));// adding the playcount on a new line 
        
    }
    public void List_videos(){
        information.setText(VideoData.listAll());// list all video
        image.setIcon(null);// setting label as empty 
    }
    
    
  

}
