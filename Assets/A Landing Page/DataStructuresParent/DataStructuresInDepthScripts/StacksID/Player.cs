using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UndoRedoManager undoRedoManager;

    public void MovePlayer(Vector3  newPosition)
    {
        
        Vector3 oldPosition = transform.position; 
        ICommand moveCommand = new MoveCommand(this.gameObject, oldPosition, newPosition);
        undoRedoManager.ExecuteCommand( moveCommand); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Vector3 newPosition = transform.position + Vector3.forward; 
            MovePlayer(newPosition);
        }

        if(Input.GetKeyDown(KeyCode.U))
        {
            undoRedoManager.Undo(); 
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            undoRedoManager.Redo();
        }

    }
}
