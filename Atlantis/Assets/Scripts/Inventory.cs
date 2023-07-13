using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene()
    {
        if (GameManager.getSceneIndex() <= 5)
        {
            SceneManager.LoadScene(sceneName: "Inventory");
        }
        else
        {
            SceneManager.LoadScene(sceneName: "Inventory 1");
        }
        
    }
}
