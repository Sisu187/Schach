using System.ComponentModel.DataAnnotations;

namespace Schach.Core;

public abstract class Figure
{
   protected (int row, int col) _position;

   protected string _name;

   protected string _picturePath;

   public (int row, int col) Position { get => _position; set => _position = value; }
   public string Name { get => _name; set => _name = value; }
   public string PicturePath { get =>  _picturePath; set => _picturePath = value; }

   public enum ColorEnum
   {
      White,
      Black
   }

   protected ColorEnum _color;

   public ColorEnum Color { get => _color; set => _color = value; }

   public virtual void Move((int row, int col) newPosition)
   {
      _position = newPosition;
   }

   public abstract void Take();

   public abstract void OnClick_ShowAvailableMoves();

   public abstract List<(int row, int col)> GetAvailableMoves(Board board);
}
