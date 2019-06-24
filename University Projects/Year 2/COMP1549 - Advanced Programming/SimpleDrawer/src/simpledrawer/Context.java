/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpledrawer;

/**
 *
 * @author mohammedzaman
 */
public class Context {
      private Strategy strategy;
      private ControlView view;
      private Model model;


    

   public Context(Strategy strategy,ControlView view,Model model){
      this.strategy = strategy;
      this.view = view;
      this.model = model;
   }

   public  void  executeStrategy(){
     strategy.startSearch();
   }
   
  
      
}
