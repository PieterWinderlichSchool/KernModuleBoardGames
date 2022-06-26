using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPickup : MonoBehaviour
{
    public GateMovement gate;
    public ScoreManager score;

    public bool isPoints = false;

    public SpriteRenderer appearance;

    public List<Sprite> appearances = new List<Sprite>();

    public int ScoreValue = 0;
    
    // Start is called before the first frame update
    void Awake()
    {
        gate = GameObject.FindWithTag("Gate").GetComponent<GateMovement>();
        score = GameObject.FindWithTag("ScoreManager").GetComponent<ScoreManager>();
    }

    public void ceatePickup(int itemIndex)
    {
        appearance.sprite = appearances[itemIndex];
        if (itemIndex == 1)
        {
            isPoints = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            progressGate();
            
        }
    }

    public void progressGate()
    {
        if (isPoints)
        {
            gate.MoveGate(10);
            score.UpdateScore(ScoreValue);
            Destroy(this.gameObject);
        }
        else
        {
            gate.MoveGate(-10);
            Destroy(this.gameObject);
        }
        
    } 
}
