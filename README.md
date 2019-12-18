# GameEngAssignment
**GE-1 Assignment 1**

*My project:*

The aim of my project was to create a dungeon crawler like the binding of isacc or the more simularly like the Stardew valley minigame journey of the prairie king(https://bit.ly/2pwZEaz) Where you face a wave of enemies coming at you to try and kill you in each room, until you get a certain ammount of points from shooting/surviving them to move on to the next room. Or possible time limit coutdown till doors open. If the enemy touches you, you will die instantly, therefore will try and implement a 3 lives system, including diffrent enemy types. If keep winning and move room from room will eventually hopefully lead you to the boss room and fight it. Using a top down camera view to emulate a 2D system like in the game (or in a grid format), while using what we have learned in the labs and in the unity tutorials.

*What the game will hopefully include:* 

- [x] Life system
- [x] Points/score system
- [ ] Random map/room/dungeon layout
- [x] Using the lab tutorials as a base example
- [ ] Randomly generated terrain/walls to obsucre the enemy swarm and your shooting in each room
- [ ] Enemies drop random power ups to change  your shooting mechanics or other mechanics
- [ ] Diffrent enemy types I.e stronger armour needing more shoots to kill, faster or more
- [x] Top down camera view to emulate a 2D feel (2.5D)
- [x] Possible pure 2D or 3D  styles
- [ ] Possible other features


*Resources:*

- Stardew valley minigame- journey of the prairie king [Youtube video] (https://www.youtube.com/watch?v=0AjchLheDxw)
- The labs tank [Github Labs] (https://github.com/skooter500/GE1-2019-2020)
- Unity random map generator tutorial[Youtube Video] 
  - (https://www.youtube.com/watch?v=qAf9axsyijY) 
  - (https://www.youtube.com/watch?v=eR74EjkA_4s) 
  - (https://www.youtube.com/watch?v=CUdKdHmT8xA)
  - (https://www.youtube.com/watch?v=hk6cUanSfXQ)
- Unity tutorial of simular style game[Youtube Video] 
  (https://www.youtube.com/watch?v=SviIeTt2_Lc&list=PLFt_AvWsXl0ctd4dgE1F8g3uec4zKNRV0)
 - Unity tutorials [Unity tutorials] (https://learn.unity.com/tutorial/movement-basics?projectId=5c514956edbc2a002069467c#5c7f8528edbc2a002053b70f)
                           
**Project Progression and Description**

As stated from my original proposual this project was aimed to develop a semi dugeon crawler/bullet hell where the user progresses through rooms/levels killing waves of monsters comming to attack you. In developing this projected I used the various resources as previously mentioned while also trying to implement the sources my lecturer provided me. A primariay resource used were the the youtube tutorials on the simular style of game as to point me in the right direction, and as to try not to simply copy and paste from those tutorials I used what we learn't in class as a point of refrences to try and make this game my own version.

From the tutorials learning and implementing object collisions using nav mesh and implementing none walkable areas and terain. While also implementing a score system. Where as using the current knowledge from the labs to develop the user movement and shooting mechanics, as well as enemy spawning and their abilities to chase move and chase the player.


**Difficulties that occured**

A primary issue in developing this project was the object collision itself and dealing with alot of moving bodies within this code. Certain errors that occurs:
- The bullets have no effect on the enemy.
- The enemies Rigid body do not collid with other enemies or with enviomental barriers
- The enemey simply passes into the user without activating a fail state/restart
- Only allow collision movment on the quad area and stop the player from moving out of bounds.

Other known issues that occur over developing this project:

- Reaching a certain level does not allow the user to transistion to the next room or screen. Though was able to activate the door unlock system to notify the user which door is active to use.
- Aligning the score text neatly onto the screen overlay.
- Ajustment to the top down camera changed various objects positions on the map.
- Could not pause or end the spawning.
- 
