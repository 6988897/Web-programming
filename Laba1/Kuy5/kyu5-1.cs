using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    internal class kyu5_1
    {
        public static int IsSolved(int[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
                    return board[i, 0];
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != 0)
                    return board[0, i];
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
                return board[0, 0];
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
                return board[0, 2];

            foreach (int cell in board)
            {
                if (cell == 0)
                    return -1;
            }

            return 0;
        }
    }
}
