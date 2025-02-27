namespace Animals
{
  using System;


     //Declaring a public class 
  public class Animal
  {
    //declaring a public property of name type string
    // The `{ get; set; }` syntax creates an auto-implemented property with a getter and setter.
    // This allows getting and setting the value of 'name' outside the class. 
        public string name { get; set; }

        //the constructor for the animal class 
        public Animal(string name)
        {
          this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
          
          // this is a method 
        public string TalkToOwner()
        {
          return "what?!";
        }


    }
}