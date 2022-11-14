# Om uppgiften

Det här är den andra uppgiften i kursen och nu kommer du själv få tänka ut en struktur och ett programflöde som löser problemet. Du kommer inte behöva använda speciellt avancerade flöden eller datatyper för att lösa uppgiften och det handlar snarare om att hitta en logisk lösning.

# Vad du ska göra

- [ ]  Skapa ett nytt projekt i Visual Studio (Console Application → C# → .Net Core)
- [ ]  Döp projektet till "ChessBoard"
- [ ]  När programmet startar ska användaren få mata in en siffra
- [ ]  Du ska sedan skriva ut ett "schackbräde" med så många rader och kolumner som användaren angav
- [ ]  Brädet skriver du ut genom att låta varje svart ruta representeras av detta tecken `◼︎` och varje vit ruta av detta tecken `◻︎`. Du bör kunna kopiera dessa tecken från denna uppgiftsbeskrivning.

### Tips

När du tar en input från användaren kommer den in som en String. I denna uppgift behöver du ha den som en Integer. För att konvertera det du får in från användaren kan du använda följande kod:

```csharp
int number = Int32.parse(text); //gör om variabeln text till en integer
```

### Exempel

- Exempel med 3 rader och kolumner
    
    Om användaren skriver in 3 som siffra...
    
    ```
    3
    ◻︎◼︎◻︎
    ◼︎◻︎◼︎
    ◻︎◼︎◻︎
    ```
    
- Exempel med 10 rader och kolumner
    
    Om användaren skriver in 10 som siffra...
    
    ```
    10
    ◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎
    ◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎
    ◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎
    ◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎
    ◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎
    ◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎
    ◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎
    ◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎
    ◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎
    ◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎◼︎◻︎
    ```
    

### Extra utmaning

Känns uppgiften för enkel? Blev du klar snabbt?

Här får du lite idéer på hur du kan göra uppgiften lite mer avancerad. Testa så mycket du vill med dessa! Klicka på pilarna för att läsa mer.

- Välja tecken för rutorna
    ♟️ Låt användaren få välja vilket tecken som ska genereras för varje svar och varje vit ruta. Kanske vill användaren att det står "S" för svart ruta och "V" för vit ruta istället. Troligen fungerar det med emojies också 🙂

- Placera ut en pjäs
    ♟️ Låt användaren få bestämma en ruta som det ska stå en pjäs på i brädet och skriv på just den platsen ut exempelvis ett "X" eller varför inte använda ett UTF-8 tecken för en schackpjäs som någon av dessa `♛ ♜ ♞`
    
    I schack har alla rutor ett namn. Den första raden heter `1` och den andra raden `2` osv. Den första kolumnen heter `A` och den andra `B` osv. Dessa kan vi sedan kombinera så om jag säger `E7` menar jag alltså 5:e kolumnen och 7:e raden och vill ha min pjäs där.
    

Om du gjort dessa utmaningar kan du visa upp denna labb med dessa funktioner inkluderade såklart!