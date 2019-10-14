# opdracht 1

Bekijk eerst `Program.cs`. Bovenaan wordt een output samengesteld. Die kan je op twee manieren bekijken: via het console scherm en via een browser. Open in de browser ook eens de source code (right-click -> view source). Daar zie je dat de output gelijk is aan die van je console scherm.

We maken dus eigenlijk HTML code in deze oefening. Deze eerste opdracht laat je naar elementen van de code kijken, zodat je goed begrijpt hoe die in mekaar zit.

De HTML tag voor een paragraph is `<p>`. Je ziet die tag niet in `Program.cs`. 
- In welke class wordt die tag toegevoegd? 
- In welke class wordt ze in de output verwerkt?
- Hoe en waar wordt de closing-tag (`</p>`) gemaakt?
- In hoeverre zijn de classes `Paragraph` en `Heading1` gelijk?

De HTML tag voor een div is `<div>`. 
- In welke class wordt die tag toegevoegd?
- In welke class wordt ze in de output verwerkt?
- Hoe is `Div` anders dan `Paragraph`?

Er bestaat ook een class `Utils`. 
- Hoe is deze class anders dan de andere classes?
- In welke bestanden wordt de functie `GetTabs()` gebruikt?
- Hoe kan het dat we deze functie kunnen gebruiken zonder eerst een object van de class `Utils` te maken?

  
Nu je de meeste classes in deze oefening bekeken hebt:
- Vergelijk deze classes met het diagram van het decorator pattern in de cursus. Ga bij elke class na waar die thuishoort in het diagram.
- Het decorator pattern wordt gebruikt met de functie `RenderContent`. Waar wordt die gedeclareerd?
- De functie `RenderContent` heeft als eerste argument een tabIndex. Op welke manier wordt die waarde gebruikt?
- We geven nergens exact in hoeveel tabs we nodig hebben. Toch gebeurt het inspringen in de gegenereerde code heel ordelijk. Hoe kan dat?
- In het programma wordt er een lege `List<String> result` doorgeven aan het buitenste object (`output`). Na het renderen van de content bevat die string alle html code. Volg het spoor van deze list. Naar welke class wordt ze eerst doorgegeven? Wat voegen we daar toe? Hoe gaat het verder? Zorg dat je het hele traject tot het eind kan plaatsen.

# opdracht 2

- Voeg een extra `div` toe aan de code. Bekijk het resultaat. (In je browser zie je geen verschil, omdat een div op zich geen opmaak heeft.)
- Vervang de paragraaf door een `Heading1` object. Bekijk weer wat het verschil is.
- Voeg een extra class toe voor `Heading2`. Gebruik deze heading in je programma en controleer of dit de juiste HTML code genereert.
- We kunnen elementen nu enkel in een div plaatsen. Maar eigenlijk moeten we op z'n minst `<html>` en `<body>` tags hebben om een correct document te genereren. Doe dit en gebruik deze nieuwe tags. Controleer of je een correct document krijgt.
- De `<html>` tag is eigenlijk nog niet volledig. Het document zou er zo moeten uitzien:

```
<!DOCTYPE HTML>
<html>
<head>
<title>Title of the document</title>
</head>

<body>
The content of the document......
</body>

</html>
```
Om dit te kunnen doen kan je niet verder met de huidige `RenderContent` functie in `HTMLWrapper`. Maar gelukkig is die functie **virtueel**. Je kan ze dus overschrijven in je `Html` class. Zorg er voor dat je document eruit ziet zoals hierboven.

# opdracht 3
We kunnen nu altijd maar één object in een HTMLWrapper of een afgeleide class steken. Maar veel classes in HTML, zoals `<body>`, kunnen in praktijk meer dan één object bevatten. Zo kan de inhoud van een body achtereenvolgens een heading en verschillende paragrafen bevatten. 

Om dit te implementeren maken we eerst een nieuwe decorator: `HTMLContainer`. Een container is bijna gelijk aan `HTMLWrapper`, maar bevat een list van het type `IElement`, in plaats van slecht een enkel element. De constructor moet er dus zo uitzien:

```
public HTMLContainer(string tag, List<IElement> wrappedObjects) { ... }
```

Ook de `RenderContent` functie moet anders zijn. Hierin ga je nu ook alle wrappedObjects af via foreach, om van elk object opnieuw de `RenderContent` functie uit te voeren.

Als je nieuwe class klaar is, dan herwerk je de `Body` class zodat die gebaseerd is op `HTMLContainer` in plaats van `HTMLWrapper`. 

Test dan je code door in body een list met verschillende elementen, zoals een `Heading1` en enkele paragrafen te plaatsen. Je kan je resultaat controleren door te zien of je correcte html code krijgt. Het moet ook mogelijk zijn om een `Div` object toe te voegen aan je body.

# opdracht 4 (extra uitdaging)
- Zoek eens op hoe je de kleur van de tekst en de achtergrond in voor een HTML element kan instellen via inline css (dus zonder een afzonderlijke stylesheet te gebruiken). 
- Bij welke classes is het zinvol om dat te doen? Voeg in dat geval extra argumenten aan de constructor toe om die kleuren in te stellen. 
- Herwerk ook de render code zodat de gegenereerde HTML code correct is.
- Maak van deze constructor argumenten optionele argumenten, zodat je ze ook kan weglaten.
- Voor een extra handige manier om dit te gebruiken, zoek je op hoe je *named arguments* gebruikt in C#. Herwerk dan je programma om je variabelen in te stellen via named arguments.







