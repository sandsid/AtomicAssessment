namespace ai
{
    public static class AI
    {
        //private static int[] possibleMoves;
        public static int[] NextMove(GameMessage gameMessage)
        {
            var nextMove = new[] { -1, -1 };
            var directions = new[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            var playerNum = gameMessage.player;
            //while the move hasnt been found look, unless you cant play(board is full)
            //check for the oposite players piece
            for (int j = 0; j < 7; j++)
                for (int i = 0; i < 7; i++)
                    if (gameMessage.board[j][i] == 0)
                        foreach(int element in directions)
                        {
                            //check if there is a legal move
                            LegalMove(j, i, gameMessage, element);
                            //assign the row and col to move, return 
                            nextMove[0] = j;
                            nextMove[1] = i;
                        }

            return nextMove;
        }


        //check the square surrounding the spot on the board
        //  return a list of the dirrections the leagal move needs to check 
        public static int [] CheckSquare(int row, int col, GameMessage message, int [] directions)
        {
            
            if (message.board[row - 1][col - 1] == 1)
                directions[0] = 1;
            if (message.board[row -1][col] == 1)
                directions[1] = 1;
            if (message.board[row - 1][col + 1] == 1)
                directions[2] = 1;
            if (message.board[row][col - 1] == 1)
                directions[3] = 1;
            if (message.board[row][col + 1] == 1)
                directions[4] = 1;
            if (message.board[row + 1][col - 1] == 1)
                directions[5] = 1;
            if (message.board[row + 1][col] == 1)
                directions[6] = 1;
            if (message.board[row + 1][col + 1] == 1)
                directions[7] = 1;

            return directions;
        }
        public static bool LegalMove(int row, int col, GameMessage message, int direction)
        {
            var c = 0;
            var r = 0;

            

            return false;
        }
    }
}
