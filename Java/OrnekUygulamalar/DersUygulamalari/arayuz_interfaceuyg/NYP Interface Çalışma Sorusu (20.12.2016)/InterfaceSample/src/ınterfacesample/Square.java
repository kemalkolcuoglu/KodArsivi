/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ınterfacesample;

/**
 *
 * @author Tunalı
 */
public class Square extends Object2D{

    private int a;

    public Square(int a) {
        this.a = a;
    }
    
    @Override
    public double GetArea() {
        return a * a;
    }
    
    
}
