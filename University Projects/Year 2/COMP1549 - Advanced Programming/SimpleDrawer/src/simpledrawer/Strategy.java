/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledrawer;

import java.io.File;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;

/**
 *
 * @author mohammedzaman
 */
public interface Strategy extends Runnable{
    public void CheckShapes(ControlView ControlView,Model myModel);
    @Override
    public void run();
    public void startSearch();
    
    default void playSound(int state){
      try
    {
         File f;
       
        if (state == 0) {
            f = new File("./src/simpledrawer/fail.wav");
            Clip clip = AudioSystem.getClip();
            clip.open(AudioSystem.getAudioInputStream(f));
            clip.start();
        } else if (state == 1) {
            f = new File("./src/simpledrawer/gameOver.wav");
            Clip clip = AudioSystem.getClip();
            clip.open(AudioSystem.getAudioInputStream(f));
            clip.start();
        }
        
        
    }
    catch (Exception exc)
    {
        exc.printStackTrace(System.out);
    }
      
}
}
