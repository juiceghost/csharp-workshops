Denna uppgiften är tänkt som en första intro till databaser. Du bekantar dig med DbGate och att skriva enklare queries inuti DbGate

# Vad du ska göra

- [ ]  Skapa ett "användarnamn" som är unikt i klassen. Ta första bokstaven i ditt förnamn följt av första och andra bokstaven i ditt efternamn, bara små bokstäver. Kristian Kjeldsen -> "kkj"
- [ ]  Anslut till Monsters (hostad postgres) i DbGate (credentials ligger i klasskanalen). Gör nedanstående enbart med hjälp av SQL queries. Använd alltså bara Query-vyn i DbGate, inte GUI:t i övrigt.
- [ ]  Skapa en ny tabell som heter kkj_student (byt ut kkj som ditt eget användarnamn)
- [ ]  Skapa sex kolumner, id, first_name, last_name, email, age och password. Skapa id med attributet SERIAL. De övriga datatyperna får du välja själv.
- [ ]  Stoppa in 3 olika påhittade studenter i din tabell 
- [ ]  Skriv en SQL-fråga för att läsa ut alla studenter samt en för att läsa ut en student med en viss email
- [ ]  Skriv en SQL-fråga för att uppdatera lösenordet på en student med en viss email
- [ ]  Spara alla dina SQL-frågor med en kort kommentar om vad de gör i en textfil, de kommer behövas senare. Tänk på att alla queries försvinner när du stänger ner DbGate

Visa dina queries samt att de fungerar mot din databas för att klara workshopen