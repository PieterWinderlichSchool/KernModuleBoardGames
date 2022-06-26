using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManageCanvasses : MonoBehaviour
{
    private Scene scene;

    public List<GameObject> canvasses = new List<GameObject>();
    // Start is called before the first frame update
    void Awake()
    {
        scene = SceneManager.GetActiveScene();
        ManageTime(0);
    }

    

    public void Restart()
    {
        SceneManager.UnloadScene(scene.buildIndex);
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        SceneManager.SetActiveScene(scene);
        ManageTime(1);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    public void changeCanvass(int index)
    {
        canvasses[index].SetActive(true);
    }

    public void ManageTime(int index)
    {
        Time.timeScale = index;
    }
}
