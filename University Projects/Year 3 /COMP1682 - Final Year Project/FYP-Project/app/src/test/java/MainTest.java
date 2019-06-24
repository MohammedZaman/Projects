

import com.example.mohammedzaman.FYP.GeneralClasses.Point;

import org.junit.Test;


import java.util.Hashtable;

import static org.junit.Assert.assertTrue;

public class MainTest {


    private static Hashtable<Integer, String> indexTable; // find node name with index
    private static String findNode(int index){
        return indexTable.get(index);
    }

    private static void DynamicLoadTable(){
        indexTable = new Hashtable<>();
        int x = 0;
        char[] Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".toCharArray();
        String Letter = "A";
        int D = 1;



        for (int i = 0; i < 260; i++) {

            indexTable.put(i, String.valueOf(Letters[x]) + D);
            D++;

            int g = i + 1;
            if (g % 10 == 0) {
                x = x + 1;
                D = 1;

            }
        }
    }
    @Test
    public void TestObstacle1() {
        DynamicLoadTable();
        boolean x = false;
        ObstacleLocation obstacleLocation = new ObstacleLocation();
        Point currentLoc = new Point();
        currentLoc.setX(1);
        currentLoc.setY(5);

        Point obs  = obstacleLocation.getObstacleCoordinateTest(200,1,currentLoc,0.44);


        if(obs.getIndex() == 15){
            x = true;

        }
        System.out.println();
        System.out.print("current Node " + findNode(currentLoc.getIndex()));
        System.out.print(" ---- Obstacle Node " + findNode(obs.getIndex()));
        assertTrue(x);
    }

    @Test
    public void TestObstacle2() {
        DynamicLoadTable();
        boolean x = false;
        ObstacleLocation obstacleLocation = new ObstacleLocation();
        Point currentLoc = new Point();
        currentLoc.setX(1);
        currentLoc.setY(5);

        Point obs  = obstacleLocation.getObstacleCoordinateTest(200,1,currentLoc,0.7);


        if(obs.getIndex() == 4){
            x = true;

        }
        System.out.println();
        System.out.print("current Node " + findNode(currentLoc.getIndex()));
        System.out.print(" ---- Obstacle Node " + findNode(obs.getIndex()));
        assertTrue(x);
    }

    @Test
    public void TestObstacle3() {
        DynamicLoadTable();
        boolean x = false;
        ObstacleLocation obstacleLocation = new ObstacleLocation();
        Point currentLoc = new Point();
        currentLoc.setX(1);
        currentLoc.setY(5);

        Point obs  = obstacleLocation.getObstacleCoordinateTest(200,1,currentLoc,2.27);


        if(obs.getIndex() == 24){
            x = true;

        }
        System.out.println();
        System.out.print("current Node " + findNode(currentLoc.getIndex()));
        System.out.print(" ---- Obstacle Node " + findNode(obs.getIndex()));
        assertTrue(x);
    }

    @Test
    public void TestObstacle4() {
        DynamicLoadTable();
        boolean x = false;
        ObstacleLocation obstacleLocation = new ObstacleLocation();
        Point currentLoc = new Point();
        currentLoc.setX(1);
        currentLoc.setY(5);

        Point obs  = obstacleLocation.getObstacleCoordinateTest(200,1,currentLoc,1.8);


        if(obs.getIndex() == 13){
            x = true;

        }
        System.out.println();
        System.out.print("current Node " + findNode(currentLoc.getIndex()));
        System.out.print(" ---- Obstacle Node " + findNode(obs.getIndex()));
        assertTrue(x);
    }

    @Test
    public void TestObstacle5() {
        DynamicLoadTable();
        boolean x = false;
        ObstacleLocation obstacleLocation = new ObstacleLocation();
        Point currentLoc = new Point();
        currentLoc.setX(1);
        currentLoc.setY(5);

        Point obs  = obstacleLocation.getObstacleCoordinateTest(200,1,null,1.8);


        if(obs == null){
            x = true;

        }
        System.out.println();

        assertTrue(x);
    }





}