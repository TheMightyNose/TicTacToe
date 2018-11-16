using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Bot
	{
		Board board = new Board();
		MoveList moveList = new MoveList();

		public int Play()
		{
			if (Result.DrawCheck())
			{
				return -1;
			}

			for (int i = 0; i < 9; i++)
			{
				board.board[i] = Game.board.board[i];
			}

			Movegen.GenerateMoves(board, moveList);

			for (int i = 0; i < moveList.Moves.Count; i++)
			{
				if (board.board[moveList.Moves[i].square] == -1)
				{
					board.board[moveList.Moves[i].square] = board.side;
					if (Result.WinCheck(board))
						moveList.Moves[i].score = 1;
					board.board[moveList.Moves[i].square] = 0;
				}
			}

			int bestMove = -1;
			int bestScore = -1;
			
			for (int i = 0; i < moveList.Moves.Count; i++)
			{
				if (moveList.Moves[i].score > bestScore)
				{
					bestScore = moveList.Moves[i].score;
					bestMove = moveList.Moves[i].square;
				}
			}

			return bestMove;
		}
	}
}
