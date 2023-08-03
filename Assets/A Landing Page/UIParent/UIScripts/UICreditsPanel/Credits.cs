using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    [Header("Credits Configuration")]
    [SerializeField] private Button clickCredits;
    [SerializeField] private GameObject creditsScreen;
    //[SerializeField] private GameObject creditsInfoPanel;
    [SerializeField] private Button exitCredits;
    [Header("Color Configuration")]
    [SerializeField] private Button clickColors;
    [SerializeField] private GameObject colorsScreen;
    [SerializeField] private Button exitColors;
  
    [SerializeField] private GameObject birdie;
    [SerializeField] private Button color1clicked; 
    [SerializeField] private Color color1;


    [SerializeField] private Button color2clicked;
    [SerializeField] private Color color2; 
  


    


    // Start is called before the first frame update
    private void Awake()
    {
        creditsScreen.SetActive(false);
        colorsScreen.SetActive(false);
    }
    void Start()
    {
        clickCredits.onClick.AddListener(CreditsAreClicked);
        exitCredits.onClick.AddListener(ExitCredits); 
        clickColors.onClick.AddListener(ColorsAreClicked);
       // color1clicked.onClick.AddListener(Color1Clicked);
       //color2clicked.onClick.AddListener(Color2Clicked);
        exitColors.onClick.AddListener(ExitColors);
        //Color1Clicked();
        //Color2Clicked(); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreditsAreClicked()
    {
        creditsScreen.SetActive(false);
     //   Instantiate(creditsScreen);
        creditsScreen.SetActive(true);
        Debug.Log("working credits"); 
    }

    public void ExitCredits()
    {
        creditsScreen.SetActive(false);
    }

    public void ColorsAreClicked()
    {
        colorsScreen.SetActive(false);
        colorsScreen.SetActive(true);
        Debug.Log("colors working"); 
    }
    public void ExitColors()
    {
        colorsScreen.SetActive(false); 
    }

    //public void Color1Clicked()
    //{
    //    color2clicked.GetComponent<Image>().color = color2;
        
    //}

    //public void Color2Clicked()
    //{
    //    color2clicked.GetComponent<Image>().color = color1; 
     
    //}
}
