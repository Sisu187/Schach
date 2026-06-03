namespace Schach.Core;

public class Bishop : Figure
{
   public Bishop((int row, int col) position, ColorEnum color)
   {
      _position = position;
      _name = "Bishop";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "Assets/pictures/white_bishop.png" : "Assets/pictures/black_bishop.png";
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
