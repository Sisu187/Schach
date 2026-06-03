using System.Collections.Generic;

namespace Schach.Core;

public class Board
{
    private List<Figure> _figures = new List<Figure>();
    public List<Figure> Figures { get => _figures; private set; }

    public Board()
    {
        SetupDefaultPosition();
    }

    private void SetupDefaultPosition()
    {
        _figures.Add(new King((7, 4), Figure.ColorEnum.White));
        _figures.Add(new Rook((7, 7), Figure.ColorEnum.White));
        _figures.Add(new Rook((7, 0), Figure.ColorEnum.White));
        _figures.Add(new Knight((7, 6), Figure.ColorEnum.White));
        _figures.Add(new Knight((7, 1), Figure.ColorEnum.White));
        _figures.Add(new Bishop((7, 5), Figure.ColorEnum.White));
        _figures.Add(new Bishop((7, 2), Figure.ColorEnum.White));
        _figures.Add(new Queen((7, 3), Figure.ColorEnum.White));
        _figures.Add(new Pawn((6, 0), Figure.ColorEnum.White));
        _figures.Add(new Pawn((6, 1), Figure.ColorEnum.White));
        _figures.Add(new Pawn((6, 2), Figure.ColorEnum.White));
        _figures.Add(new Pawn((6, 3), Figure.ColorEnum.White));
        _figures.Add(new Pawn((6, 4), Figure.ColorEnum.White));
        _figures.Add(new Pawn((6, 5), Figure.ColorEnum.White));
        _figures.Add(new Pawn((6, 6), Figure.ColorEnum.White));
        _figures.Add(new Pawn((6, 7), Figure.ColorEnum.White));
        
        _figures.Add(new King((0, 4), Figure.ColorEnum.Black));
        _figures.Add(new Rook((0, 7), Figure.ColorEnum.Black));
        _figures.Add(new Rook((0, 0), Figure.ColorEnum.Black));
        _figures.Add(new Knight((0, 6), Figure.ColorEnum.Black));
        _figures.Add(new Knight((0, 1), Figure.ColorEnum.Black));
        _figures.Add(new Bishop((0, 5), Figure.ColorEnum.Black));
        _figures.Add(new Bishop((0, 2), Figure.ColorEnum.Black));
        _figures.Add(new Queen((0, 3), Figure.ColorEnum.Black));
        _figures.Add(new Pawn((1, 0), Figure.ColorEnum.Black));
        _figures.Add(new Pawn((1, 1), Figure.ColorEnum.Black));
        _figures.Add(new Pawn((1, 2), Figure.ColorEnum.Black));
        _figures.Add(new Pawn((1, 3), Figure.ColorEnum.Black));
        _figures.Add(new Pawn((1, 4), Figure.ColorEnum.Black));
        _figures.Add(new Pawn((1, 5), Figure.ColorEnum.Black));
        _figures.Add(new Pawn((1, 6), Figure.ColorEnum.Black));
        _figures.Add(new Pawn((1, 7), Figure.ColorEnum.Black));

        _figures.Add(new Knight((5, 4), Figure.ColorEnum.Black));
        _figures.Add(new Knight((5, 5), Figure.ColorEnum.Black));
    }
}