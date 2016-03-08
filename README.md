# HangMan
Simple Hangman Game Based On The People Around Me
    
    I created a simple class called Hangman with properties Name and Hint.
    And In the main program I created instances for any new possible Guess.
    
    I then put all name properties in one Array
    
    and hint properties in another Array
    
    
    Then a random number generator to generate numbers between 0 and array.Length - 1(to compensate for the [0] in arrays)
    
    so the name array [randomly generated number] is the word you have to guess.
    and the hint array [randomly generated number] is displayed to guide you.
    
    I created a char variable to chop the words up and replace each character with the asterisk character *
    For Every correct guess the asterisk is replaced with the right letter until the full word is  typed.
    
    
      I might add a score sheet later. It's pretty simple though.. one way of doing it 
      is to create a private static int length =1; under class Program but outside the static void main.
      then enclose the part of the code right after the object instances in a for loop like this
      
      for(int i=0; i<length; i++;)
      
      you can create a helper method called try again to ask if you want to replay, If you choose yes, the length+=1;
      
      then have a variable to store the score for each round so right after the you won message, your score is displayed,
      and the helper method should be placed under the you won message. I hope this helps. This is the basic structure, 
      I'll post the full game later, maybee after a month. Just want to know what people have done with my basic code source
      
      
