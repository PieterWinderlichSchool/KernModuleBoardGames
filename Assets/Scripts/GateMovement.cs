using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMovement : MonoBehaviour
{

    public ManageCanvasses cManager;
    // Start is called before the first frame update
    void Start()
    {
        cManager = GameObject.FindWithTag("CanvasManager").GetComponent<ManageCanvasses>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 0)
        {
            Time.timeScale = 0;
            cManager.changeCanvass(3);
            this.gameObject.SetActive(false);
            
        }else if (transform.position.z >= 200)
        {
            Time.timeScale = 0;
            cManager.changeCanvass(2);
            this.gameObject.SetActive(false);
        }
    }

    public void MoveGate(int newZLocation)
    {
        transform.position += new Vector3(0,0,newZLocation);
    }
}
