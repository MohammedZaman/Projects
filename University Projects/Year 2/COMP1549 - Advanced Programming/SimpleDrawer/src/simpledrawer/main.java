/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledrawer;

/**
 *
 * @author mz7340g
 */
public class main {
     public static void main(String[] args) throws Exception {
           ControlView view = new ControlView();
    Model model = new Model();
    Controller controller = new Controller(model,view);
    view.activateView(controller);
    view.setVisible(true);
     }   
}
