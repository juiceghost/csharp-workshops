# Om uppgiften

I denna uppgift kommer du öva på att använda Polymorphism inom objektorientering. Uppgiften handlar till stor del om att tänka ut en struktur för Polymorphism .

# Vad du ska göra

- [ ]  Du ska skapa en klass som ska vara ParentClass till de andra klasserna som ska ärva från den. Klassen ska heta Geometri`{ }` och den ska en metod som heter `Area()` och `return` typ är en double.
- [ ]  Du ska skapa tre klasser till som ska ärva från Geometriklassen och klasserna ska heta `Rektangel`, `Fyrkant` och `Cirkel.` **Namn ska vara på Engleska** Alla klasser ska ha en metod som heter `Area().`
- [ ]  Varje klass ska ha minst en egenskap, till exempel:
    
    ```csharp
    public class Cirkel{
         public double Radius {get; set;}
    }
    ```
    
- [ ]  I alla ChildClasses ska vi overrida metoden `Area()` med olika implementeringar. Eftersom arean för en cirkel inte räknas ut på samma sätt som arean för en fyrkant.
- [ ]  Alla ChildClasses måste ha en Constructor för att ge värde till egenskaper och vi ska ge den ett fast värde i konstruktorn. Till Exempel:
    
    ```csharp
    public Cirkel{
          Radius = 4;
    }
    ```
    
- [ ]  I Main-metoden ska du skapa object reference från Geometriklassen och den ska peka till ett objekt av varje klass.

## Output :
```
Area Cirkel: 78,5
Area Fyrkant: 36
Area Rektangel: 18,02
```