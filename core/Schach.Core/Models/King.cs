namespace Schach.Core;

public class King : Figure
{
   public King((int, int) position, ColorEnum color)
   {
      _position = position;
      _name = "King";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "pictures/white_king.png" : "pictures/black_king.png";
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
