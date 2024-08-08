using Godot;
using System;
using System.Data;

public partial class Cell : Node
{
	public int Row { get; }
	public int Column { get; }
	public Figure Сurrent { get; set; }

	public Cell(int row, int column)
	{
		this.Row = row;
		this.Column = column;
	}
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
