using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProgressTracker : MonoBehaviour
{

    public GateMovement gMovement;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        gMovement = GameObject.FindWithTag("Gate").GetComponent<GateMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = ((200 - gMovement.transform.position.z) / 100) / 2;
    }
}
