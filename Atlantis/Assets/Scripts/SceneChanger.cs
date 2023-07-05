using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public InputField sceneNameInput;

    public void ChangeScene()
    {
        string sceneName = sceneNameInput.text;
        SceneManager.LoadScene(sceneName);
    }
}
