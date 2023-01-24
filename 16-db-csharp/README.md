Denna uppgiften är tänkt som en första intro till att lära sig prata DBs från C#. Du bekantar dig med Dapper, ConfigurationManager samt Npgsql

# Vad du ska göra

- [ ]  Skapa ett nytt projekt i Visual Studio.
- [ ]  Skapa en ny klassfil och döp den till StudentModel
- [ ]  Skapa fält (förslagsvis med prop<tab x 2>) som du döper samt ger samma datatyper som din tabell
- [ ]  Skapa en ny klassfil och döp den till CourseModel
- [ ]  Skapa fält (förslagsvis med prop<tab x 2>) som du döper samt ger samma datatyper som din tabell
- [ ]  Skapa en ny klassfil PostgresDataAccess
- [ ]  Skapa funktioner lika de Tim Corey skapar i sin video
- [ ]  Lägg till tre paket med NuGet package manager, Dapper, Npgsql samt ConfigurationManager
- [ ]  Lägg till en ny Application Configuration File som ska ligga under "C# Items" när du tar new.
- [ ]  Skapa ett menysystem med följande alternativ

- Exempel 1
    
    ```
    Välkommen till databasen! Vänligen välj ett av nedanstående alternativ:
    1. Lista studenter
    2. Lista kurser
    3. Skapa student
    4. Skapa kurs
    5. Byt lösenord
    6. Redigera kurs
    7. Radera kurs
    A. Avsluta
    
    ----> A

    Tack för att du använde databasen och välkommen åter.
    ```

    - [ ]  Bygg funktionalitet utifrån de olika alternativen genom att direkt prata med databasen
    - [ ]  Det är alltså förbjudet att först läsa in all data från databasen och göra ändringar där
    - [ ]  Läs in datan varje gång den behövs
    