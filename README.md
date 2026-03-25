Assignment 2: TEB 1043 Object Oriented Programming (Part of the Group Project: The Feline Witness)



Brief Description

This GitHub repository contains the implementation for Assignment 2, serving as a functional prototype for our group project, "The Feline Witness." Developed entirely in C#, this menu-driven, console-based interactive fiction game places the player in the unique perspective of a household cat.



After witnessing a suspicious encounter, the cat discovers the husband is conducting a secret affair while the wife is away. The ultimate goal is for the feline protagonist to disrupt the husband's plans—such as by stealing and hiding his car keys—and eventually finding a way to expose the truth to the wife.



Group Members

Ahmad Zafran Bin Faizal (24005345)



Muhammad Wafi Bin Azman (24005379)



Muhammad Asyraaf Bin Mustafa (24005305)



Lee Xin Yue (24005697)



Humaira Rayyan Binti Haslah (24005364)



Amier Aiman Bin Mohamad Faizal (24005402)



1.0 Project Description

This project was developed specifically for Assignment 2 of the Object-Oriented Programming course. It acts as a standalone simulation derived from our primary project, designed to demonstrate core OOP principles—specifically Encapsulation and Object Interaction. To meet the assignment requirements, the architecture implements the Character, HouseSpace, and Item classes from our original UML design.



In this mini-game, the player controls a highly observant house cat investigating its owner (the husband). Noticing the husband's suspicious behavior with his smartphone in the living area, the cat must track down his exact location to uncover the truth. The simulation concludes successfully when the player identifies Sofa 2 in the Living Room as the target. The gameplay emphasizes exploration and spatial movement, allowing players to navigate through encapsulated HouseSpace objects and inspect the Item objects within them to trigger a seamless flow of data between instantiated objects.



2.0 System Features

Interactive Spatial Navigation:

The game utilizes a robust "travel" system. By inputting the 'C' command, players can view available rooms and move the character between different HouseSpace objects. The system securely tracks the character’s location through established OOP properties.



Environment Exploration \& Object Interaction:

Using the 'E' command reveals the Item objects present in the current room. Selecting an item triggers an interaction sequence where the system evaluates if the object is the mission target, demonstrating dynamic object-to-object communication.



House Map Interface:

Players can access an ASCII-art map of the house at any time by pressing 'M'. This feature assists in visualizing the layout of all HouseSpace objects to help plan the next move.



Custom Text Rendering Engine:

To improve the console experience, the project includes a custom delayedText method. This simulates real-time typing with adjustable speeds and ANSI color codes. A "skip" mechanic is included, allowing players to bypass the delay by pressing any key.



Encapsulated State Management:

To fulfill core assignment requirements, the system strictly protects its data. Sensitive variables, such as room item lists and character locations, are stored in private fields and accessed exclusively through public properties or controlled methods.



