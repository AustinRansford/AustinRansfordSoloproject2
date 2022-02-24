# AustinRansfordSoloproject2
# OVERVIEW
the purpose of the Game is to create a text adventure where a player passes a soccer ball up the feild to create a "counter attack". If the player choses the correct passes or is lucky(view method probality machine) they can score a goal and the counter would be sucessful. The user will chose between 4 inputs in 5 different rooms. Around 2 inputs will result in ending the game and 2 in moving to next room or winning game. The Program is resopnsible to print the options and the information surrounding the choices. The program also needs to show if the pass/dribbling attempt was sucessful. 

# METHODS

## difficulty reader 
the user chooses a difficulty Easy Medium or hard. this changes the amount of turn they are allowed. input is string output is null
! ["Flowchart difficulty reader"](flow-charts/IMG-0970.jpg)
## Room 1
will provide 3 or four options where the player can pass ball
! ["Flowchart"](flow-charts/IMG-0974.jpg)
## Room 2
provide 3-4 options for the player to move to next stage
! ["Flowchart"](flow-charts/IMG-0974.jpg)
## Room 3 
provide 3-4 options for the player to move to next stage
! ["Flowchart"](flow-charts/IMG-0974.jpg)
## Room 4 
provide 3-4 options for the player to move to next stage
! ["Flowchart"](flow-charts/IMG-0974.jpg)
## Room 5
provide 3-4 options for the player to move to next stage
! ["Flowchart"](flow-charts/IMG-0974.jpg)
##  (probality machine)
The player will encounter interactions where a choice has a set probality to pass to the next stage. the method will take in the percentage of success {int value} then generate a number between 1-100. If the generated number is greater than the precentage of sucess than the action fails and less than the precentage the method will return false.
! ["Flowchart"](flow-charts/IMG-0913.jpg))