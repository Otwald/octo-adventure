using Godot;
using System.Collections.Generic;

public class StateMaschine : Node
{
    protected const bool DEBUG = true;
    protected Stack<State> statesStack = new Stack<State>();
    protected State currentState = null;
    protected Dictionary<string, State> stateMap = null;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        this.stateMap = new Dictionary<string, State>
        {
            {"idle" , GetNode("Idle") as State},
            {"walk", GetNode("Walk") as State}
        };
        GD.Print(GetNode("Idle") as State);
        currentState = GetNode("Idle") as State;
        this.statesStack.Push(currentState);
        // this.ChangeState("Idle");
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
        string stateName = this.currentState.UpdateProcess(this, delta);
        if (!stateName.Empty())
        {
            this.ChangeState(stateName);
        }
    }
}
