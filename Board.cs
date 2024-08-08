using Godot;
using System;

public partial class Board : Node2D
{
	public PackedScene CellScene { get; set; }
	public Cell[][] Cells { get; private set; }

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Cells = new Cell[8][];
		for (int i = 0; i < 8; i++)
		{
			Cells[i] = new Cell[8];
		}
		
		for (int i = 0; i < Cells.Length; i++)
		{
			for (int j = 0; j < Cells[i].Length; j++)
			{
				Cells[i][j] = new Cell(i, j);
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
