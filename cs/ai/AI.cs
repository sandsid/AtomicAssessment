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
            var playable = false;
            //while the move hasnt been found look, unless you cant play(board is full)
            //check for the oposite players piece
            for (int j = 0; j < 7; j++)
                for (int i = 0; i < 7; i++)
                    if (gameMessage.board[j][i] == 0)
                    {
                        directions = CheckSquare(j, i, gameMessage, directions);
                        foreach (int element in directions)
                        {

                            //check if there is a legal/playable move
                            if (element != 0)
                                playable = LegalMove(j, i, gameMessage, element);

                            //assign the row and col to move, return 
                            if (playable)
                            {
                                nextMove[0] = j;
                                nextMove[1] = i;
                            }
                        }
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
                directions[1] = 2;
            if (message.board[row - 1][col + 1] == 1)
                directions[2] = 3;
            if (message.board[row][col - 1] == 1)
                directions[3] = 4;
            if (message.board[row][col + 1] == 1)
                directions[4] = 5;
            if (message.board[row + 1][col - 1] == 1)
                directions[5] = 6;
            if (message.board[row + 1][col] == 1)
                directions[6] = 7;
            if (message.board[row + 1][col + 1] == 1)
                directions[7] = 8;

            return directions;
        }
        public static bool LegalMove(int row, int col, GameMessage message, int direction)
        {
            var c = col;
            var r = row;

            if (direction == 1)
            {
                //diagonal left up
                for (c = col; c > 0; c--)
                {
                    if (message.board[r - 1][c - 1] == 2)
                        return true;
                    r--;
                    if (r <= 0)
                        break; //(if break doesnt work make i = 0)
                }

            }
            else if (direction == 2)
            {
                //vertical up
                for (r = row; r > 0; r--)
                    if (message.board[r - 1][c] == 2)
                        return true;
            }
            else if (direction == 3)
            {
                // diagonal right up
                for (c = col; c < 7; c++)
                {
                    if (message.board[r - 1][c + 1] == 2)
                        return true;
                    r--;
                    if (r <= 0)
                        break;
                }
            }
            else if (direction == 4)
            {
                //horizontal left
                for (c = col; c > 0; c--)
                    if (message.board[r][c - 1] == 2)
                        return true;
            }
            else if (direction == 5)
            {
                //horozontal right
                for (c = col; c < 7; c++)
                    if (message.board[r][c + 1] == 2)
                        return true;
            }
            else if (direction == 6)
            {
                //diagonal left down
                for (c = col; c > 0; c--)
                { 
                    if (message.board[r + 1][c - 1] == 2)
                        return true;
                    r++;
                    if (r >= 7)
                        break;
                }
            }
            else if(direction == 7)
            {
                //vertical down
                for (r = row; r < 7; r++)
                    if (message.board[r + 1][c] == 2)
                        return true;
            }
            else if (direction == 8)
            {
                //diagonal right down
                for (c = col; c < 7; c++)
                {
                    if (message.board[r + 1][c + 1] == 2)
                        return true;
                    r++;
                    if (r >= 7)
                        break;
                }
            }


            return false;
        }
    }
}
