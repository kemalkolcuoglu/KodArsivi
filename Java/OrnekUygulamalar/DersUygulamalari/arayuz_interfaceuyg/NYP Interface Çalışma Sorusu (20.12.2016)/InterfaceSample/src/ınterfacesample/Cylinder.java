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
public class Cylinder extends Object3D {

    private int r;
    private int h;

    public Cylinder(int r, int h) {
        this.r = r;
        this.h = h;
    }

    @Override
    public double GetArea() {
        return 2 * PI * r * (r + h);
    }

    @Override
    public double GetVolume() {
        return PI * r * r * h;
    }

}
