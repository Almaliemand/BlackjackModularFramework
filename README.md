# BlackjackModularFramework

        Q - What is this?
       
A - This is a modular code framework based on the popular card game: Blackjack. It is designed to be easy to add to any unity project and add custom artwork. 


        Q - How does drawing the cards work?
      
A - Players will press the hit button:![Hit Button](https://user-images.githubusercontent.com/80597521/113414966-7cb15d80-93be-11eb-9a80-c5dada19bd54.png)

This will call the attached script to perform the onBtnPress function:![Screenshot 2021-04-02 142436](https://user-images.githubusercontent.com/80597521/113415281-2b559e00-93bf-11eb-8b96-6d3b4c22aacf.png)

In the onBtnPress function, a random number between one and eleven is generated, which is then added to a player score and the score text is updated accordingly. Following that, the script will then check what number was randomly chosen and instantiate the corresponding card: ![Screenshot 2021-04-02 143924](https://user-images.githubusercontent.com/80597521/113416274-41fcf480-93c1-11eb-8fa0-ac1fc31df861.png)

If the randomly generated number is equal to 10, however, the script will reference a list of game objects: ![Screenshot 2021-04-02 144147](https://user-images.githubusercontent.com/80597521/113416421-96a06f80-93c1-11eb-9056-2ea164e59493.png), and will randomly instantiate either a ten card, jack, queen or king card, as in the original Blackjack all these cards are valued at 10 points. 

Lastly, the script will check everytime the button is pressed if the player's score is greater than 21, as in Blackjack if the total card value exceeds 21, they lose: ![Screenshot 2021-04-02 144714](https://user-images.githubusercontent.com/80597521/113416814-5988ad00-93c2-11eb-991a-0b9f3d92d5ea.png). If the player's score exceeds 21, then the UI element designed for that lose condition is activated, and all the buttons are deactivated so as to prevent players from continuing the game. 


      Q - How does the dealer AI work?
      
A - The entire functionality of the dealer gets initiated when the player presses the stand button. When the player presses the stand button, the dealer will pick a random number between 1 and 21 and will then add that random number to the dealer score. The game will then check a few conditions, if the dealer score is less than 11, the dealer will pick another random number between 1 and 11 and add that number to the score. The same thing happens if the dealer's score is between 12 and 21. After that, the dealer will "stand", causing a UI element to appear asking the player to reveal their cards. When the reveal button is pressed, the dealer score text is updated to show the dealer's score:
![Screenshot 2021-04-02 151446](https://user-images.githubusercontent.com/80597521/113418660-34963900-93c6-11eb-8203-6de912917581.png) 


      Q - How are the win conditions checked?
      
A - When the player presses the reveal button, the game will check both the player and dealer score. If the dealer score is greater than the player score, then the corresponding UI is activated. The same goes for the other win conditions: if the player has a greater score than the dealer, if the dealer goes over 21 or if the player and dealer draw and get an equal value. 


      Q - How does the betting system work?
      
A - The player starts out with 1000 chips to bet. Based on their hand, players can add to their bet on whether or not they'll win. There are different betting buttons that will take a certain amount of chips from their reserve and add it to the betting pot, so for example players can add either 5 chips or 200 chips depending on how lucky they feel. When the player stands, the dealer will add chips to the betting pot based on his score. If the score is less than 10, the dealer will add 50 chips before adding more points to their score. If the score is between 12 and 21, they will add 20 chips to the betting pot. When the reveal button is pressed by the player, the final betting pot value is shown and however wins, gets the pot. 


    



 

 
