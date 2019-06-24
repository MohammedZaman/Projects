package coursework;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.JTextArea;

/**
 *
 * @author mohammedzaman
 */
public class UpdateVideos extends JPanel implements ActionListener {

//all the components for update video 
 JButton Update = new JButton("Update");
 JTextField trackNo_UV = new JTextField(2);
 JTextField Rating = new JTextField(3);
 JTextArea information_UV = new JTextArea(10, 50);
 JTabbedPane tabbed_UV = new JTabbedPane();
 String[] Ratingnum = {"0","1","2","3","4","5"};//values for the combo boc 
 JComboBox ratingbox= new JComboBox(Ratingnum);// loading the values into the combo box
 

    public UpdateVideos(){
 
//layout for Update video  
        setLayout(new BorderLayout());
        JPanel top_UV = new JPanel();
        add("North", top_UV);
        top_UV.add(new JLabel("Enter Video Number:"));
        top_UV.add(trackNo_UV);
        top_UV.add(new JLabel("Enter new rating:"));
        top_UV.add(ratingbox);
        top_UV.add(Update);
        
        JPanel middle_UV = new JPanel();  
        add("Center", middle_UV);
        middle_UV.add(information_UV);
        middle_UV.add(new JScrollPane(information_UV));
      
        information_UV.setEditable(false);
        information_UV.setColumns (40);
        information_UV.setLineWrap (true);
        information_UV.setWrapStyleWord (false);  
        
        // action listener
        Update.addActionListener(this);


    }
    

    public void actionPerformed(ActionEvent e){
  
        if(e.getSource() == Update){
            if(trackNo_UV.getText().equals("")){
             information_UV.setText("");
             JOptionPane.showMessageDialog(new JFrame(), "no video number has been entered"+"\ne.g. 01");  
            }else{
                Update_video();
                Display_update_text();
            }
        }
    }
    
    
    
    
    // methods for update video 
    public void Update_video(){
        String key = trackNo_UV.getText();
        int rating = ratingbox.getSelectedIndex();// finds the input of the combo box
        VideoData.setRating(key, rating);// sets rating based on the video number 
    }
    public void Display_update_text(){
        String key = trackNo_UV.getText();
        String name = VideoData.getName(key);
        if (name == null) {
                information_UV.setText("Enter valid video numbers" + "\ne.g.01");
        }else {
            // displays the text 
           information_UV.setText(name + " - " + VideoData.getDirector(key));
                information_UV.append("\nRating: "
                        + stars(VideoData.getRating(key)));
                information_UV.append("\nPlay count: " + VideoData.getPlayCount(key));
                
        }
        
    }
        private String stars(int rating) {
        String stars = "";
        for (int i = 0; i < rating; ++i) {
            stars += "*";
        }
        return stars;
    }

}