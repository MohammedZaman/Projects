package coursework;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;




public class VideoPlayer extends JFrame {
JTabbedPane tabbed_CV = new JTabbedPane();// this is used to create the one gui


 
  public static void main(String[] args) {
        new VideoPlayer();
   
    }

    public VideoPlayer() {
 // setting for frame
      setLayout(new BorderLayout());
      setSize(800, 350);
      setTitle("Video Player");
      setVisible(true);
      setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
      setResizable(false);
      // this is the validation for the window closing
      this.addWindowListener(new WindowAdapter(){
              
                public void windowClosing(WindowEvent e){
                    if (JOptionPane.showConfirmDialog(null, "Are you sure you want to close the Application?", "Exit", 
                   JOptionPane.YES_NO_OPTION,
                 JOptionPane.QUESTION_MESSAGE) == JOptionPane.YES_OPTION){            
            System.exit(0);
        }
                        
                    
                }
            }
      );
      
// adding the contents of each tab by using classes 
      getContentPane().add(tabbed_CV); 
      tabbed_CV.addTab("Check Video",new CheckVideos());
    
      getContentPane().add(tabbed_CV); 
      tabbed_CV.addTab("Create Video List",new Createvidlist()); 
       
      getContentPane().add(tabbed_CV); 
        tabbed_CV.addTab("Update Video",new UpdateVideos()); 
 
    }
    

}

        

  


