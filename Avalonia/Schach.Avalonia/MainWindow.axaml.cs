using System;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Schach.Core;
using Avalonia.Platform;
using System.Collections.Generic;
using Avalonia.Controls.Shapes;

namespace Schach.Avalonia;

public partial class MainWindow : Window
{
    private Board _board = new Board();
    public MainWindow()
    {
        InitializeComponent();
        CreateChessBoard();

        SetupFigures();
    }

    private void CreateChessBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            ChessBoard.RowDefinitions.Add(new RowDefinition(GridLength.Star));
            ChessBoard.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Star));

            PieceLayer.RowDefinitions.Add(new RowDefinition(GridLength.Star));
            PieceLayer.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Star));

            ExtraLayer.RowDefinitions.Add(new RowDefinition(GridLength.Star));
            ExtraLayer.ColumnDefinitions.Add(new ColumnDefinition(GridLength.Star));


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
        PieceLayer.Children.Clear();

        foreach (Figure figure in _board.Figures)
        {
            var uri = new Uri($"avares://Schach.Avalonia/{figure.PicturePath}");
            var image = new Image
            {
                Source = new Bitmap(AssetLoader.Open(uri)),
                Width = 60,
                Height = 60
            };

            Grid.SetRow(image, figure.Position.row);
            Grid.SetColumn(image, figure.Position.col);

            var capturedFigure = figure;
            image.PointerPressed += (sender, e) =>
            {
                ExtraLayer.Children.Clear();
                var moves = capturedFigure.GetAvailableMoves(_board);
                ShowAvailableMoves(moves);
            };

            PieceLayer.Children.Add(image);
        }
    }

    private void ShowAvailableMoves(List<(int row, int col)> moves)
    {
        ExtraLayer.Children.Clear();

        foreach (var (row, col) in moves)
        {
            var circle = new Ellipse()
            {
                Width = 20,
                Height = 20,
                Fill = new SolidColorBrush(Color.FromArgb(120, 0, 0, 0))
            };
            Grid.SetRow(circle, row);
            Grid.SetColumn(circle, col);
            ExtraLayer.Children.Add(circle);
        }
    }
}