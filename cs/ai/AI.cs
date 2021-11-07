namespace ai
{
    public static class AI
    {
        //private static int[] possibleMoves;
        public static int[] NextMove(GameMessage gameMessage)
        {
            var nextMove = new[] { 2, 3 };




            return nextMove;
        }

        public static int[] CheckMoves(int [] pMove, GameMessage gameMessage)
            {

            var move  = new[] { 0, 0 };
            var playerNum = gameMessage.player;
            //while the move hasnt been found look, unless you cant play(board is full)
            //check for the oposite players piece
            for (int j = 0; j < 7; j ++)
                for(int i = 0; i < 7; i++)
                    if(gameMessage.board[j][i] == 0)
                        if (CheckSquare(j, i, gameMessage, 2) == true)
                        { 
                            //check if there is a legal move

                                //assign the row and col to move, return 
                                move[0] = j;
                                move[1] = i;   
                        }

            return move;

        }


        public static bool CheckSquare(int row, int col, GameMessage message, int playerNum)
        {
            if (message.board[row - 1][col - 1] == 1 ||
                message.board[row][col - 1] == 1 ||
                message.board[row + 1][col - 1] == 1 ||
                message.board[row - 1][col] == 1 ||
                message.board[row + 1][col] == 1 ||
                message.board[row -1][col +1] == 1 ||
                message.board[row][col + 1] == 1 ||
                message.board[row + 1][col + 1] == 1)
                return true;
            else 
                return false;
        }
        public static bool LegalMove(int row, int col, GameMessage message, int playerNum)
        {
            var i = 0;
            var j = 0;

            //check horozontal right
            for (i = col; i < 7; i++)
                if (message.board[row][i + 1] == 2)
                    return true;


            return false;
        }
    }
}
