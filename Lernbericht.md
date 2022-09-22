# Lern-Bericht
Jan Frey

## Einleitung

Wir haben im Lernatelier eine Zahlengenerator Spiel programmiert.

## Was habe ich gelernt?

Dabei habe ich die Try/Catch methode kennengelernt.

## Beschreibung
Die Try/Catch Methode ist ein Weg um das Abstürzen des Programmes zu verhindern. Ich habe die Try/Cath methode folgendermassen gebraucht: Ich habe den Benutzer nach einer
Zahl abgefragt. Was Passiert jetzt aber, wenn der Benutzer einen Buchstaben abgibt? Das Programm stürzt ab. Und hier kommt die Try/Catch methode ins Spiel. 
Die Methode funktioniert folgendermassen:
```csharp 
bool verstanden = false;
while (!vestanden)
{
  try
     {
     Console.ReadLine;
     verstanden = true
     }
  catch
     {
     Console.WriteLine("Das habe ich nicht verstanden.")
     }
}
```
Zuerst habe ich den bool verstanden als false deklaniert, damit ich eine Zeile weiter unten bestimmen kann, dass es das nachfolgende solange wiederholen soll, 
bis verstanden = true ist. Try sagt aus, dass das Programm etwas Probieren soll. In diesem fall wäre es etwas einzulesen. Wenn es dies nicht schafft geht es weiter zum Catch.
Im Catch wird in der Konsole ausgegeben: Das habe ich nicht verstanden.
Jetzt wird das ganze wiederholt. Der Benutzer gibt etwas ein. Wenn das Programm es verstanden hat wird der bool verstanden auf true gesezt und die Schleife bricht ab. 

Hier noch ein Beispiel im echten Code



![image](https://user-images.githubusercontent.com/111044215/191687971-4bca8980-b7be-4be5-be90-bd7ad5203f10.png)




https://user-images.githubusercontent.com/111044215/191690956-1b1fd879-e51e-4b8b-a994-9b52ca65ffa2.mp4



## Verifikation
Im ersten Code sieht man den aufbau einer Try/Catch schleife. 
Das zweite Bild zeigt die Try/Catch schleife in meinem Code. 
Der Text erklärt wie eine Try/Catch schleife funktioniert und für was man sie brauchen kann. 
Das Video Demonstriert die Try/Catch schleife. 

# Reflektion zum Arbeitsprozess

Das Arbeiten im Präsenz- und Heimunterricht ist mir sehr gut gelungen. 

Ich war manchmal auf grund von zu wenig Schlaf unmotiviert und müde.


**VBV**: Ich versuche meinen Schlafrhytmus umzuformen, um mehr Schlaf zu bekommen.
