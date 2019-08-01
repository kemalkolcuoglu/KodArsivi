/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nyplab2016_2;

/**
 *
 * @author Win7-User
 */
public class MyClass {

    NYPLab2016_2 newNYP = new NYPLab2016_2();

    public void Test() {
        newNYP.method1(4);
        newNYP.method2(5);
        NYPLab2016_2.StaticMethod1(3);
        this.Test();
        MyClass newObject = new MyClass();

    }
}
