/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ınterfacesample;

import static java.lang.Math.PI;

/**
 *
 * @author Tunalı
 */
public class Circle extends Object2D {

    private int r;

    public Circle(int r) {
        this.r = r;
    }

    @Override

    public double GetArea() {
        return r * r * PI;
    }

}
