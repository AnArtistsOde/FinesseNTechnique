using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class closeonexit : MonoBehaviour
{
    [SerializeField] private Button onexitbutton;
    [SerializeField] private GameObject entirePanel;

    // Start is called before the first frame update
    private void Awake()
    {
        entirePanel.SetActive(true); 
    }
    void Start()
    {
        onexitbutton.onClick.AddListener(ExitAll); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitAll ()
    {

        entirePanel.SetActive(false); 
    }
}
