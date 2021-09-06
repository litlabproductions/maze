# MAZE
  
### 2D Mobile Game
#### Dash between a MAZE of obstacles in this hyperspace mobile adventure   
<br/>&nbsp;&nbsp;&nbsp;&nbsp;a [***Lit Lab Production***](https://www.litlabproductions.com)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;Built with [Unity3D](https://github.com/Unity-Technologies) and the 
[Universal Render Pipeline](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@7.1/manual/index.html)<br><br>
***

## Table of contents
- [MAZE](#maze)
  - [Play](#play)
  - [Objective](#objective)
    - [Collect Points](#collect-points)
    - [Avoid Objects](#avoid-objects)
  - [Development](#development)
    - [Randomized Environment](#randomized-environment)
    - [Movement and Collision](#movement-and-collision)
    - [Color Pallete](#color-pallete)
***

## Play

#### Try it Here:
  1. [***www.litlabproductions.com/maze***](https://www.litlabproductions.com/maze)
  2. [***simmer.io/@LitLabProd/maze***](https://simmer.io/@LitLabProd/maze)
***
<br><br>
![maze-logo-resize01](https://user-images.githubusercontent.com/34845402/131579777-3a850564-05b3-4245-9d3a-014d3511a616.png)
<br>
***
<br><br>

![maze-demo-03](https://user-images.githubusercontent.com/34845402/131578148-3146f1ae-e9bd-4678-bbfd-96c6b0c7e018.gif) <br><br><br><br>
 
 
## Objective 
<br>

### Collect Points
  * **Fire Orbs**
      * One point is gained for each fire orb collected <br><br>
![maze-demo-00](https://user-images.githubusercontent.com/34845402/131578141-7529755d-acff-4d80-81cf-71030172e6d7.gif)
<br><br><br>

  * **Traverse Space**
      * One point is gained for each distance traveled equal to vertical screen length <br><br>
![2](https://user-images.githubusercontent.com/34845402/132146018-43a59149-2371-4a82-89d5-a08b808f5dec.png)
<br><br><br>

### Avoid Objects 
  * Don't collide with objects **(other than fire orbs)** or its game over! <br><br>
![maze-demo-02](https://user-images.githubusercontent.com/34845402/131578147-423bd080-8245-43ef-bb80-8f6eb7a361f9.gif) <br>
<br><br><br><br>


## Development

### Randomized Environment <br><br>
   * For each screen space, two random obstacle prefabs are spawned just ahead of the top of the screen. Because of this, no two games will ever be identical <br><br>
![random-env](https://user-images.githubusercontent.com/34845402/132150061-a1c6b8e2-1960-420d-baf1-f6e57a5d6166.png)<br><br><br>


### Movement and Collision <br><br>
   * The players particle is first fine-tuned for proper feel <br><br>
![maze-proto01](https://user-images.githubusercontent.com/34845402/131583225-f4b54127-b7d3-4956-b6b0-6c276a81a5e4.gif) &nbsp;&nbsp;
![move](https://user-images.githubusercontent.com/34845402/132148820-e8f4f6de-0539-47b7-83ed-8ebe6bb580c9.png)<br><br><br>

   * A **BoxCollider2D** is then attached to the frame of the screen 
   * After a collision occurs, **Die()** is called on the player particle <br><br>
![maze-proto00](https://user-images.githubusercontent.com/34845402/131583224-6f6b0f01-a1c3-4786-bb94-fa530c0dbb51.gif)&nbsp;&nbsp;
![die](https://user-images.githubusercontent.com/34845402/132148818-f410accc-7d13-4c63-a68d-22ddf7889011.png)<br><br><br>
 
   * A **MeshCollider2D** is finally attached to each object <br><br>
![maze-proto02](https://user-images.githubusercontent.com/34845402/131583220-fd67148c-2a66-4b0f-a572-b934ec2ddb20.gif)&nbsp;
<br><br><br>


### Color Pallete 
![color-pal](https://user-images.githubusercontent.com/34845402/132147267-da4f1390-3395-4a06-8853-d21d50778539.png)
<br><br>
![maze-home](https://user-images.githubusercontent.com/34845402/132147388-fed30566-2d58-4330-8c2f-7613e9e4477e.png)
<br><br><br>
     
     
***

<br><br>
Thanks for reading!<br/><br/>
 
If you like what you see give this repo  
a star and share it with your friends.

Your support is greatly appreciated!<br/><br/>


[***David Guido***](https://www.litlabproductions.com/resume-view) :rocket:  
[***Lit Lab Productions***](https://www.litlabproductions.com)
<br/><br/>
