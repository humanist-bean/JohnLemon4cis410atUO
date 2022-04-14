# JohnLemon4cis410atUO
CIS 410 Game Programming Homework Assignment #2 - Based off Unity's "John Lemon's Haunted Jaunt" game development tutorial. 
by Alder French

Additions for Me:
Inverted the keyboard movement so up makes JohnLemon go up, down makes him go down, ect... I just found it annoying the other way. 

Additions for Homework:
I added a "Magic Gargoyle" to the map. If you go past the gargoyle down on the right from spawn and into the room on the right, you will find the "Magic Gargoyle".

This Gargoyle razzles and dazzles thanks to my particle effects. Try walking into the Gargoyle and you will see some very SpOoKy things happen. 

I used a vector3 dot product to track the squared distance between my player and the gargoyle (thereby avoiding costly square roots). It's floating activates when you get within a certain distance. I used LERP to make the Gargoyle "float" upwards when you approach it. The speed the Gargoyle floats up at is determined by the direction and speed with which you approach it thanks to the LERP function. In other words, it makes my Gargoyle "slide" up based on John Lemons approach.  
