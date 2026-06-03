namespace Schach.Core;

public class Queen : Figure
{
   public Queen((int row, int col) position, ColorEnum color)
   {
      _position = position;
      _name = "Queen";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "Assets/pictures/white_queen.png" : "Assets/pictures/black_queen.png";
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
