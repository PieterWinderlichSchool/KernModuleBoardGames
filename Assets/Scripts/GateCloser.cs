using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateCloser : MonoBehaviour
{

    public GateMovement gMovement;

    [SerializeField]
    private float closingSpeed;
    [SerializeField]
    private float closingAmount;

    private bool isClosing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        if (gMovement.gateOpening > 50 && isClosing == false)
        {
            StartCoroutine(closeGate());
            isClosing  = true;
        }
    }

    public IEnumerator closeGate()
    {
        while (true)
        {
            gMovement.MoveGate(closingAmount);
            yield return new WaitForSeconds(closingSpeed);
        }
        
    }
}
