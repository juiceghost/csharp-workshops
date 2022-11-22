# Om uppgiften

Den här uppgiften går ut på att återskapa Sten-Sax-Påse från föregående block fast i Console med C#

# Vad du ska göra

- [ ]  Skapa ett nytt projekt i Visual Studio (Console Application → C# → .Net Core)
- [ ]  Döp projektet till "RockPaperScissors"
- [ ]  När programmet startar ska användaren få instruktion om spelet
- [ ]  Spelaren får ange rock paper eller scissor, med siffror, bokstäver eller på annat sätt
- [ ]  Datorn slumpar fram sitt drag
- [ ]  Du visar vad datorn fick och vem som fick poäng
- [ ]  Först till N poäng vinner

### Tips

Börja med att duplicera spelet precis som det fungerade i din tidigare workshop-uppgift när du skapade spelet med Javascript. Fanns det nån funktion du önskat att du hade gjort då? Se om du kan implementera den i din Console-version.

### Exempel

    ```
    Välkommen till Sten Sax Påse!
    1. Ny omgång
    2. Avsluta

    ----> 1

    Först till 5 gäller!
    Spelarens poäng: 0
    Datorns poäng: 0

    1. Sten
    2. Sax
    3. Påse

    ----> 2

    Du valde Sax. Datorn valde Påse.
    Du vann!

    Spelarens poäng: 1
    Datorns poäng: 0

    1. Sten
    2. Sax
    3. Påse
    A. Avsluta spelet

    ---->
    ```

### Extra utmaningar

Gick ovanstående lätt att få till? Håll ordning på statistiken för både den mänskliga spelaren och datorspelaren. Hur ofta väljer spelaren sten, sax eller påse? Datorn borde över tid välja sten, sax eller påse med 1/3 sannolikhet på varje. Ett bra sätt att undersöka hur bra slumptalsgeneratorn fungerar.