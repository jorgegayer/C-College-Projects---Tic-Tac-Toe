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
    class Player
    {
        // defines the color of the player
        public Color Argb { get; private set; }
        

        // Placeholder for the name of the player
        public string Name { get; set; }
        
        
        // Placeholder for future improvement where the user will be able to choose the symbol instead of only X and O
        public string Symbol { get; set; }
        
        
        //storage if the user is a winner. 
        public bool Winner { get; private set; }
        
        
        // each player has 3 columns, 3 lines an 2 diagonals.
        Block[] Column=new Block[3];
        Block[] Line = new Block[3];
        Block[] Diagonal = new Block[2];

        public Player(Color color)
        {
            // starts the player and define the color. 
            Argb = color;
            //starts the columns, lines and diagonals
            for (int i = 0; i < 3 ; i++)
            {
                Column[i] = new Block(3);
                Line[i] = new Block(3);
                if (i!=2)
                    Diagonal[i] = new Block(3);
            }
        }

        // player is defined as a winner
        private void SetWinner(bool winner)
        {
            if (winner)
                Winner = true;
        }


        public void Restart()
        {
            // restat user columns, lines and diagonals.

            Column[0].Restart();
            Column[1].Restart();
            Column[2].Restart();

            Line[0].Restart();
            Line[1].Restart();
            Line[2].Restart();

            Diagonal[0].Restart();
            Diagonal[1].Restart();
            Winner = false;
        }

        public bool Play(string id)
        {
            //id is sent, containing line, column and diagonal that was clicked
            string []localMark = id.Split(',');
            // 0 - Line
            // 1 - Column
            // 2 - Diagonal
            int line = int.Parse (localMark[0]);
            int column = int.Parse(localMark[1]);

            //Mark the column clicked by the user. Mark returs true if the user is a winner
            SetWinner( Column[column].Mark());
            //Mark the line clicked by the user. Mark returs true if the user is a winner
            SetWinner(Line[line].Mark());
            
            //localmark is 3 when a diagonal block was clicked
            if (localMark.Length == 3)
            {
                int diagonal= int.Parse(localMark[2]);
                if (diagonal==0 || diagonal==1)
                    SetWinner(Diagonal[diagonal].Mark());
                else
                {
                    SetWinner(Diagonal[0].Mark());
                    SetWinner(Diagonal[1].Mark());
                }
            }
            //returns if the movement done made the player a winner
            return Winner;
        }

    }
}
