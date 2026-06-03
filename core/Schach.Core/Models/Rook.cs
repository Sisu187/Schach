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
      throw new NotImplementedException();
   }
}
