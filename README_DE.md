Pseudo OCR
==========

Szenario Beschreibung
---------------------
Sie arbeiten bei einem Paketdients bei dem in der täglichen Arbeit viel
maschinengeschriebene Etiketten verarbeitet werden müssen. Auf den Etiketten
stehen nummern, welche bereits maschinengetützt eingelesen werden. Das
Ergebnis sieht so aus:
```
  _  _     _  _  _  _  _
| _| _||_||_ |_   ||_||_|
||_  _|  | _||_|  ||_| _|
                           
```

Jeder Eintrag besteht aus 4 Zeilen und jede Zeile besteht aus 27 Zeichen.
Die ersten 3 Zeilen bilden eine Rückverfolgungs-Nummer deren Ziffern durch
die Zeichen `_` und `|` gebildet werden und die letzte Zeile ist vollständig
leer. Jede Rückverfolgungs-Nummer sollte aus 9 Ziffern die im Bereich 0-9
liegen. Eine normale Datei enthält normalerweise rund 500 Einträge.

Aufgabe
-------
Schreiben Sie ein Program, welches diese Datei entgegen nimmt und die Einträge
in richtige Rückverfolgungs-Nummern für die Weiterverarbeitung umwandelt.

Beispiel
--------
* Eingabe:
```
    _  _  _  _  _  _     _ 
|_||_|| || ||_   |  |  ||_ 
  | _||_||_||_|  |  |  | _| 

```
* Ausgabe: 490067715

Hinweise
--------
* Beispielhafte Testdaten liegen im `data` Verzeichnis
* Implementieren Sie Ihre Lösung in einem separaten Unerverzeichnis
* Ihre Lösung sollte Eingabe-Daten entweder über std-in entgegen nehmen,
  oder es ermögichen den Namen der Eingabe-Datei beim Aufruf zu übergeben.
* Ihre Lösung sollte Ausgaben auf std-out schreiben oder es ermöglichen den
  Namen der Ausgabe-Datei beim Aufruf zu übergeben.
* Das Verzeichnis mit Ihrer Lösung sollte eine kurze Readme enthalten in der
  beschrieben ist wie man sie übersetzt und aufruft.

