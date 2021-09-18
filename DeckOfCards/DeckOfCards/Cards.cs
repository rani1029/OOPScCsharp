using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Cards
    {


        //Variable 4 Players,  9 cards Each 
        int PLAYER_CARDS = 9;

        //Arrays
        public string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        public string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        string[] players = { "1", "2", "3", "4" };


        public void CardsCreator()
        {
            //Variable
            int index = 0;

            //Array of Cards
            string[,] Cards = new string[suits.Length, rank.Length];
            string[] newCards = new string[52];
            string[,] playersCards = new string[players.Length, PLAYER_CARDS];

            //Concate
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < rank.Length; j++)
                {
                    Cards[i, j] = String.Concat(suits[i] + "-" + rank[j]);
                    newCards[index] = Cards[i, j];
                    index++;
                }
            }

            //Random Index generator
            Random random = new Random();
            int randomCard;

            //Suffle Cards
            for (int i = 0; i < newCards.Length; i++)
            {
                randomCard = random.Next(0, newCards.Length);
                string temp = newCards[i]; // 1=1 --- 1
                newCards[i] = newCards[randomCard];// 1 = 4-----1 
                newCards[randomCard] = temp;// 4 = 1-----4
            }
            //Distributaion of cards
            int counter = 0;
            for (int i = 0; i < players.Length; i++)
            {
                for (int j = 0; j < PLAYER_CARDS; j++)
                {
                    playersCards[i, j] = newCards[counter];
                    counter++;
                }
            }
            //Display Method 
            Display(playersCards);
        }
        //Display Cards Of each Players
        public void Display(string[,] playersCards)
        {
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Player {0} cards:", i + 1);
                Console.WriteLine("-----------------------");
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine(playersCards[i, j]);
                }
            }
        }



    }
}

