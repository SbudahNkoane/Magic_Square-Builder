using System;
class ProblemALG004r
{
    static void magicSquareBuilder(int num, int rotation)
    {

        int[,] magicSquare = new int[num, num];

        //condition 1
        //position for number 1
        int x = 0;
        int y = num / 2;

        for (int c = 1; c <= num * num;)
        {
            // if moved out of the square on the topmost right side
            if (x == -1 && y == num)
            {
                x += 2;
                y--;
                magicSquare[x, y] = c++;
            }
            else
            {
                // if moved out the most top row insert num at the last row
                if (x == -1)
                {
                    x = num - 1;
                }
                // if moved out of the last right coloumn insert num at the first coloumn
                if (y == num)
                {
                    y = 0;
                }
                //if the box is already accupied, insert num(eg. 5) in the box under prevous num (e.g 4)
                if (magicSquare[x, y] != 0)
                {
                    x += 2;
                    y--;
                    magicSquare[x, y] = c++;
                }
                else
                {
                    magicSquare[x, y] = c++;
                }

            }


            //Next number position
            x--;
            y++;

        }

        for (x = 0; x < num; x++)
        {
            for (y = 0; y < num; y++)
            {
                Console.Write(magicSquare[x, y] + " ");
            }
            Console.WriteLine();
        }
    }


    public static void Main()
    {

        int num = 7;
        int rotation = 0;

        magicSquareBuilder(num, rotation);


    }


}
