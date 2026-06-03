namespace Schach.Core;

public class King : Figure
{
   public King((int row, int col) position, ColorEnum color)
   {
      _position = position;
      _name = "King";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "Assets/pictures/white_king.png" : "Assets/pictures/black_king.png";
   }

   public override void Move((int row, int col) newPosition)
   {
      _position = newPosition;
   }

   public override void Take()
   {

   }

   public override void OnClick_ShowAvailableMoves()
   {

   }

   public override List<(int row, int col)> GetAvailableMoves(Board board)
   {
      var moves = new List<(int row, int col)>();

      int[] offsets = { -1, 0, 1 };

      foreach (int rowOffset in offsets)
      {
         foreach (int colOffset in offsets)
         {
            int newRow = _position.row + rowOffset;
            int newCol = _position.col + colOffset;

            if (newRow > 7 || newRow < 0 || newCol > 7 || newCol < 0)
            {
               continue;
            }

            Figure figureOnSquare = board.Figures.FirstOrDefault(t => t.Position == (newRow, newCol));

            if (figureOnSquare != null && figureOnSquare.Color == _color)
            {
               continue;
            }

            moves.Add((newRow, newCol));
         }
      }
      return moves;
   }

}
