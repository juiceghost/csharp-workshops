Denna uppgift har jag lånat från [adventofcode](https://adventofcode.com/2021/day/11). Det är en bra fortsättningsövning på Shackbrädet då det finns vissa likheter mellan problemen, båda utgår ifrån ett rutnät.

# Beskrivning av problemet

Det finns 100 bläckfiskar arrangerade i ett 10x10 rutnät. Varje bläckfisk laddar sakta upp sin energinivå över tid och blinkar till när dess energinivå är full. Varje bläckfisk har en energinivå:

- Bläckfiskarnas startenergier

```
5483143223
2745854711
5264556173
6141336146
6357385478
4167524645
2176841721
6882881134
4846848554
5283751526
```

Bläckfiskens energinivå rör sig mellan 0 och 9, bläckfisken överst till vänster har energinivån 5, och bläckfisken nederst till höger har energinivån 6, osv.

Din uppgift blir nu att bygga en simulator som räknar ut varje bläckfisks energinivå, steg för steg. Under ett enda steg händer följande:
- Varje bläckfisks energinivå ökar med ett.
- Efter energinivåerna har ökat blinkar varje bläckfisk vars energinivå är större än 9.
- Detta ökar energinivåerna på alla närliggande bläckfiskar (inklusive diagonalt närliggande) med 1. Det kan leda till att ytterligare bläckfiskar blinkar, och deras grannars energinivå ökar med ett, och så vidare. En bläckfisk kan bara blinka maximalt en gång under ett steg.
- Slutligen, alla bläckfiskar som blinkat under ett steg får sin energinivå satt till 0.

Det kan hända att en bläckfisk blinkar även om den börjar med en låg energinivå. Se följande exempel:
```
Innan stegen:
11111
19991
19191
19991
11111

Efter steg 1:
34543
40004
50005
40004
34543

Efter steg 2:
45654
51115
61116
51115
45654
```

Nedan följer ett större exempel:

```
Before any steps:
5483143223
2745854711
5264556173
6141336146
6357385478
4167524645
2176841721
6882881134
4846848554
5283751526

After step 1:
6594254334
3856965822
6375667284
7252447257
7468496589
5278635756
3287952832
7993992245
5957959665
6394862637

After step 2:
8807476555
5089087054
8597889608
8485769600
8700908800
6600088989
6800005943
0000007456
9000000876
8700006848

After step 3:
0050900866
8500800575
9900000039
9700000041
9935080063
7712300000
7911250009
2211130000
0421125000
0021119000

After step 4:
2263031977
0923031697
0032221150
0041111163
0076191174
0053411122
0042361120
5532241122
1532247211
1132230211

After step 5:
4484144000
2044144000
2253333493
1152333274
1187303285
1164633233
1153472231
6643352233
2643358322
2243341322

After step 6:
5595255111
3155255222
3364444605
2263444496
2298414396
2275744344
2264583342
7754463344
3754469433
3354452433

After step 7:
6707366222
4377366333
4475555827
3496655709
3500625609
3509955566
3486694453
8865585555
4865580644
4465574644

After step 8:
7818477333
5488477444
5697666949
4608766830
4734946730
4740097688
6900007564
0000009666
8000004755
6800007755

After step 9:
9060000644
7800000976
6900000080
5840000082
5858000093
6962400000
8021250009
2221130009
9111128097
7911119976

After step 10:
0481112976
0031112009
0041112504
0081111406
0099111306
0093511233
0442361130
5532252350
0532250600
0032240000
```

Efter steg 10 har bläckfiskarna totalt blinkat 204 gånger. Efter 100 steg har bläckfiskarna totalt blinkat 1656 gånger. Det är detta ditt program ska räkna ut.

# Vad du ska göra

- [ ]  Skapa ett nytt projekt i Visual Studio (Console Application → C# → .Net Core)
- [ ]  Döp projektet till "DumboOctopus"
- [ ]  När programmet startar ska användaren få mata in hur många rundor simuleringen ska fortgå
- [ ]  Du kan hårdkoda bläckfiskarnas startenergier eller ladda från en fil. Se Bläckfiskarnas startenergier nära toppen av dokumentet.
- [ ]  Programmet ska skriva ut hur många blinkningar totalt bläckfiskarna gör på det antalet steg användaren matar in
- [ ]  I denna text framgår hur många blinkningar som skett efter 10 steg och efter 100 steg. På så sätt kan du testa om ditt program fungerar korrekt
- [ ]  Tänk på att under ett steg kan en bläckfisk endast blinka en gång
- [ ]  Om du lyckas få det att fungera, gå in på adventofcode-länken överst i dokumentet och testa med den indatan.
