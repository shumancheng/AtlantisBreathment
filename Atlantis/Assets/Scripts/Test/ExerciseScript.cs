using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ExerciseScript : MonoBehaviour
{
    private List<int> exerciseIndices = new List<int> { 1, 2, 3 }; // List to hold the exercise scene indices in random order
    private int currentExerciseIndex = 0; // Variable to track the current exercise index
    private int currentStoryIndex = 1; // Variable to track the current story index

    public void OnNextSceneButtonClicked()
    {
        if (currentExerciseIndex < exerciseIndices.Count)
        {
            int exerciseIndex = GetRandomExerciseIndex();
            SceneManager.LoadScene("Test_Exercise_" + exerciseIndex); // Load the next random exercise scene
        }
        else
        {
            // All exercises are completed, load the end screen or any other desired scene
            SceneManager.LoadScene("Test_HomeScreen");
            return;
        }

        int storyPartIndex = currentStoryIndex;
        SceneManager.LoadScene("Test_Story_" + storyPartIndex); // Load the corresponding story part scene

        currentStoryIndex++; // Increment the story index

        // Check if all story parts are completed
        if (currentStoryIndex > 3)
        {
            currentStoryIndex = 1; // Reset the story index if all parts are completed
        }

        currentExerciseIndex++;
    }

    private int GetRandomExerciseIndex()
    {
        int randomIndex = Random.Range(0, exerciseIndices.Count);
        int exerciseIndex = exerciseIndices[randomIndex];
        exerciseIndices.RemoveAt(randomIndex);
        return exerciseIndex;
    }
}
