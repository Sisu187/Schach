namespace Schach.Core;

public class Knight : Figure
{
   public Knight((int row, int col) position, ColorEnum color)
   {
      _position = position;
      _name = "Knight";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "Assets/pictures/white_knight.png" : "Assets/pictures/black_knight.png";
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
      throw new NotImplementedException();
   }
}
