using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;


    public float FillSpeed = 0.5f;
    private float targetProgress = 0;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("ProgressBarParticleSystem").GetComponent<ParticleSystem>();
    }
    // Start is called before the first frame update
    void Start()
    {
       IncrementProgress(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            slider.value += FillSpeed * Time.deltaTime;
            if (!particleSys.isPlaying)
                particleSys.Play();
        }
        else
        {
            particleSys.Stop();
        }
            
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
} */

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;
    private bool startProgress;
    public GameManager gameManager;

    public float FillSpeed = 0.5f;
    private float targetProgress = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("ProgressBarParticleSystem").GetComponent<ParticleSystem>();
    }

    // Start is called before the first frame update
    void Start()
    {
        startProgress = false;

        // Start coroutine to delay the progress bar
        StartCoroutine(DelayProgressBar());
    }

    // Update is called once per frame
    void Update()
    {
        if (startProgress && slider.value < targetProgress)
        {
            slider.value += FillSpeed * Time.deltaTime;
            if (!particleSys.isPlaying)
                particleSys.Play();
                
        }
        else
        {
            particleSys.Stop();
            if (startProgress)
            {
                Debug.Log("Exercise finished");
                GameManager.Play();
            }

        }
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }

    IEnumerator DelayProgressBar()
    {
        yield return new WaitForSeconds(5f);
        startProgress = true;
        targetProgress = 1f;
    }
}