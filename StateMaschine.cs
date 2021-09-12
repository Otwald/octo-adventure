using Godot;
using System.Collections.Generic;

public class StateMaschine : Node
{
    const bool DEBUG = true;
    Stack<State> statesStack = new Stack<State>();
    State currentState = null;
    Dictionary<string, State> stateMap = null;

    public Player player = null;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        this.stateMap = new Dictionary<string, State>
        {
            {"idle" , GetNode("Idle") as State},
            {"walk", GetNode("Walk") as State},
            {"interact", GetNode("Interact") as State}
        };
        currentState = GetNode("Idle") as State;
        this.statesStack.Push(currentState);
        // this.ChangeState("Idle");
        player = GetParent<Player>();
    }

    public void ChangeState(string stateName)
    {
        if (DEBUG)
        {
            GD.Print("State change to :" + stateName);
        }
        this.currentState.Exit(this);
        if (stateName == "previous")
        {
            this.statesStack.Pop();
        }
        else
        {
            this.statesStack.Push(stateMap[stateName]);
        }
        this.currentState = statesStack.Peek();
        this.currentState.Enter(this);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(float delta)
    {
        string stateName = currentState.UpdateProcess(this, delta);
        if (!stateName.Empty())
        {
            this.ChangeState(stateName);
        }
    }
}
