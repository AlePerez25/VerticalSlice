# GDIM33 Vertical Slice
## Milestone 1 Devlog
Alejandra Perez

1) The Visual scripting graph that I am going to talk about is the one found inside player saved as “Player”, specifically the group “player movement”. This graph is responsible for making the player move at the moment the player presses any of the WASD keys on the keyboard, it will receive the message that the player needs to move. In the graph we have the “On input event vector 2” which connects to the Player input called “PlayerControl” inside the gameobject. Assigned with “On hold” and “Move”, this is connected to the vector 2 linked with the respective X and Y axis which are multiplied by speed (10), this result is multiplied once again with delta time, this is the result that is given to the vector on the x axis and z = y. All in charge of reacting immediately to the keyboard input. Thanks to this we can enjoy a clean and concise movement in the game.

2) The state machine that I made is divided into two different states “caminando” which is walking and “atacar” which is chasing connected by two transitions. This is located in the gameobject of the monster “Zombie”. The state machine itself is called “NPC”. The first part “camiando” is made up of nodes such as update, random range, navmeshagent set destination, cooldown, vectors and navmesh. All these nodes are responsible for generating a random location around the map 20 units away from its current position every 2–4 seconds, this loads the “walk” animation. This connects to the state called “chasing” which has nodes such as update, find object with tag, get position and set destination navmesh agent. This is responsible for detecting the player when they are circulating near the monster in order to proceed to chase them by changing its current position to the player’s position, this also loads the “Attack” animation. Both are connected by two transitions, the first is from walking → chasing which indicates that if the distance to the player is less than 15 the transition can occur and it switches to attacking, while the transition chasing → walking indicates that the transition can occur only if the distance is greater than 18 and it switches from attacking to walking. Basically, the entire functioning system of my monster is inside that state machine.

    This will be connected in the future to the player quest system since it will be the biggest impediment/challenge for the player. Thanks to this movement and detection, the player will be able to run into the terraind and somethimes find the monster and chases will have to occur. It is also connected to the player health reduction system that I made in a C# script, when the monster gets very close to the player and collides with them the player loses health and is forced to look for safety kits to recover a percentage of health. For the break down I only added one more box where I briefly explain how it works and what things it activates, this is connected to the navmesh and animations boxes.

   Game break-down:
   <img width="1498" height="1128" alt="Screenshot 2026-04-28 113659" src="https://github.com/user-attachments/assets/5950310a-f0e3-4571-99b5-aadcc46f7849" />


## Milestone 2 Devlog

Alejandra Perez

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

<img width="545" height="415" alt="Screenshot 2026-05-14 233624" src="https://github.com/user-attachments/assets/5c2c6f6c-f3df-4721-bb27-0fd89711f9e7" />


#### Question 4:

I would like you to grade my Unity Timeline system, which is located in the “Menu” Scene. The Timeline is assigned to the GameObject “TimeLine” and involves the images "cabeza 1” and “cabeza 2.”

You could also grade my Scriptable Object Unity system, which was created for my Inventory system. 
All my Scriptable Objects are inside the folder called “mushrooms.” The scripts “ItsIte,” “Inventory_Manager,” “Interaction,” and “Mushrooms” are involved with these Scriptable Objects and the inventory system.



## Milestone 3 Devlog
Alejandra Perez

#### Question 1

I created a total of two ShaderGraphs, but the one I like most is the shader used for the colored lamp filters. This ShaderGraph is called “Filters.” For this shader, I based my work on one of the activities we completed in class where the goal was to create a transparent shiba with a little color applied to it. I wanted the filters to look like glowing colored glass, this effect is more noticeable on the red and blue filters.

To create this effect, I used nodes like Sample Texture 2D, Base Color, Split, Base Texture, and Multiply. These nodes work together to create the transparent material effect. I changed the Surface Type to Transparent and connected the Split node (A1) into the Alpha square, which for what I understand allows the shader to control transparency. Based on my understanding, this is one of the main reasons the transparency effect works correctly.

To create the glowing part, I used a Fresnel Effect node combined with a color variable set to HDR mode. This creates a bright outline-like glow around the object, making the filters appear illuminated. Altogether, these nodes create a glowing crystal/glass effect for the filters.

The second ShaderGraph is called “Outline.” This shader was also based on a class activity and was created to help players understand which objects in the environment can be collected. Since not everything in the terrain is interactive, the outline gives players clearer gameplay feedback. This version is more simplified than the original class example because it only creates the outline effect.

Unlike the “Filters” graph shader, this graph shader manipulates vertex data rather than changing color and transparency. I used a Float variable to control the outline thickness, which is currently set to 0.1. This value is multiplied with the object’s Normal Vector so the outline follows the original shape of the object correctly. The result is then added to the Position node so the outline appears properly on the object. The final output is connected into the Vertex input. I also connected a Base Color into the Fragment Base Color.

Both shaders can be found in the Assets folder inside a folder named “ShaderG.” The shaders are named “Filters” and “Outline.”



#### Question 2

According to the feedback from the previous milestone, I was told that it was a good game but that it was difficult to understand. Because of this, I dedicated time to attending office hours with an LA who gave me the idea that instead of implementing the game’s idea only in the game description, I should also teach it inside the game itself by implementing messages that appear when the player gets close to the filters, which are the objects the player has to collect. I only placed this message on all the filters and not on the mushrooms because by that point the player should already know that those can be collected.

I also added a message that appears only 5 seconds after the player collects the filter, indicating which key activates the color filter. I was also told in Milestone 2 and class playtesting that the filters were difficult to find compared to the yellow one because the others did not glow. Because of this, I decided to use a ShaderGraph that creates a transparency effect while also glowing at the same time. This way the player can find them more easily, while also making the filters feel more like real glass filters. 

I also received feedback that the monster did not die, and I would like to mention that in my game, as I described in my vertical slides, the purpose of attacking the zombie is not for it to die, but for it to move away. The zombies do not die; they only move away as if they were scared. I was recommended to change the weapon into something like a taser to make it clearer that the zombies are not dying, but I could not find any asset for that. I will continue working on finding one so the idea is not confusing.

Besides that, I fixed my UI problem that was cutting off the part that indicated “Press E to see extrusions.” One clarification is that the player only needs to collect the 3 mushrooms around the terrain to win, since that is the purpose of the mushrooms. I understand and recognize that it can still be confusing, and I hope the things I added are helpful. If it is still confusing, I will continue working on clarifying things better for the next submission.

#### Quetion 3

Outside of the feedback improvements, I also dedicated time to expanding the map because I want the player to experience a larger and more complete forest environment. I also decided to add more monsters instead of having only one or two. I added a total of six monsters because I want to make sure the player will eventually encounter at least one during gameplay and experience the mechanic of defending themselves.

I also have another sound because, in my opinion, a horror game does not feel complete without screams or jumpscares. Now all of the monsters have a specific sound effect that can be heard with greater or lower intensity depending on how close the player is to them. This makes the game feel more realistic.

In addition, I changed the size of the trees because previously the player could see inside them when walking too close, which felt distracting and uncomfortable. I also added small sticks on the terrain floor to improve the feeling of being inside a forest.

All of these additions were made to create a more advanced and complete gameplay loop compared to the previous milestones.


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
