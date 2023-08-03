using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoRedoManager : MonoBehaviour
{ private Stack<ICommand> undoStack;
    private Stack<ICommand> redoStack;
    public ICommand command; 

        public UndoRedoManager()
    {
        redoStack = new Stack <ICommand>();
        undoStack = new Stack <ICommand> ();
    }
    public void ExecuteCommand(ICommand command )
    {
        command.Execute();
        undoStack.Push(command);
        redoStack.Clear(); 
    }

    public void Undo()
    {
        if( undoStack.Count > 0)
            { ICommand command = undoStack.Pop();}
        command.Undo(); 
        redoStack.Push(command); 
    }

    public void Redo ()
    {
        if(redoStack.Count >0)
        {
            ICommand command = redoStack.Pop();
            command.Execute();
                undoStack.Push(command); 
        }
    }
}
