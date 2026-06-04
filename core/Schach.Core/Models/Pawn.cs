namespace Schach.Core;

public class Pawn : Figure
{
   public Pawn((int row, int col) position, ColorEnum color)
   {
      _position = position;
      _name = "Pawn";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "Assets/pictures/white_pawn.png" : "Assets/pictures/black_pawn.png";
   }

   public override void Take()
   {

   }

   public override void OnClick_ShowAvailableMoves()
   {
      throw new NotImplementedException();
   }

   public override List<(int row, int col)> GetAvailableMoves(Board board)
   {
      var moves = new List<(int row, int col)>();

      int direction = (_color == ColorEnum.White ? -1 : 1);
      int startRow = (_color == ColorEnum.White ? 6 : 1);

      int newRow = _position.row + direction;
      int newCol = _position.col;

      if (!(newRow > 7 || newRow < 0 || newCol > 7 || newCol < 0))
      {
         Figure blockingFigure = board.Figures.FirstOrDefault(t => t.Position == (_position.row + direction, _position.col));

         if (blockingFigure == null)
         {
            moves.Add((newRow, newCol));

            if (_position.row == startRow)
            {
               Figure doubleBlockingFigure = board.Figures.FirstOrDefault(t => t.Position == (_position.row + direction * 2, _position.col));
               if (doubleBlockingFigure == null)
               {
                  moves.Add((_position.row + direction * 2, _position.col));
               }
            }
         }
         Figure figureLeft = board.Figures.FirstOrDefault(t => t.Position == (_position.row + direction, _position.col - 1));
         if (figureLeft != null && figureLeft.Color != _color)
         {
            moves.Add((_position.row + direction, _position.col - 1));
         }

         Figure figureRight = board.Figures.FirstOrDefault(t => t.Position == (_position.row + direction, _position.col + 1));
         if (figureRight != null && figureRight.Color != _color)
         {
            moves.Add((_position.row + direction, _position.col + 1));
         }
      }

      return moves;
   }
}
