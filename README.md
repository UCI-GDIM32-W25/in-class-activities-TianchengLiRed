# GDIM32 In Class Activities
## W1
### Activity 1

Our table decided that 1 advice to help you get A in class is to share your link to your classamtes  after you put your assignment on itch, let them playtest your game to help you find out some bugs or problems, also you can put your link on Discord to let your classmates plytest your game and give you some advices to improve your assignment.

### Activity 2

1. 10
2. 2
3. print “hello world” out on the console every frame.
4. MonoBehaviour.
5. print “x = 10” on the console when game start load.
6. their name is argument and parameter; use to provide inputs to this method.
7. Transform is a type, it could only be called by object, translate can not call on the Transform, its invalid.
8. change Transform to _playerTransform. call translate on the _playTransform.

### Activity 3

[MG1 break down google doc](https://docs.google.com/document/d/1oBYRXKqXWRqwzQK4CjbbG5s3cmnBHL8BmCKDdkGts8w/edit?usp=sharing)

## W2
### Activity 1

![91bc1469eec660dd299aab2736b486ef](https://github.com/user-attachments/assets/3018efd8-6481-4b21-bb30-525ad9d5dc75)

### Activity 2

[MiniGame2 Update](https://github.com/UCI-GDIM32-W25/mg2-TianchengLiRed/commit/60e17663f735c02002a4ca2854e731ce259bb8ad)

brief description : I created some Objects, implement jump function of the player. Created Coin as Prefab, implement coin's action fo move to left constantly. Implement the function to generate coins randomly.

## W3
### Activity 0-2

Allen Hu

### Activity 3

![c9bb8422c28352df87027cb66de27029](https://github.com/user-attachments/assets/54363b10-cc52-4e4f-a1a4-1ce1d62b9ccc)


## W4
### Activity 0


Allen Hu

### Activity 1 

Even though multiple locator GameObject still remain in the Scene but there is only one Locator GameObject that include Locator script as component.
Because the script in the awake prevent there being more than one instance of the locator class by destory other instances.

### Activity 2

![03031585821334bd5347e0a20ccc6147](https://github.com/user-attachments/assets/98e319e4-775d-4564-b67e-85f3626c8d83)

### Activity 3
[MiniGame4 Update](https://github.com/TianchengLiRed/HW4/commit/ba8b9720641cc4cc1acc5b8b4d430546dad8ab2d)

brief description : I created bird, tube and UI Objects, Implement the jump function and collide function of the player, the player now collide on the tube will end the game and collide with empty space between tube will gain point now. the game are able to gameover now. Implement the function to active gameover UI, gameoover image and restart button, press the button will debug "gameover".

## W4
### Activity 1

I think interface and abstract classes is pretty efficient to cerate different Items. I use to think inheritance would be easier because they can share the same information to their children class. But when you creating some items, I would keep it the same, keep use abstract and interface class. Abstract class of Item to create base category and attribute of Item, interface use to create some special and specific inclusive attribute of certain category of items. It would be helpful and more efficient.

### Activity 2

Model classes: Enemystates,ItemW5Demo2;
Controller classes: PlayerW5Demo2, Enemy5Demo2;
View classes: InventoryUI, DialogueBubble;

### Activity 3

Scenario 1:
Beat was made based on inheritance with polymorphism, making prefab for different beat that shared the same hit logic. Singleton will controll start system that play music and show beat objects at when start. Use scriptableObject to store information of each beat, to determine whether they hit it perfectly. 
Scenario 2: 
Inheritance use to create different character that shared some of the same logic and information
ScriptableObject to store different information of characters or guns,etc.
Controller:
gameplay code- causing damage, creating shield
View:
UI that shows your kill record and remaining blood, and some effects of being hit by a gunshot.
score of the player,scoreboard.
Scenario 3:
finite machine will used for the state of the plant, to determine the change of plants status based on their growth condition. Also, inheritance and scriptableObject use to create different plants that is the same category and shared the same information, and with different growth condition.

### Activity 4

Tiancheng Li, AllenHu, Yaokun Wan.

### Activity 5

[GDIM 32 Final Project Proposal Draft](https://docs.google.com/document/d/1fnsY2dn8RalB8GGQmQtA4OftlRL5nsa3st6-GqeGGi8/edit?usp=sharing)
