SHOOT VIDEOGAME

This is a first person shooter videogame centered in a combat using a gun against enemies in a first

person perspective. The first objective is to cross a labyrinth until the end; the labyrinth has many

enemies like robots and traps that try to destroy the first person player. The game has a second

objective; the player should destroy the boxes with a gun. The ammo for the player’s gun is in an

ammo boxes. The labyrinth indicate if the player is on the right path when blue lights are lighting.

The game have a menu to pause or to continue the game with the P key. The player has four

attempts to through the labyrinth. If the player is touched by the shoot ́s enemies or by the traps,

he will die. The game finishes if the player arrive to the goal or die four times.

Implementation of requirements:

- A full 3D scene including different spaces, configuration, textures and lights:

The videogame has a labyrinth composed of a floor, walls and roof with different textures. The

skybox has a light by default and the enemies have red lights inside of the labyrinth.

- A start screen with a ‘Start’ button and an end screen with top scores and players

A canvas with two buttons has implemented in the start screen of the videogame: start level and

quit game. The game has a pause system using P Key. The videogame shows the final score in the

end or when the players loss all his lives.

- A Head-Up Display with current score, lives, map, and inventory

The manager of the system and states of the videogame was made by a class GameManager. This

class has the information of the lives of the player, the ammo and the score. This class displays that

information through a canvas. For the MiniMap, the videogame include a camera with a vertical

view.

- Game objects that illustrate different types of collisions

The game has different types of collisions, implemented in the shoot at the boxes or shoot at the

player. That collisions display many effects like explosions, sounds, lights, etc.

- Change the environment of the scene based on trigger events (OnTriggerEnter/Stay/Exit).

examples include turn the lights on/off, change textures, and so forth

Trigger events implemented with lights examples. When the player pass through the right path blue

the lights turn on.

- Have static “enemies” that shot projectiles towards the player

In the videogame, there are robots. Those robotsshoot to the player. If this bullets touch the player,

this loss a life. That mechanic implemented using the collisions system.

- Update score, inventory, and lives based on game elements, such as picking up objects,

shooting targets, being shot, etc.

The class GameManagerShoot manages all this events of the system. This class have the information

of the how many ammo have the player, his score and his lives.

- Extra functionalities, such as higher level of creativity and complexity on game mechanics,

other visual effects, etc.

It was implemented display effects like explosions, sounds, etc.

The game use assets of the unity store. The Unity version used was 5.6.0f.3

Deployment

Open the project in Unity and Build it.
