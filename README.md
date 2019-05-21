# Rocket_Ride_Unity3D

![GitHub license](https://img.shields.io/github/license/oussamabonnor1/SimpleCalculator-WPF.svg)
![Jetlight studio](https://img.shields.io/badge/Made%20by-Jetlight%20studio-blue.svg?color=082544)

A doodle jump like game, made from scratch using unity3D. Feel free to use it however you want, a little mention would help a lot! 


## Screenshots and GIFs:
<img src="Assets/rocket ride GIF.gif" width="250"/>

## Project logic:
The use of vertices specified from the cursor's coordinates clicks to dynamically generate and configure a mesh, rigidbody2D, color, and 2D collider.

## Project Overview
Requires Unity3D (tested with 2018.x, but should also work with 2017.x & 5.x)

```
.
├── Prefabs
|   └── rechagePad.prefab        - The predefined game object of the recharge pad.
|   └── superRechagePad.prefab   - The predefined game object of the recharge pad that gives extra boost.
|   └── ship.prefab              - The predefined game object of the playable ship.
├── Scenes
|   └── Main.unity               - The project's main scene.
├── Sprites                      - Simply contains graphical game assets. 
└── Scripts                      - Contains logic code of the game 
    ├── GameManager.cs           - The main code of creation and interaction.
    ├── PadBehaviour.cs          - Handles the pad's boost and collisions.
    ├── PlayerBehaviour.cs       - Handles the horizental moves of ship.
    └── CameraBehaviour.cs       - Movement of the camera and score count is covered here.
```

## Running the Project
To run the project, open _Scenes/Main.unity and click on the play button.

## Game logic
Use the left and right arrows to move the rocket, land on the platforms and indrease your score! 

## Tools used:
* Visual studio (IDE)
* C# (logic)
* Unity (game engine)
* Paint.Net (Image editting)

## Contribution:
Feel free to `fork` this project and add whatever you like. If you have any suggestions or any comments please feel free to contact me or to open an issue, use free license art assets please.

## Team:
[Jetlighters](https://github.com/JetLightStudio) having fun.
