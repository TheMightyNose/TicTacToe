namespace TicTacToe
{
    public static class Result
    {
        public static bool WinCheck(Board board)
        {
            if (board.board[0] == board.side)
            {
                if (board.board[1] == board.side && board.board[2] == board.side)
                    return true;
                if (board.board[3] == board.side && board.board[6] == board.side)
                    return true;
            }
            if (board.board[8] == board.side)
            {
                if (board.board[7] == board.side && board.board[6] == board.side)
                    return true;
                if (board.board[5] == board.side && board.board[2] == board.side)
                    return true;
            }
            if (board.board[4] == board.side)
            {
                if (board.board[3] == board.side && board.board[5] == board.side)
                    return true;
                if (board.board[1] == board.side && board.board[7] == board.side)
                    return true;
                if (board.board[0] == board.side && board.board[8] == board.side)
                    return true;
                if (board.board[2] == board.side && board.board[6] == board.side)
                    return true;
            }

            return false;
        }

        public static bool DrawCheck()
        {
            for (int i = 0; i < 9; i++)
            {
                if (Game.board.board[i] == -1)
                    return false;
            }
            return true;
        }

    }
}