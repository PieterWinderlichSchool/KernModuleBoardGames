using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMovement : MonoBehaviour
{

    public ManageCanvasses cManager;
    public List<GameObject> gateHalves = new List<GameObject>();

    public float gateOpening = 20;
    // Start is called before the first frame update
    void Start()
    {
        cManager = GameObject.FindWithTag("CanvasManager").GetComponent<ManageCanvasses>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gateOpening <= 0)
        {
            Time.timeScale = 0;
            cManager.changeCanvass(2);
            this.gameObject.SetActive(false);
            
        }else if (gateOpening >= 200)
        {
            Time.timeScale = 0;
            cManager.changeCanvass(3);
            this.gameObject.SetActive(false);
        }
    }

    public void MoveGate(float newXLocation)
    {
        gateOpening -= newXLocation;
        gateHalves[0].transform.position -= new Vector3(newXLocation/10,0,0);
        gateHalves[1].transform.position += new Vector3(newXLocation/10,0,0);
    }
}
