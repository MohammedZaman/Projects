package com.example.mohammedzaman.FYP.DistanceEstimation;

public interface TrendLine {

    void setValues(double[] y, double[] x); // y ~ f(x)
    double predict(double x); // get a predicted y for a given x
}
