using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	public class Move
	{
		public Move(int square, int score)
		{
			this.square = square;
			this.score = score;
		}
		public int square;
		public int score;
	}
}
