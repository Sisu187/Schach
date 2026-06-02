namespace Schach.Core;

public class Bishop : Figure
{
   public Bishop((int, int) position, ColorEnum color)
   {
      _position = position;
      _name = "Bishop";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "pictures/white_bishop.png" : "pictures/black_bishop.png";
   }

   public override void Move()
   {
      
   }

   public override void Take()
   {
      
   }

   public override void Display()
   {
      
   }

}
