using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
namespace hw
{
    public class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }
        public double Sum { get; set; }

public Money(){
WriteLine("enter count of dollars: ");
string d = ReadLine();
int dollars = int.Parse(d);
Dollars = dollars;


WriteLine("enter count of cents: ");
string c = ReadLine();
int cents = int.Parse(c);
Cents = cents;
Normalize();
Sum = dollars + cents;

}

public Money(int dollars, int cents){
    Dollars = dollars;
    Cents = cents;
    Normalize();
    Sum = dollars + cents;
}

public Money(double sum){
    Sum = sum;
    Dollars = (int)sum;
    Cents = (int)(sum - Dollars * 100);
    Normalize();
    }
      

         public static Money operator +(Money a, Money b){
            double result = a.Sum + b.Sum;

       if (a.Sum < 0)
    {
 throw new InvalidOperationException("Bankrupt");
    }

    return new Money(result);
}


public static Money operator -(Money a, Money b)
{
    double result = a.Sum - b.Sum;

        if (a.Sum < 0)
    {
 throw new InvalidOperationException("Bankrupt");
    }

    return new Money(result);
}

public static Money operator ++(Money a){
        if (a.Sum < 0)
    {
        throw new InvalidOperationException("Cannot apply the - operator to a negative value.");
    }
    
    a.Cents++;
    a.Normalize();
    return new Money(a.Dollars, a.Cents); 
}    

public static Money operator --(Money a){
        if (a.Sum < 0)
    {
        throw new InvalidOperationException("Cannot apply the - operator to a negative value.");
    }
    
    a.Cents--;
    a.Normalize();
    return new Money(a.Dollars, a.Cents); 
}        

public static Money operator *(Money a, int num){

     double newSum = a.Sum * num;
    if (newSum < 0)
    {
        throw new InvalidOperationException("Bankrupt");
    }
    return new Money(newSum);
    
}

public static Money operator /(Money a, int num){

    a.Sum /= num;

            if (a.Sum < 0)
    {
        throw new InvalidOperationException("Bankrupt");
    }

    return a;
    
    
}


public static bool operator >(Money a, Money b){
    return a.Sum > b.Sum;
}

public static bool operator <(Money a, Money b){
    return a.Sum < b.Sum;
}

public static bool operator ==(Money a, Money b){
    return a.Equals(b);
}
public static bool operator !=(Money a, Money b){
      return !(a == b);
}
        public override string ToString() => $"{Dollars} dollars and {Cents} cents";


           private void Normalize()
        {
            if (Cents >= 100)
            {
                Dollars += Cents / 100;
                Cents %= 100;
            }
            else if (Cents < 0)
            {
                Dollars -= 1 + (-Cents) / 100;
                Cents = 100 - (-Cents) % 100;
            }
        }

        
    }

}