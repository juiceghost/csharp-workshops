I denna övning kommer ni att bygga en simulator för att poppa popcorn. Börja med att simulera e påse micro-popcorn för att sedan utöka till flera påsar som poppas parallellt i var sin microvågsugn. Tänk er att ni poppar dem på skolan där vi har många micros. 

# Vad du ska göra

- [ ] Skapa en klass för en popcornpåse
- [ ] Klassen ska ha ett attribut som identifierar påsen, t.ex id eller namn
- [ ] Klassen ska även ha ett attribut som anger antalet popcorn som är poppade i procent. Initialt är detta värde 0.
- [ ] När simuleringen startar så börjar popcornen att poppas. Bestäm att det tar 3 minuter för en popcornpåse att poppas, då har antalet poppade popcorn i procent nått 99%. Efter 1 minut har 33% poppats och efter 2 minuter har 66% poppats
- [ ] Varje popcornpåse poppas i en egen tråd. Använd async/await Få först simuleringen att fungera för en påse, lägg sedan till fler.
- [ ] Bestäm hur långt ett "tick" ska vara, dvs hur länge varje tråd ska vänta innan den räknar ut hur många popcorn som poppats.
- [ ] Efter varje tick ska objektet uppdateras med hur länge den har varit inne i micron och hur många av popcornen som poppats i %

### Extra utmaning

Vill du ha lite mer utmaning så kan du försöka implementera följande:

- [ ]  Få in så att det går att poppa på olika energiinställningar i micron.
- [ ]  Simulera vad som händer om man öppnar micron mitt i poppningen

### Resurser

Du kan med fördel spana in detta repo:
https://github.com/juiceghost/egg-boiler