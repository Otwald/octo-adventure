using Godot;
using System.Collections.Generic;

public class StateMaschine : Node
{
    const bool DEBUG = true;
    List<State> statesStack = new List<State>();
    State currentState = null;

    Dictionary<string, State> stateMap = null;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        this.stateMap = new Dictionary<string, State>
        {
            {"idle" , GetNode("Idle") as State},
            {"walk", GetNode("Walk") as State}
        };
        currentState = GetNode("Idle") as State;
    }

    public void ChangeState(string stateName)
    {
        if (DEBUG)
        {
            GD.Print("State change to :" + stateName);
        }
        currentState.Exit();
        if (stateName == "previous")
        {
            statesStack.RemoveAt(0);
        }
        else
        {
            statesStack.Add(stateMap[stateName]);
        }
        currentState = statesStack[0];
        currentState.Enter();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        string stateName = currentState.UpdateProcess(delta);
        if (!stateName.Empty())
        {
            this.ChangeState(stateName);
        }
    }
}
