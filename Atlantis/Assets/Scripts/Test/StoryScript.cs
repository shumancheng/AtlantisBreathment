using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryScript : MonoBehaviour
{
    public void OnNextSceneButtonClicked()
    {
        FindObjectOfType<ExerciseScript>().OnNextSceneButtonClicked();
    }
}
