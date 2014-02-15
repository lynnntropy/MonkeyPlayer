MonkeyPlayer
============
![Screenshot](http://i.imgur.com/JqkoV2e.png)

A .NET application designed to play games via random keypresses and mouse movements.

Licensed under GPLv2.

Inspired by the whole 'Twitch Plays Pokemon' thing, I decided to see if I could write a program to do the
same thing, and so MonkeyPlayer was born. Nearly every aspect of the input emulation can be controller from
the GUI, so you shouldn't need to dig into the code to change anything.

I've tested it with VirtuaNES and Snes9x, but in theory, any emulator or application (game or otherwise)
should work because the library used for input emulation is completely compatible with DirectX 
input.

The only external dependency is the .NET Framework, v3.5.