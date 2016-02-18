# Letter-Hunt
The goal of this project is to develop a snake game version which can be used in “idiom” and “proverb” learning in Turkish

General Information

The game is played by controlling a “moving snake” in game area. There are several letters which belong to the particular idioms or proverbs based on the levels in the game area. When the snake eats these letters, it becomes longer. If the snake bumps into a wall or its own body, the game will be over


“Idioms” and “Proverbs” Information

At the beginning of the game, “statements.txt” file is loaded. In this file, there are five idioms and five proverbs for each game level – there are four levels in the game. In the first three levels, the specific idioms, however; in the last level, the specific proverbs will be shown up at the top right position of the game area.

“Game Playing” Information

At the beginning of the game, the snake starts to move when the player pushes a button on the keyboard. During the game, an idiom (in the first three levels) or a proverb (in the last level), which is selected randomly from the “statements.txt” file, appears at the top right position of the game area. The player has to collect the letters in the correct order based on the given statement by moving the snake. Each correct letter is appended to the snake after the character ‘%’, however; each wrong letter is appended to the snake after the character ‘+’. 

“Game Level” Information

Each level contains 2 different idioms or proverbs, and its own game screen layout. The inner walls of the game area for each level will be generated randomly as defined in the following:

*In the first level, there are two different inner walls which have 10-character block.
*In the second level, there are four different inner walls which have 10-character block. 
*In the third level, there are six different inner walls which have 10-character block. 
*In the last level, there are eight different inner walls which have 10-character block. 

