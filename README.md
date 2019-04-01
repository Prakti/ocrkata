Pseudo OCR
==========

Szenario Description
-----------------------
You work for a bank, which has recently purchased an ingenious machine to assist
in reading letters and faxes sent in by branch offices. The machine scans the
paper documents, and produces a file with a number of entries which each look
like this:
```
  _  _     _  _  _  _  _
| _| _||_||_ |_   ||_||_|
||_  _|  | _||_|  ||_| _|
                           
```

Each entry is 4 lines long, and each line has 27 characters. The first 3 lines
of each entry contain an account number written using pipes and underscores, and
the fourth line is blank. Each account number should have 9 digits, all of which
should be in the range 0-9. A normal file contains around 500 entries.

Your Task
----------
Your first task is to write a program that can take this file and parse it into
actual account numbers.

Example
--------
* Input:
```
    _  _  _  _  _  _     _ 
|_||_|| || ||_   |  |  ||_ 
  | _||_||_||_|  |  |  | _| 

```
* Ouput: 490067715

Dojo Mode (Randori Style)
----------------------------
* Pairing and Timeboxing
  * The driver has the keyboard and has control what is written
  * The navigator helps to keep the overview and has the right to stop him 
  * Everyone else is just spectator 
  * Timebox is 5 Minutes
  * After the timebox the driver rejoins the audience and the navigator becomes the driver
* Test Driven Design
  * Identify a sub-problem of the whole kata
  * Write the smallest possible test that solves a sub-problem
  * Make the test green
  * Refactor code but keep the test green
  * Babystepping: solve the smallest possible sub-problem at a time

Hints
------
* Example Testdata is located in the `data` directory
* Your solution should either read input via std-in or should take a
  filename as the first parameter and then reading input from that file.
* Your solution should either write output to std-out or should take a filename
  as the first or second parameter and write output to that file.
* Start with a test for a function that receives three strings and either
  returns the digit "8" or returns an error.
