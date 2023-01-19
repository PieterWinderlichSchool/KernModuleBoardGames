using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platformspeed : MonoBehaviour
{
    public PlatformHandeler platformHandeler;

    public GameObject gate;
    public GateMovement gMovement;
    public float currentDistance = 20;
    public float speed = 15;
    // Start is called before the first frame update
    void Start()
    {
        platformHandeler = GetComponent<PlatformHandeler>();
        gMovement = gate.GetComponent<GateMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float newDistance = 35 + gMovement.gateOpening;
        if (newDistance != currentDistance)
        {
            speed =+ (1.75f * (newDistance/ 10)+10);
            UpdateMovement(speed);
            currentDistance = newDistance;
        }else
        {
            return;
        }
    }

  public void UpdateMovement(float newSpeed)
    {
        platformHandeler.SetNewMovementSpeed(newSpeed);
        foreach (GameObject pmovement in platformHandeler.getActiveObjects() )
        {
            pmovement.GetComponent<PlatformMovement>().SetMovementSpeed(newSpeed);
        } 
    }
}
