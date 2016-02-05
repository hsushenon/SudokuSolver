# SudokuSolver

Sudoku solver is done in Universal Windows Platform. This is the first proper UWP app made by me.
This was actually made long long time ago, in C!!
Now doing it in UWP just for learning purpose.

The UI is simple, the logic behind how i did this is a bit complicated though. You cant really expect to solve 
Sudoku with simple logic :). I will try to explain here.

Logic 1
For every cell check if only one number is valid.
 
Logic 2
Test the choices. If one of the choice is not repeated it is entered into the cell. Suppose positon(2,3) has 2,3,4 as valid chioce.     
If the number 2 is not a choice in the other cells of 2nd row number 2 has to be in position(2,3).  Similarly check for other choices if 2 is repeated. also check in 3rd column,and the grid similarly.

Logic 3
Is the complicated part, find the explantion in the "Logic 3 explained.doc" 
  
Note: Part of the logic was given to me by Li Moi who actually use to solve Sudoku. I have no patience to solve it.
So thanks Li Moi.


