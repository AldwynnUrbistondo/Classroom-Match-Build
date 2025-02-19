using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPanel : MonoBehaviour
{
    public Sprite[] Tutor;
    public Image Tutorial_image;

    public int hotdog = 0;
    public Button previousButton;
    public Button nextButton;

    public void nextImage()
    {
        hotdog++;
        Tutorial_image.sprite = Tutor[hotdog];
    }

    public void prevImage()
    {
        hotdog--;
        Tutorial_image.sprite = Tutor[hotdog];
    }

    void Update()
    {
        if (hotdog == 0)
        {
            previousButton.gameObject.SetActive(false);
        }
        else if (hotdog > 0)
        {
            previousButton.gameObject.SetActive(true);
        }

        if (hotdog == 4)
        {
            nextButton.gameObject.SetActive(false);
        }
        
        else if (hotdog < 4)
        {
            nextButton.gameObject.SetActive(true);
        }
    }
}
