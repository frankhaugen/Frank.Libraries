﻿namespace Frank.Libraries.Gaming.Sudoku.Models;

public class Board
{
    public Board() => Cells = GenerateCells();

    public Cell[,] Cells { get; }

    private Cell[,] GenerateCells()
    {
        var output = new Cell[9, 9];

        for (var i = 1; i < 10; i++)
        {
            for (var j = 1; j < 10; j++)
            {
                output[i, j] = new Cell(new Position(i, j));
            }
        }

        return output;
    }
}