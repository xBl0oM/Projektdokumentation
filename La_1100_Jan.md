# Projekt-Dokumentation

Jan Frey

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 25.08 | 0.0.0   |  Heute habe ich das Projekt geplant.
|  01.09  | 0.0.1   |   Ich habe das Programm im Zahlenraum von 1-100 programmiert.|                                                           |
| 08.09  | 0.0.2   |    Ich habe den Modus von 1-1000 programmiert, verschieden Farben bei Sieg und Fehlermeldungen eingefügt und ein schöner Titel ist nun auch vorhanden.    |


## 1 Informieren

### 1.1 Random Number generator

Der Random Number Generator ist ein generator, der eine Zufällige Zahl zwischen x-y generiert, die man anschliessen erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |     Muss        |  Funktional    | Der Generator soll Zahlen zwischen 1-100 generienern |    
|   2    | Muss    |  Funktionalität   | Soll Tips geben: Zahl zu gross/ Zahl zu klein |
| 3|Kann| Qualität| Soll benutzerdefinierte Fehlermeldungen geben:Z.B Ich verstehe nur Zahlen|
|4| Kann | Qualität| Hard Mode mit Timer|
|5| Kann| Qualität | Hard Mode  mit z.B. nur 5 Versuchen |
|6| Kann | Qualität | Drop Down menü, zur auswahl der Modi |
|7|Kann|Qualität| Text farbig bei z.B Fehler.|
|8|Kann|Qualität| Spielt Hintergrund musik in endlosschleife ab|
|9|Kann|Qualität| Spielt speziellen Sound bei Sieg ab |


### 1.3 Testfälle


| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Code kann zahlen generiern |Programm starten|Zahl zwischen 1-100 generiern|
|2.1|Generierte Zahl ist 58| benutzer gibt 13 ein| Nachricht: Ihre Zahl ist kleiner als die Zufallszahl|
|2.2|Generierte Zahl ist 58|benutzer gibt 98 ein |Nachricht: Ihre Zahl ist grösser als die Zufallszahl|
|3.1|Generierte Zahl ist 24|eingabe Abcd|Nachricht: Ich verstehe leider nur Zahlen|
|3.2|Generierte Zahl ist 24|eingabe -999| Nachricht: Ich verstehe leider nur Zahlen zwischen 1-100|
|4.1|Benutzer hat Normalen Modus geschaft und sieht den Hard Mode| Wählt Hard Mode aus| bekommt neue Herausf bekommt neue Herausforde orderung, z.B auf Zeit|
|5.1|Benutzer hat Normalen Modus geschaft und sieht den Hard Mode|Wählt Hard Mode aus|bekommt neue Herausf bekommt neue Herausforde orderung, z.B nur 5 versuche|
|6.1|Benutzer hat Normalen Modus geschaft und sieht den Hard Mode| Clickt auf Hard Mode| Drop Down Menü erscheint zur auswahl der Modi|
|7.1|Benutzer hat Normalen Modus geschaft und sieht den Hard Mode|Clickt auf Hard Mode| Hard Mode: 1-1000|


### 1.4 Diagramme![PapDesigner - Zufallszahl pap 25 08 2022 11_28_12](https://user-images.githubusercontent.com/111044215/186629037-996a88d8-0520-4ff1-a57c-457a16ab5299.png)
![PapDesigner - Zufallszahl pap 25 08 2022 11_28_27](https://user-images.githubusercontent.com/111044215/186629052-ad26b31c-8ee3-4267-a7f8-f4e00ab2c47c.png)




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.1  | 1.9.22 |  Jan |Code zum Zahlen generieren bringen|1 Arbeitspaket|
| 2.1 |1.9.22   |    Jan       |    Code grundsatz fertig d.h Spiel funktioniert soweit|3 AP|
| 4 | 8.9.22|Jan| Tips fürs Spiel|0.5 Ap|
|5.1|15.9.22|Jan| Bessere Fehlermeldung| 1 Ap|
|5.2|15.9.22|Jan| Bessere Fehlermeldung| 1 Ap|
|6.1|22.9.22|Jan| Hard Mode| 3 Ap|
|6.2|29.9.22| Jan| Hard Mode 2.0|3Ap|
|6.3|29.8.22|Jan|Hard Mode 3.0|2Ap|
|8.1|29.9.22| Jan|Drop Down Liste|2AP|

Total: 14,5 Arbeitspakete


## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.1  |  1.08     |  Jan         |    1AP           |   30min                |
| 2.1  |    1.08   | Jan          |  3AP             |    100 min                |
|  4   |1.08     |Jan|25min | 20min|
|5.1/5.2|08.09|Jan|2 Ap min| 65min|
|6.3|08.09|Jan|90 min | 90 min|



✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
