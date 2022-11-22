Nu är det dags att bygga ditt första riktiga program som faktiskt kan vara kul att använda; ett enklare spel!

Det du ska skapa är ett rätt enkelt spel där användaren får gissa ett nummer. Användaren kommer få lite ledtrådar och har ett begränsat antal försök på sig att gissa.

# Vad du ska göra

- [ ]  Skapa ett nytt projekt i Visual Studio (Console Application → C# → .Net Core)
- [ ]  Döp projektet till "NumbersGame"
- [ ]  När programmet startar ska följande skrivas ut i consolen: "Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök."
- [ ]  Programmet ska slumpa fram ett tal som användaren ska gissa på men såklart inte skriva ut vilket tal det är. Förslagsvis genererar programmet ett tal mellan 1 och 20 men du får välja.
- [ ]  Användaren ska sedan mata in ett tal som den vill gissa på
- [ ]  Om talet är fel ska programmet svara med antingen "Tyvärr du gissade för lågt!" eller "Tyvärr du gissade för högt!" beroende på om talet som användaren gissade på var just högre eller lägre än det som skulle gissas.
- [ ]  Om användaren gissar rätt ska programmet skriva ut "Woho! Du gjorde det!"
- [ ]  Om användaren har gissat fem (5) gånger och inte fått till rätt tal ska programmet skriva ut Tyvärr du lyckades inte gissa talet på fem försök!" och användaren får inte gissa mer
- [ ]  Någon del av din kod ska vara i en egen funktion/metod. Exempelvis kan du ha en funktion för att kolla om gissningen är rätt eller fel som heter `CheckGuess()`.

### Tips

För att låta programmet slumpa fram ett tal kan du använda koden nedan. Den kommer slumpa ett tal mellan 1 och 20 som läggs in i variabeln `number`.

```csharp
Random random = new Random();
int number = random.Next(1,20);
```

### Exempel

Nedan hittar du några exempel på spelomgångar så som det sett ut i consolen.

- Exempel 1
    
    ```
    Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.
    2
    Tyvärr du gissade för lågt!
    9
    Tyvärr du gissade för högt!
    7
    Tyvärr du gissade för högt!
    4
    Tyvärr du gissade för högt!
    5
    Tyvärr du gissade för högt!
    Tyvärr du lyckades inte gissa talet på fem försök!
    ```
    
- Exempel 2
    
    ```
    Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.
    4
    Tyvärr du gissade för högt!
    2
    Woho! Du gjorde det!
    ```
    
- Exempel 3
    
    ```
    Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.
    4
    Woho! Du gjorde det!
    ```
    

### Extra utmaning

Känns uppgiften för enkel? Blev du klar snabbt?

Här får du lite idéer på hur du kan göra uppgiften lite mer avancerad. Testa så mycket du vill med dessa! Klicka på pilarna för att läsa mer.

- Välja svårighetsgrad
    
    <aside>
    🤔 Låt spelet starta med att programmet frågar om svårighetsnivå. Antingen kan du göra så att användaren får välja olika nivåer, exempelvis genom att skriva in en siffra mellan 1 och 5, och sen baserat på svaret så blir spelet olika svårt. Eller så kanske användaren får skriva in hur många tal det ska finnas att gissa på.
    
    Du kan modifiera både hur många tal som programmet slumpar mellan och hur många försök användaren får. Enkel nivå är kanske 10 tal och 6 försök. Mellannivå är kanske 25 tal och 5 försök. Svår nivå är kanske 50 tal och 3 försök.
    
    </aside>
    
- Variation i svaren
    
    <aside>
    🤔 Visst är det tråkigt att programmet svarar som en robot och säger samma sak varje gång? Gör det roligare!
    
    Kom på kanske fyra eller fem olika varianter av svar för exempelvis "Tyvärr du gissade för högt!". Kanske kan programmet svara "Haha! Det var för högt!" eller "Bra gissat men det var för högt".
    
    Låt sedan programmet variera sina svar. De ska forfarande berätta om det är för högt eller lågt men med lite variation i språket.
    
    </aside>
    
- Det bränns!
    
    <aside>
    🤔 Gör svaren på gissningarna lite mer anpassade utifrån hur nära rätt nummer användaren gissar!
    
    Om programmet tänker på ex. siffran 7 och användaren gissar 6 kan den istället säga "Det bränns!" eller "Det var nära!". Men om användaren gissar på 2 kan programmet svara exempelvis "Oj, det var långt ifrån".
    
    Här kan du vara kreativ och komma på flera olika typer av svar baserat på hur nära eller långt ifrån siffran som användaren gissar.
    
    </aside>
    
- Starta om spelet
    
    <aside>
    🤔 Som du märker är det lite tråkigt att spelet tar slut när man gissat rätt eller använt alla sina försök. Gör så man kan starta om spelet utan att köra om programmet!
    
    Ett snyggt sätt kan vara att spelet i slutet frågar typ "Vill du spela igen?" och om användaren skriver "ja" startas spelet om.
    
    </aside>
    

Om du gjort dessa utmaningar kan visa upp denna labb med dessa funktioner inkluderade såklart!