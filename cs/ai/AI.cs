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
            for (int r = 0; r < 7; r++)
                for (int c = 0; c < 7; c++)
                    if (gameMessage.board[r][c] == 0)
                    {

                        directions = CheckSquare(r, c, gameMessage, directions);
                        for (int x =0; x<8; x++)
                        {
                            //check if there is a legal/playable move
                            if (directions[x] != 0)
                                playable = LegalMove(r, c, gameMessage, directions[x]);

                            //assign the row and col to move, return 
                            if (playable)
                            {
                                nextMove[0] = r;
                                nextMove[1] = c;
                            }
                        }
                    }

            return nextMove;
        }


        //check the square surrounding the spot on the board
        //  return a list of the dirrections the legal move needs to check 
        public static int [] CheckSquare(int row, int col, GameMessage message, int [] directions)
        {
            //clear directions
            for (int i = 0; i < 8; i++)
                directions[i] = 0;
            
            //corners
            if (row == 0 && col == 0)
            {
                if (message.board[row][col + 1] == 1)
                    directions[4] = 5;
                if (message.board[row + 1][col] == 1)
                    directions[6] = 7;
                if (message.board[row + 1][col + 1] == 1)
                    directions[7] = 8;
                return directions;
            }
            if (row == 0 && col == 7)
            {
                if (message.board[row][col - 1] == 1)
                    directions[3] = 4;
                if (message.board[row + 1][col - 1] == 1)
                    directions[5] = 6;
                if (message.board[row + 1][col] == 1)
                    directions[6] = 7;
                return directions;
            }
            if (row == 7 && col == 0)
            {
                if (message.board[row - 1][col] == 1)
                    directions[1] = 2;
                if (message.board[row - 1][col + 1] == 1)
                    directions[2] = 3;
                if (message.board[row][col + 1] == 1)
                    directions[4] = 5;
                return directions;
            }
            if (row == 7 && col == 7)
            {
                if (message.board[row - 1][col - 1] == 1)
                    directions[0] = 1;
                if (message.board[row - 1][col] == 1)
                    directions[1] = 2;
                if (message.board[row][col - 1] == 1)
                    directions[3] = 4;
                return directions;
            }

            //boarder cells
            if(row == 0)
            {
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
            if(col == 0)
            {
                if (message.board[row - 1][col] == 1)
                    directions[1] = 2;
                if (message.board[row - 1][col + 1] == 1)
                    directions[2] = 3;
                if (message.board[row][col + 1] == 1)
                    directions[4] = 5;
                if (message.board[row + 1][col] == 1)
                    directions[6] = 7;
                if (message.board[row + 1][col + 1] == 1)
                    directions[7] = 8;
                return directions;
            }
            if(row == 7)
            {
                if (message.board[row - 1][col - 1] == 1)
                    directions[0] = 1;
                if (message.board[row - 1][col] == 1)
                    directions[1] = 2;
                if (message.board[row - 1][col + 1] == 1)
                    directions[2] = 3;
                if (message.board[row][col - 1] == 1)
                    directions[3] = 4;
                if (message.board[row][col + 1] == 1)
                    directions[4] = 5;
                return directions;
            }
            if (col == 7)
            {
                if (message.board[row - 1][col - 1] == 1)
                    directions[0] = 1;
                if (message.board[row - 1][col] == 1)
                    directions[1] = 2;
                if (message.board[row][col - 1] == 1)
                    directions[3] = 4;
                if (message.board[row + 1][col - 1] == 1)
                    directions[5] = 6;
                if (message.board[row + 1][col] == 1)
                    directions[6] = 7;
                return directions;
            }

            //non-boarder cells
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
