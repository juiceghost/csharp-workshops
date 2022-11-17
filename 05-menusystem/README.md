Nu är det dags att bygga ditt första menysystem i konsollen. 

Börja med att fundera vilka menyalternativ du vill ha. Hitta på några stycken bara, och bestäm vad varje menyalternativ ska göra. Ska det skriva ut nånting och sen skriva ut menyn igen? Eller du kanske vill gå in i en undermeny med andra val. Ett smart knep är att redan tidigt i projektet skapa en funktion inuti Main som skriver ut menyn. Då kan du kalla på denna funktion när du behöver i din kod sen.

# Vad du ska göra

- [ ]  Skapa ett nytt projekt i Visual Studio (Console Application → C# → .Net Core)
- [ ]  Döp projektet till "MenuSystem"
- [ ]  När programmet startar ska en meny skrivas ut i consolen
- [ ]  Man väljer ett menyalternativ och något skrivs ut eller en ny meny kommer upp
- [ ]  Glöm inte att det ska gå att gå tillbaka till huvudmenyn från undermenyer
- [ ]  Det ska gå att avsluta programmet med ett menyval

### Tips

Lyckades du få till ovanstående och förhoppningsvis blev lite klokare hur ett menysystem är uppbyggt? Hade du svårt att komma på vad som skulle finnas bakom de olika menyalternativen?

Se om du kan kopiera in tidigare workshops (guess-number osv) in i ditt menysystem. Tänk på att du bara kan ha en Main så du behöver göra om (omfaktorisera) så att hela guess a number t.ex körs från en funktion.  

### Exempel

Nedan hittar du några exempel på hur en meny kan se ut i consolen. Du får gärna skriva på engelska om du föredrar det.

- Exempel 1
    
    ```
    Välkommen till min projektsamling! Vänligen välj ett av nedanstående alternativ:
    1. Hello World
    2. Guess a Number
    3. Chess board
    S. Slumpmässigt projekt
    G. Link to my Github
    A. Avsluta
    
    ----> A

    Tack för att du tittade och välkommen åter.
    ```
    
Man får välja själv om man behöver välja ett alternativ och trycka enter, eller om det räcker med att bara trycka på knappen. Tips där är att googla på ReadLine vs ReadKey.

En annan variant är att man använder piltangenterna för att välja menyalternativ, så skulle det kunna se ut såhär:

- Exempel 2
    
    ```
    Välkommen till min projektsamling! Vänligen välj med piltangenterna och tryck Enter för att bekräfta:
       Hello World
       Guess a Number
       Chess board
       Slumpmässigt projekt
     [ Link to my Github ]
       Avsluta

    https://github.com/juiceghost

    ```