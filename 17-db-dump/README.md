Denna uppgiften är designad för att du ska träna på att ta "backup" av data och struktur i en databas. Det är några inställningar som behövs. Du kommer att använda DbGate för denna labb.

# Vad du ska göra

- [ ]  Anslut till Monsters (hostad postgres) i DbGate (credentials ligger i klasskanalen). 
- [ ]  Du har två tabeller i databasen nu, kkj_student och kkj_course
- [ ]  Högerklicka på en av dina tabeller nere till vänster i DbGate, välj alternativet SQL Generator: CREATE TABLE
- [ ]  Du får nu upp Generator-vyn i DbGate. Notera att din tabell blev ikryssad nere till vänster. Om du t.ex valde kkj_student är den ikryssad. Kryssa även i din andra tabell, kkj_course.
- [ ]  Till höger i DbGate har du ett antal alternativ, några är kryssade som default. 
- [ ]  I min DbGate är Create tables, Create foreign keys samt Create indexes ikryssade som default.
- [ ]  Kryssa även i Drop tables, Test if exists
- [ ]  Kryssa i Drop references
- [ ]  Kryssa sedan i Insert och Skip autoincrement column
- [ ]  Det du ser på skärmen nu är din DB-dump. Med hjälp av den kan du återskapa databasens struktur och innehåll var som helst.
- [ ]  Kopiera ut all text från DbGate och spara i en textfil. Kopiera in det i ett Query och kör det. Får du några errors? Allt ska vara som innan, så ibland är det svårt att se om det fungerar.
- [ ]  Gå in med DbGate och ändra manuellt något fält nånstans men gör ingen ny dump
- [ ]  Kör din dump som ett query. Är allt återställt som det var innan din ändring? I så fall fungerar det.
- [ ]  Det är ett väldigt värdefullt verktyg att kunna skapa och återställa dumpar, t.ex om nåt hänt med databasen.
