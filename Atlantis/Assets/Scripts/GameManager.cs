using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    //contains the exact order of screens presented => Stoory, Exercise, inventory, Homescreen
    static string[] story_line = new string[] {
        "Exercise_1",
        "Exercise_3",
        "HomePage", 
        "Story_1", 
        "Story_1-1", 
        "Story_1-2", 
        "Story_1-3",
        "Inventory 1",
        "Story_1-4",
        "Story_1-5",
        "Exercise_1",
        "Story_2",
        "Story_2-1",
        "Story_2-2",
        "Story_2-3",
        "Story_2-4",
        "Exercise_1",
        "Story_3",
        "Story_3-1",
        "HomePage",
        "Story_4",
        "Story_4-1",
        "Story_4-2",
        "Story_4-3",
        "Story_4-4",
        "Story_4-5",
        "Story_4-6",
        "Story_4-7",
        "Story_4-8",
        "HomePage"
    };
    static int indexCurrentScene;


    // Start is called before the first frame update
    public void Start()
    {
        SceneManager.LoadScene("HomePage");
        GameData data = SaveSystem.LoadGame();
        indexCurrentScene = data.indexCurrentScene;
    }

    public static void Play(string sceneName = "")
    {
        if (sceneName == "HomePage" && story_line[indexCurrentScene] == "HomePage")
        {
            indexCurrentScene++;
            Play("HomePage");
        }
        else
        {
            SceneManager.LoadScene(story_line[indexCurrentScene]);
            indexCurrentScene++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnApplicationQuit()
    {

        //SaveSystem.SaveGame(indexCurrentScene);
        SaveSystem.SaveGame(0);
    }

    public static int getSceneIndex()
    {
        return indexCurrentScene;
    }


    public static void goToMap()
    {
        SceneManager.LoadScene("Map");
    }
}
