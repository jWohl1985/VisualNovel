using Godot;
using System;

public partial class GameInput : Node
{
    [Export] private Control Environment;
    [Export] private Control UI;
    [Export] private Control Inventory;

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("RightClick"))
        {
            UI.Visible = !UI.Visible;
        }

        if (Input.IsActionJustPressed("Inventory"))
        {
            Environment.Visible = !Environment.Visible;
            UI.Visible = !UI.Visible;
            Inventory.Visible = !Inventory.Visible;
        }
    }
}