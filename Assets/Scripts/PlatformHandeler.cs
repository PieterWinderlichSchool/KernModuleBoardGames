    using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlatformHandeler : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> platforms;
    [SerializeField]
    private List<GameObject> activePlatforms;
    [SerializeField]
    private Vector3 newSpawnVector;
    [SerializeField]
    private float platformMovementSpeed;
    public int minimalDespawn;
    
    // Start is called before the first frame update
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(0,-8f,-20), new Vector3(0,8f,-20));
        
        Gizmos.DrawLine(new Vector3(0,-8f,80), new Vector3(0,8f,80));
    }
    /*void Start()
    {   
        CirculateNewBlock();
    }*/

    // Update is called once per frame
    void Update()
    {
        
        if (activePlatforms[0].gameObject.transform.position.z <= minimalDespawn)
        {

            CirculateNewBlock();
        };
    }

    public void CirculateNewBlock()
    {   
        
        

        var newBlockNumber = Mathf.FloorToInt(Random.Range(0f, platforms.Count));
        GameObject newBlock = platforms[newBlockNumber];
        Destroy(activePlatforms[0].gameObject);
        activePlatforms.Remove(activePlatforms[0]);
        
        GameObject gobject = Instantiate(newBlock,newSpawnVector,newBlock.transform.rotation);
        gobject.GetComponent<PlatformMovement>().SetMovementSpeed(platformMovementSpeed);
        activePlatforms.Add(gobject);

    }

    public void SetNewMovementSpeed(float newSpeed)
    {
        platformMovementSpeed = newSpeed;
    }
    public List<GameObject> getActiveObjects()
    {
        return activePlatforms;
    }
}
