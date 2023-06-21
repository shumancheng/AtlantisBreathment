using UnityEngine;
using UnityEngine.SceneManagement;

public class HomepageScript : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        // Load the first exercise scene
        LoadRandomExerciseScene();
    }

    private void LoadRandomExerciseScene()
    {
        int exerciseIndex = Random.Range(1, 4); // Generate a random exercise scene index (change the range to match the total number of exercise scenes)
        SceneManager.LoadScene("Test_Exercise_" + exerciseIndex); // Load the randomly assigned exercise scene
    }
}
