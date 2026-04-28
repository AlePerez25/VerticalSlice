# GDIM33 Vertical Slice
## Milestone 1 Devlog
Alejandra Perez
1) The Visual scripting graph that I am going to talk about is the one found inside player saved as “Player”, specifically the group “player movement”. This graph is responsible for making the player move at the moment the player presses any of the WASD keys on the keyboard, it will receive the message that the player needs to move. In the graph we have the “On input event vector 2” which connects to the Player input called “PlayerControl” inside the gameobject. Assigned with “On hold” and “Move”, this is connected to the vector 2 linked with the respective X and Y axis which are multiplied by speed (10), this result is multiplied once again with delta time, this is the result that is given to the vector on the x axis and z = y. All in charge of reacting immediately to the keyboard input. Thanks to this we can enjoy a clean and concise movement in the game.

2) The state machine that I made for myself is divided into two different states “walking” which is walking and “chasing” which is chasing connected by two transitions. This is located in the core of the monster “Zombie”. The state machine itself is called “NPC”. The first part “walking” is made up of nodes such as update, random range, navmeshagent set destination, cooldown, vectors and navmesh. All these nodes are responsible for generating a random location around the map 20 units away from its current position every 2–4 seconds, this loads the “walk” animation. This connects to the state called “chasing” which has nodes such as update, find object with tag, get position and set destination navmesh agent. This is responsible for detecting the player when they are circulating near the monster in order to proceed to chase them by changing its current position to the player’s position, this also loads the “Attack” animation. Both are connected by two transitions, the first is from walking → chasing which indicates that if the distance to the player is less than 15 the transition can occur and it switches to attacking, while the transition chasing → walking indicates that the transition can occur only if the distance is greater than 18 and it switches from attacking to walking. Basically, the entire functioning system of my monster is inside that state machine.

This will be connected in the future to the player quest system since it will be the biggest impediment/challenge for the player. Thanks to this movement and detection, the player will be able to run into the monster around the terrain and chases will have to occur. It is also connected to the player health reduction system that I made in a C# script, when the monster gets very close to the player and collides with them the player loses health and is forced to look for safety kits to recover a percentage of health. For the break down I only added one more box where I briefly explain how it works and what things it activates, this is connected to the navmesh and animations boxes.


## Milestone 2 Devlog
Milestone 2 Devlog goes here.
## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
