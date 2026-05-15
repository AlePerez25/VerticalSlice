# GDIM33 Vertical Slice
## Milestone 1 Devlog
Alejandra Perez

1) The Visual scripting graph that I am going to talk about is the one found inside player saved as “Player”, specifically the group “player movement”. This graph is responsible for making the player move at the moment the player presses any of the WASD keys on the keyboard, it will receive the message that the player needs to move. In the graph we have the “On input event vector 2” which connects to the Player input called “PlayerControl” inside the gameobject. Assigned with “On hold” and “Move”, this is connected to the vector 2 linked with the respective X and Y axis which are multiplied by speed (10), this result is multiplied once again with delta time, this is the result that is given to the vector on the x axis and z = y. All in charge of reacting immediately to the keyboard input. Thanks to this we can enjoy a clean and concise movement in the game.

2) The state machine that I made is divided into two different states “caminando” which is walking and “atacar” which is chasing connected by two transitions. This is located in the gameobject of the monster “Zombie”. The state machine itself is called “NPC”. The first part “camiando” is made up of nodes such as update, random range, navmeshagent set destination, cooldown, vectors and navmesh. All these nodes are responsible for generating a random location around the map 20 units away from its current position every 2–4 seconds, this loads the “walk” animation. This connects to the state called “chasing” which has nodes such as update, find object with tag, get position and set destination navmesh agent. This is responsible for detecting the player when they are circulating near the monster in order to proceed to chase them by changing its current position to the player’s position, this also loads the “Attack” animation. Both are connected by two transitions, the first is from walking → chasing which indicates that if the distance to the player is less than 15 the transition can occur and it switches to attacking, while the transition chasing → walking indicates that the transition can occur only if the distance is greater than 18 and it switches from attacking to walking. Basically, the entire functioning system of my monster is inside that state machine.

    This will be connected in the future to the player quest system since it will be the biggest impediment/challenge for the player. Thanks to this movement and detection, the player will be able to run into the terraind and somethimes find the monster and chases will have to occur. It is also connected to the player health reduction system that I made in a C# script, when the monster gets very close to the player and collides with them the player loses health and is forced to look for safety kits to recover a percentage of health. For the break down I only added one more box where I briefly explain how it works and what things it activates, this is connected to the navmesh and animations boxes.

   Game break-down:
   <img width="1498" height="1128" alt="Screenshot 2026-04-28 113659" src="https://github.com/user-attachments/assets/5950310a-f0e3-4571-99b5-aadcc46f7849" />


## Milestone 2 Devlog

#### Question 1:

Milestone 2 Important Features

Big Steps:

- Learn and create a Timeline for the game or for the Main Menu.
- Create a C# system to manage the light and filter system.
- Create a sanity system when the player is attacked by the zombie and hides inside the storag buildings around the map.

Small Steps:

1) Timeline:
    - See if I can find the assets needed for my idea (shadows); if not, draw them myself.
    - Watch recommended videos to understand Timeline better.
    - Start working and try creating a simple Timeline while also adding music.
    - Build and run the game to see how it works.

2) light and filter system:
    - Create Scriptable Objects for each filter.
    - Find a way for the inventory list to communicate with the light script so we can know if a    specific object, in this case the filters, is inside the inventory.
    - Create an if statement so the condition is: if the player presses key ? and filter ? is inside the inventory, activate this GameObject.
    - Build and run the game to see if it works.

3) Sanity system:
    - Create an effect for when the player is attacked that represents the player’s insanity.
    - Add storage buildings around the map and place a cube inside them with IsTrigger() activated so it detects the player inside and begins affecting their sanity.
    - Find a way to stop the monster from entering these buildings.
    - Add effects on the screen.
    - Add a counter to the UI on the screen.
    - Build and run the game to see if it works.

#### Question 2:

    Definitely, it was helpful. Just like in the class activity, having an idea of what you are going to work on before starting makes everything more organized. I like it because I can begin generating ideas on how to create new features for the game. It is an easy way to organize the development process and something you can always go back to whenever you need guidance. Writing these ideas down also makes creativity and development flow more easily.

    Next time, I would like to add more details and include a bigger variety of big steps to give myself more ideas about what sounds best to work on first and leave the simpler tasks for last.

#### Question 3:

Utilize Visual Scripting -> C# Script. For me, it was very complicated to find a way to implement this bridge between C# and Visual Scripting, therefore I only created a small visual graph dedicated to activating the Main Menu button and making it change to the next scene, the principal scene. I only used it to change from the Main Menu to the principal scene. For the other scenes, I did not use the same system because I did not want to mix everything together and create bigger problems. This system is located in my Main Menu Scene where the button inside the Canvas is the one I assigned the graph to. Instead of using the "OnButtonClick()" inside the object, I added it to the visual graph. Apart from that, I created a script inside the GameObject “Menu Manager” which contains the method "StartGame()". This method calls the scene change (principal scene).

The way these connect is that when the player clicks the button, it invokes the method indicated inside the Invoke node “StartGame()” which says to load the scene. There is also a node dedicated to assigning the GameObject that contains this script (MenuManager).

#### Question 4:

I would like you to grade my Unity Timeline system, which is located in the “Menu” Scene. The Timeline is assigned to the GameObject “TimeLine” and involves the images "cabeza 1” and “cabeza 2.”
You could also grade my Scriptable Object Unity system, which was created for my Inventory system. 

All my Scriptable Objects are inside the folder called “mushrooms.” The scripts “ItsIte,” “Inventory_Manager,” “Interaction,” and “Mushrooms” are involved with these Scriptable Objects and the inventory system.



## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets

- [Monster](https://assetstore.unity.com/packages/3d/characters/humanoids/humans/zombie-1-low-poly-232270)
- [Camping items](https://assetstore.unity.com/packages/3d/props/pandazole-survival-crafting-low-poly-pack-208575)
- [Trees](https://assetstore.unity.com/packages/3d/vegetation/trees/low-poly-trees-pack-lite-free-stylized-nature-environment-assets-295464)
- [Sky](https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014)
- [Terrain texture](https://assetstore.unity.com/packages/2d/textures-materials/nature/terrain-textures-free-271990)
