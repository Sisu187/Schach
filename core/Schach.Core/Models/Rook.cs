namespace Schach.Core;

public class Rook : Figure
{
   public Rook((int row, int col) position, ColorEnum color)
   {
      _position = position;
      _name = "Rook";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "Assets/pictures/white_rook.png" : "Assets/pictures/black_rook.png";
   }

   public override void Move()
   {

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

      (int rowOffset, int colOffset)[] offsets = { (0, 1), (0, -1), (-1, 0), (-1, 0) };

      foreach ((int rowOffset, int colOffset) in offsets)
      {
         int newRow = _position.row + rowOffset;
         int newCol = _position.col + colOffset;

         while (!(newRow > 7 || newRow < 0 || newCol > 7 || newCol < 0))
         {
            Figure figureOnSquare = board.Figures.FirstOrDefault(t => t.Position == (newRow, newCol));

            if (figureOnSquare != null && figureOnSquare.Color == _color)
            {
               continue;
            }

            moves.Add((newRow, newCol));

            newRow += rowOffset;
            newCol += colOffset;
         }
      }

      return moves;
   }
}
