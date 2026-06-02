using Avalonia.Controls;
using Avalonia.Media;

namespace Schach.Avalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CreateChessBoard();
    }

    private void CreateChessBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            ChessBoard.RowDefinitions.Add(new RowDefinition(GridLength.Star));
            ChessBoard.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Star));
        }

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                bool isLightSquare = (row + col) % 2 == 0;

                var square = new Border
                {
                    Background = isLightSquare
                        ? Brushes.Beige
                        : Brushes.SaddleBrown
                };

                Grid.SetRow(square, row);
                Grid.SetColumn(square, col);

                ChessBoard.Children.Add(square);
            }
        }
    }

    private void SetupFigures()
    {
        
    }
}