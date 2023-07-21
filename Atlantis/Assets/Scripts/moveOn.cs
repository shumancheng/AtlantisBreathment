using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveOn : MonoBehaviour
{
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(DelayMoveOn());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DelayMoveOn()
    {
        yield return new WaitForSeconds(41f);
        SceneManager.LoadScene("HomePage");

    }

}
