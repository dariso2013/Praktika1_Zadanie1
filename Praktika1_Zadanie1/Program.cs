using System;

namespace Praktika1_Zadanie1
{
  class Program
  {
    
    struct Person
    {
      public string firstName;
      public string lastName;
      public int age;
      public enum Genders : int { Male, Female };
      public Genders gender;
      public Person(string _firstName, string _lastName, int _age, Genders _gender)
      {
        firstName = _firstName;
        lastName = _lastName; 
        age = _age;
        gender = _gender;
      }
      public override string ToString()
      {
        return firstName + " " + lastName + " (" + gender + "), age " + age;
      }
    }
    static void Main(string[] args)
    {
      string sk = "Microsoft .NET Framework 2 Application Development Foundation";
      string[] sa = sk.Split(' ');
      foreach (string poch in sa)
      {
        Console.WriteLine(poch);
      }
      Array.Sort(sa);
      Console.WriteLine();
      foreach (string poch in sa)
      {
        Console.WriteLine(poch);
      }
      sk = string.Join(' ', sa);
      Console.WriteLine(sk);
      SByte a = 0;
      Byte b = 0;
      Int16 c = 0;
      Int32 d = 0;
      Int64 e = 0;
      string s = "";
      Exception ex = new Exception();
      object[] types = { a, b, c, d, e, s, ex };
      Person p = new Person("Tony", "Allen", 32, Person.Genders.Male);
      Console.WriteLine(p);
      foreach (object o in types)
      {
        string type;
        if (o.GetType().IsValueType) type = "Value type";
        else
          type = "Reference Type";
        Console.WriteLine("{0}: {1}", o.GetType(), type);
      }
      //Console.WriteLine("Hello World!");
    }
  }
}
