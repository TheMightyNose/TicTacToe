using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Movegen
	{
		public static void GenerateMoves(Board board, MoveList moveList)
		{
			for (int i = 0; i < 9; i++)
			{
				if(board.board[i] != -1)
				{
					moveList.Moves.Add(new Move(i, 0));
				}
			}
		}
	}
}
