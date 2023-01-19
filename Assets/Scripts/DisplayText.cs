using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public OnPickup pickUpScript;

    public List<string> textVariations = new List<string>();

    public Text textComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        
        this.enabled = true;
        setDisaplay();
        gameObject.SetActive(false);
        pickUpScript.progressCall += createDisplay;
    }

    public void setDisaplay()
    {
        textComponent.text = textVariations[pickUpScript.imageIndex]; 
    }
    

    public void createDisplay()
    {
        gameObject.SetActive(true);
    }
}
