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

// Here it the concept of Blocks. Each block of the tic tac toe can have multiple cells. 
// the game was created with 3 cells, but it can be expanded in the future. 
namespace TicTacToe
{
    class Block
    {

        private int _max = 0;
        public Block(int max)
        {
            // Starts the block with the count = 0 and max receives the paremeter passed by the user. 
            Count = 0;
            _max = max;
        }
        private int Count { get; set; }

        public bool Mark()
        {
            // blocked was marked.
            // when block is equals max, it means the block is full
            Count++;
            if (Count==_max)
            {
                return true;
            }else
            {
                return false;
            }
        }

        // restarts the block
        public void Restart()
        {
            Count = 0;
        }
    }
}
