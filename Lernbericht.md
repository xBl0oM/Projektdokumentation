# Lern-Bericht
Jan Frey

## Einleitung

Wir haben im Lernatelier eine ZAhlengenerator Spiel programmiert.

## Was habe ich gelernt?

Dabei habe ich die Try Cath methode kennengelernt.

## Beschreibung
Die Try Catch Methode ist ein Weg um das Abstürzen des Programmes zu verhindern. Ich habe die Try Cath methode folgendermassen gebraucht: Ich habe den Benutzer nach einer
Zahl abgefragt. Was Passiert jetzt aber, wenn der Benutzer einen Buchstaben abgibt? Das Programm stürzt ab. Und hier kommt die try Catch methode ins Spiel. 
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


* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme

* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
