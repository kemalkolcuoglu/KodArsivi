/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nyplab2016_2;

/**
 *
 * @author HSYNPC
 */
public class NYPLab2016_2 {
    /**
     * @param args the command line arguments
     */
    
    static int x = 11;
    private int y = 33;
    public void method1(int x)
    {
        NYPLab2016_2 t = new NYPLab2016_2();
        this.x = 22;
        y = 44;
        System.out.println("x: " + x);
        System.out.println("NYPLab2016_2.x: " + NYPLab2016_2.x);
        System.out.println("t.x: " + t.x);
        System.out.println("t.y: " + t.y);
        System.out.println("y: " + y);
    }
    public static void main(String[] args) {
        // TODO code application logic here
           NYPLab2016_2 t = new NYPLab2016_2();
           t.method1(5);
       
    }
    
}
