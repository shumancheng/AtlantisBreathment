using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMapImage : MonoBehaviour
{
    public Image img;
    public Sprite[] spriteArray;
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        img = this.gameObject.GetComponent<Image>();
        spriteArray = Resources.LoadAll<Sprite>("");

        if (GameManager.getSceneIndex() > -1 && GameManager.getSceneIndex() < 6)
        {
            img.sprite = spriteArray[0];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
