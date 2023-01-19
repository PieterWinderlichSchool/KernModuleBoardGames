using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OnPickup : MonoBehaviour
{
    public GateMovement gate;
    public ScoreManager score;

    public bool isPoints = false;

    public SpriteRenderer appearance;

    public List<Sprite> appearances = new List<Sprite>();

    public int ScoreValue = 0;

    public delegate void CallProgress();

    public CallProgress progressCall;

    public int imageIndex;
     
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
            imageIndex = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            progressCall += progressGate;
            progressCall();
        }
    }

    public void progressGate()
    {
        if (isPoints)
        {
            gate.MoveGate(10);
            score.UpdateScore(ScoreValue);
            appearance.enabled = false;
            Invoke("DestroyGameObject",2f);
        }
        else
        {
            gate.MoveGate(-10);
            appearance.enabled = false;
            Invoke("DestroyGameObject",2f);
        }
    } 
    public void DestroyGameObject()
    {
            Destroy(this.gameObject);
    }
}
