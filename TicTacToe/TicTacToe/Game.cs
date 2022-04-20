//Name: Assignment 1
//Program: Software Development Diploma
//Course Code: SODV2101 - Rapid Application Development
//Author: Jorge Eduardo Schmitt Gayer
//Student IDs: 424267

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TicTacToe
{
    class Game
    {
        // the game has 2 players
        public Player player1;
        public Player player2;

        //this variable controls who is the turn to play. 
        // true = Player 1
        //false = Player 2
        private bool _turn = true;

        //this controls how many movements were done by any player
        private int Count;

        public Game (string name1, string name2)
        {
            // game starts with 2 players. 
            // for now 1 red and 1 blue with fixed names.
            // But that can be changed in the future
            player1 = new Player(Color.Red);
            player1.Name = name1;
            
            player2 = new Player(Color.Blue);
            player1.Name = name2;
            //start with the turn for the player 1
            _turn = true;
        }

        public Player currentPlayer() 
        {
            //return the player who is the current player
            bool localTurn = _turn;
            if (localTurn) 
                return player1; 
            else 
                return player2;
        }

        private void next() {
            //set the turn to the next player
            _turn = !_turn;
        }

        public bool Play(string id)
        {
            //start myplay with false
            bool myPlay = false;
            
            //myPlay turns to true if the movement result in a win
            myPlay =  currentPlayer().Play(id);
            
            //turn to the next player
            next();

            //increases one movement to the board
            Count++;

            return myPlay;

        }

        public void Restart()
        {
            //restart the game
            player1.Restart();
            player2.Restart();
            _turn = true;
            Count = 0;
        }

        public bool checkDraw()
        {
            //if the board has 9 movements and no winner, it means it was a draw.
            if (Count==9)
            {
                return true;
            }
            return false;
        }

    }
}
