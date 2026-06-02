namespace Schach.Core;

public class Knight : Figure
{
   public Knight((int, int) position, ColorEnum color)
   {
      _position = position;
      _name = "Knight";
      _color = color;
      _picturePath = (_color == ColorEnum.White) ? "pictures/white_knight.png" : "pictures/black_knight.png";
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
