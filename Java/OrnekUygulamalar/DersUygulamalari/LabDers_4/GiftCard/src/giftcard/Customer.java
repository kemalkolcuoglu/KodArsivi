/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package giftcard;

/**
 *
 * @author Tunalı
 */
public class Customer {
            
    private  String name;
    private  String surname;
    private  int age;
    private  String gender;
    private  String city;
    private  int credit;

    public String getName() {
        return name;
    }

    public String getSurname() {
        return surname;
    }

    public String getCity() {
        return city;
    }

    public int getCredit() {
        return credit;
    }  
    
    public Customer()
    {
        this.city="Konya";
        this.credit=100;
    }
    public Customer(String name,String surname,String gender,int age,String city,int credit)
    {
         this.name=name;
         this.surname=surname;
         this.gender=gender;
         this.age=age;
         this.city=city;
         this.credit=credit;
    }    
    
    public Customer(String name,String surname,String gender,int age)
    {
         this();
         this.name=name;
         this.surname=surname;
         this.gender=gender;
         this.age=age;
    }
    
    public void SetParameters()
    {
        SetCreditbyGender();
        SetCreditbyAge();
        SetCreditbyCity();
    }
    
    private void SetCreditbyGender()
    {
        if(this.gender.toLowerCase().equals("kadın"))
            this.credit=this.credit*2;       
    }
    
    private void SetCreditbyAge() 
    {
        if(this.age<=18)
            this.credit+=50;
        else if(this.age<40)
            this.credit+=100;
        else 
            this.credit+=120;
    }    

    private void SetCreditbyCity() 
    {
        if(this.city.toLowerCase().equals("konya"))
            this.credit+=50;
        else
            this.credit+=100;
    }
}
