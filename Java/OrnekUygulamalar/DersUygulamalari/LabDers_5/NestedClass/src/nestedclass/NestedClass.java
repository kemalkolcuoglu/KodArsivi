/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nestedclass;

/**
 *
 * @author HSYNPC
 */
public class NestedClass {

    int var1=0;
    class Test1 
    {
        int var1=5;
        int Method1(int a)
        {
            return var1+a;
           // return NestedClass.this.var1+a ;
        }
        
    }
    static class Test2
    {
        int var1=10;
        int Method1(int a)
        {       
           return var1+a;
         //  return NestedClass.this.var1;
        }
        
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Test2 dene=new Test2();
        NestedClass.Test1 dene1 = new NestedClass().new Test1();
        System.out.println("NestedClass Method = "+ dene1.Method1(1));
        System.out.println("Static NestedClass Method = "+ dene.Method1(1));
        
    }
    
}
