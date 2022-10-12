namespace Bakery;

public abstract class Person {


/*
 // Builder Design Pattern
 - pas 1
 - pas 2
 - pas 3
 => build();
*/
 
 public PersonName PersonName {get; init;}
 
 public ChangePersonName(string firstName, string lastName) {
   PersonName.ChangeFirstName(firstName);
   PersonName.ChangeLastName(lastName);  
 }
  
// Lista de telefoane
//        , Phone number, Email

}
