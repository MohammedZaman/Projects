/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithmCoursework2;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Set;

/**
 *
 * @author marco
 */
public class Dijkstra {
    private final List<Vertex> nodes;
    private final List<Edge> edges;
    private Set<Vertex> settledNodes;
    private Set<Vertex> unSettledNodes;
    private Map<Vertex, Vertex> predecessors;
    private Map<Vertex, Integer> distance;
    
    public static int totalTime;
    public static List<Integer> time = new ArrayList<Integer>();
    public static List<Integer> totalTimeArray = new ArrayList<Integer>();
    public static List<String> pathLines = new ArrayList<String>();

    public Dijkstra(Graph graph) {
        // create a copy of the array so that we can operate on this array
        this.nodes = new ArrayList<Vertex>(graph.getVertexes());
        this.edges = new ArrayList<Edge>(graph.getEdges());
    }

    public void execute(Vertex source) {
        settledNodes = new HashSet<Vertex>();
        unSettledNodes = new HashSet<Vertex>();
        distance = new HashMap<Vertex, Integer>();
        predecessors = new HashMap<Vertex, Vertex>();
        distance.put(source, 0);
        unSettledNodes.add(source);
        while (unSettledNodes.size() > 0) {
            Vertex node = getMinimum(unSettledNodes);
            settledNodes.add(node);
            unSettledNodes.remove(node);
            findMinimalDistances(node);
        }
    }

    private void findMinimalDistances(Vertex node) {
        List<Vertex> adjacentNodes = getNeighbors(node);
        for (Vertex target : adjacentNodes) {
            if (getShortestDistance(target) > getShortestDistance(node) + getDistance(node, target)) {
                distance.put(target, getShortestDistance(node) + getDistance(node, target));
                predecessors.put(target, node);
                unSettledNodes.add(target);
            }
        }

    }

    private int getDistance(Vertex node, Vertex target) {
        for (Edge edge : edges) {
            if (edge.getSource().equals(node) && edge.getDestination().equals(target)) {
                return edge.getWeight();
            }
        }
        throw new RuntimeException("Should not happen");
    }

    private List<Vertex> getNeighbors(Vertex node) {
        List<Vertex> neighbors = new ArrayList<Vertex>();
         for (Edge edge : edges) {
            if (edge.getSource().equals(node) && !isSettled(edge.getDestination())) {
                neighbors.add(edge.getDestination());
            }
        }
        return neighbors;
    }

    // return the Vertex with the minumum distance from current vertex
    private Vertex getMinimum(Set<Vertex> vertexes) {
        Vertex minimum = null;
        for (Vertex vertex : vertexes) {
            if (minimum == null) {
                minimum = vertex;
            } else {
                if (getShortestDistance(vertex) < getShortestDistance(minimum)) {
                    minimum = vertex;
                }
            }
        }
        return minimum;
    }

    private boolean isSettled(Vertex vertex) {
        return settledNodes.contains(vertex);
    }

    private int getShortestDistance(Vertex destination) {
        Integer d = distance.get(destination);
        if (d == null) {
            return Integer.MAX_VALUE;
        } else {
            return d;
        }
    }

    /*
     * This method returns the path from the source to the selected target and
     * NULL if no path exists
     */
    public List<Vertex> getPath(Vertex target) {
        List<Vertex> path = new LinkedList<Vertex>();
        Vertex step = target;
        totalTime = 0;
        List<Edge> lanes = new LinkedList<Edge>();
        List<String> tmpLines = new ArrayList<String>();
        
        /*Clear all list if they contain something*/
        if(!path.isEmpty()){
            path.removeAll(path);
        }
        
        if(!lanes.isEmpty()){
            lanes.removeAll(lanes);
        }
        
        if(!tmpLines.isEmpty()){
            tmpLines.removeAll(tmpLines);
        }
        
        if(!pathLines.isEmpty()){
            pathLines.removeAll(pathLines);
        }
        
        if(!time.isEmpty()){
            time.removeAll(time);
        }
        
        if(!totalTimeArray.isEmpty()){
            totalTimeArray.removeAll(totalTimeArray);
        }
        
        // check if a path exists
        if (predecessors.get(step) == null) {
            return null;
        }
        path.add(step);
        while (predecessors.get(step) != null) {
            
            for (Edge edge : edges) { //get time taken for the path
                if (edge.getSource().equals(step) && edge.getDestination().equals(predecessors.get(step))) {
                    tmpLines.add(edge.getLine());
                }
            }
            
            //reduce amount of changes by comparing with the line of the previous edge
            if(pathLines.isEmpty()){
                pathLines.add(tmpLines.get(0));
                tmpLines.removeAll(tmpLines);
            } else if (!pathLines.isEmpty()){
                if(tmpLines.size() > 1){
                    int last = pathLines.size() - 1;
                    
                    for(String line : tmpLines){
                        if(line == pathLines.get(last)){
                            pathLines.add(line);
                            tmpLines.removeAll(tmpLines);
                            break;
                        }
                    }
                    
                    if(!tmpLines.isEmpty()){
                        pathLines.add(tmpLines.get(0));
                        tmpLines.removeAll(tmpLines);
                    }
                    
                } else{
                    pathLines.add(tmpLines.get(0));
                    tmpLines.removeAll(tmpLines);
                }
            }
            
            step = predecessors.get(step);
            path.add(step);
        }
        // Put it into the correct order
        Collections.reverse(path);
        Collections.reverse(pathLines);
        
        for (String line : pathLines){
            for (Edge edge : edges) { //get time taken for the path
                if (edge.getLine().equals(line)) {
                    time.add(edge.getWeight());
                    lanes.add(edge);
                    break;
                }
            }
        }
        
        for(Edge edge : lanes){
            totalTime += edge.getWeight() + 1;
            totalTimeArray.add(totalTime);
        }
        
        time.add(0);
        totalTimeArray.add(0, 0);
        
        int last = pathLines.size() - 1;
        String lastLine = pathLines.get(last);
        pathLines.add(last, lastLine);
        
        System.out.println("Time taken: " + totalTime + " minutes");
        System.out.println(time);        
        System.out.println(totalTimeArray);
        System.out.println(pathLines);
        return path;
    }
}
