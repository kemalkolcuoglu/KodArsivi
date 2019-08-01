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

    public void method2(int x) {
        method1(x);
    }

    public static void StaticMethod1(int x) {

    }

    public void method1(int x1) {

        NYPLab2016_2 t = new NYPLab2016_2();
        NYPLab2016_2.x = 22;
        y = 44;
        System.out.println("x: " + x);
        System.out.println("NYPLab2016_2.x: " + NYPLab2016_2.x);
        System.out.println("t.x: " + NYPLab2016_2.x);
        System.out.println("t.y: " + t.y);
        System.out.println("y: " + y);
        double a = 4.2;
        double b = a;
        NYPLab2016_2.x = 4;

        this.y = 4;
        y = 5;
    }

  
    public static void main(String[] args) {
        // TODO code application logic here

    

        NYPLab2016_2 t = new NYPLab2016_2();
        t.method1(5);
        StaticMethod1(x);
        Integer t1 = new Integer("5");
        
        
    }

}
