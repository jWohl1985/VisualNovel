using Godot;
using System;

public partial class GameInput : Node
{
    [Export] private Control Environment;
    [Export] private Control UI;
    [Export] private Control Inventory;
    [Export] private Control Journal;

    private bool isJournalOpen = false;
    private bool isInventoryOpen = false;

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("RightClick") && !isJournalOpen && !isInventoryOpen)
        {
            UI.Visible = !UI.Visible;
        }

        if (Input.IsActionJustPressed("Inventory"))
        {
            if (!isInventoryOpen)
            {
                Environment.Visible = false;
                Inventory.Visible = true;
                isInventoryOpen = true;
            }
            else
            {
                Environment.Visible = true;
                Inventory.Visible = false;
                isInventoryOpen = false;
            }

        }

        if (Input.IsActionJustPressed("Journal"))
        {
            if (!isJournalOpen)
            {
                Environment.Visible = true;
                Inventory.Visible = false;
                Journal.Visible = true;
                isJournalOpen = true;
                isInventoryOpen = false;
            }
            else
            {
                Journal.Visible = false;
                isJournalOpen = false;
            }
        }
    }
}