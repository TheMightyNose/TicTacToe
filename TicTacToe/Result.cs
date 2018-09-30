namespace TicTacToe
{
    public static class Result
    {
        public static bool WinCheck()
        {
            if (Game.board[0] == Game.side)
            {
                if (Game.board[1] == Game.side && Game.board[2] == Game.side)
                    return true;
                if (Game.board[3] == Game.side && Game.board[6] == Game.side)
                    return true;
            }
            if (Game.board[8] == Game.side)
            {
                if (Game.board[7] == Game.side && Game.board[6] == Game.side)
                    return true;
                if (Game.board[5] == Game.side && Game.board[2] == Game.side)
                    return true;
            }
            if (Game.board[4] == Game.side)
            {
                if (Game.board[3] == Game.side && Game.board[5] == Game.side)
                    return true;
                if (Game.board[1] == Game.side && Game.board[7] == Game.side)
                    return true;
                if (Game.board[0] == Game.side && Game.board[8] == Game.side)
                    return true;
                if (Game.board[2] == Game.side && Game.board[6] == Game.side)
                    return true;
            }

            return false;
        }

        public static bool DrawCheck()
        {
            for (int i = 0; i < 9; i++)
            {
                if (Game.board[i] == 0)
                    return false;
            }
            return true;
        }

    }
}