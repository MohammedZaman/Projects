/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithmCoursework2;

/**
 *
 * @author marco
 */
public class Edge {
    
    private String id;
    private String line;
    private Vertex source;
    private Vertex destination;
    private int weight;

    public Edge(String id, String line, Vertex source, Vertex destination, int weight) {
        this.id = id;
        this.line = line;
        this.source = source;
        this.destination = destination;
        this.weight = weight;
    }

    public String getId() {
        return id;
    }
    
    public String getLine(){
        return line;
    }
    
    public Vertex getDestination() {
        return destination;
    }

    public Vertex getSource() {
        return source;
    }
    public int getWeight() {
        return weight;
    }
    
    public void setWeight(int weight){
        this.weight = weight;
    }

    @Override
    public String toString() {
        return source + " " + destination;
    }
}
