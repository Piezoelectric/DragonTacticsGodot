using Godot;
using System;

public partial class MainMenu : Control
{
	Button startGameButton;
	int seed;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("hello");
		startGameButton = (Button) this.FindChild("StartGameButton");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(startGameButton != null && startGameButton.ButtonPressed) {
			GD.Print("button pressed");
		}
	}
}
