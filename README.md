# Hello, Welcome to our Dodgeball game!

 We are learning PC-Game development, and our assignments is to make dodgeball game.

the game on itch website:
https://aviv-jessie.itch.io/assignment3



# difficulty level
* easy - not difficult.
* normal - the computer catches better.
![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/1.png?raw=true)
* hard - the computer throws better.
![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/2.png?raw=true)
* expert - the computer catches faster and got another ball.
![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/3.png?raw=true)

# physics
## CenterLine
![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/Screenshot_1.gif?raw=true)
![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/Screenshot_2.png?raw=true)

We added an object with an edge collider and every object was put on a different layer

The ball ignores the centerLine and the player not.

## Background
simply edge collider

## Players
![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/4.png?raw=true)

## ball
We use material to friction the ball and add Linear Drag in Rigidbody2D to make it stop on the floor.
![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/5.png?raw=true)

# code
## ModeSwitcher.cs
[ModeSwitcher.cs](https://github.com/Aviv-Jessie/Assignment3/blob/master/Assets/Scripts/ModeSwitcher.cs) 
the player have three modes ![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/6.png?raw=true)
defender, withBall and withoutBall.

the mhetods  SwitchToDefenderPlayer, SwitchToWithBallPlayer, SwitchToWithoutBallPlayer 

we will check the mode that we arrived from, and Switch if we can.

if we can't the class responds accordingly.

for example if we switched from WithoutBall to WithBall It means the player is disqualification 

becuase the ball hits the player and the player is not in defender mode.

## Spawner.cs
[Spawner.cs](https://github.com/Aviv-Jessie/Assignment3/blob/master/Assets/Scripts/Spawner.cs)
Creates the ball to the position we defined in unity when ModeSwitcher call to spawnObject() method.
![alt text](https://github.com/Aviv-Jessie/Assignment3/blob/master/7.png?raw=true)

## AutoCatch.cs
[AutoCatch.cs](https://github.com/Aviv-Jessie/Assignment3/blob/master/Assets/Scripts/AutoCatch.cs)
redPlayer switch to defender mode every "timerToDefender" seconds.

## AutoMover1.cs
[AutoMover1.cs](https://github.com/Aviv-Jessie/Assignment3/blob/master/Assets/Scripts/AutoMover1.cs)
redPlayer moves randomaly.

## AutoSpawner.cs
[AutoSpawner.cs](https://github.com/Aviv-Jessie/Assignment3/blob/master/Assets/Scripts/AutoSpawner.cs)
set velocityOfSpawnedObject to the blue players direction and tells the ModeSwitcher to Switch to the playerWithoutBall mode.

## KeyboardController.cs
[KeyboardController.cs](https://github.com/Aviv-Jessie/Assignment3/blob/master/Assets/Scripts/KeyboardController.cs)
use arrows to move blue player, "L" key to Switch to defender mode and "space" key to throw the ball.

## SceneChooser.cs
[SceneChooser.cs](https://github.com/Aviv-Jessie/Assignment3/blob/master/Assets/Scripts/SceneChooser.cs)
SceneChooser.cs only in the main menu 


## Credits
### Assignment solver
* Aviv
* Omri
* Jessica

### Assignment writer
Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
