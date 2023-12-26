using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplainBoardController : MonoBehaviour
{
    public Image explainImage;

    public Sprite[] explainSprites;
    public Text explainImagePagenaation;
    public GameObject rightButton;
    public GameObject leftButton;

    int currentPagenation = 1;
    int maxPageNum = -1;

    // Start is called before the first frame update
    void Start()
    {
        currentPagenation = 1;
        maxPageNum = explainSprites.Length;
        explainImagePagenaation.text = currentPagenation.ToString() + " / " + maxPageNum.ToString();

        if (currentPagenation == 1)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(true);
        }
        else if (currentPagenation == maxPageNum)
        {
            leftButton.SetActive(true);
            rightButton.SetActive(false);
        }
        else
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickLeftButton()
    {
        if (currentPagenation == 1)
        {
            explainImage.sprite = explainSprites[currentPagenation - 1];
            explainImagePagenaation.text = currentPagenation.ToString() + " / " + maxPageNum.ToString();
        }
        else
        {
            currentPagenation -= 1;
            explainImage.sprite = explainSprites[currentPagenation - 1];
            explainImagePagenaation.text = currentPagenation.ToString() + " / " + maxPageNum.ToString();
        }

        if (currentPagenation == 1)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(true);
        }
        else if (currentPagenation == maxPageNum)
        {
            leftButton.SetActive(true);
            rightButton.SetActive(false);
        }
        else
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
        }
    }

    public void OnClickRightButton()
    {
        if (currentPagenation == maxPageNum)
        {
            explainImage.sprite = explainSprites[currentPagenation - 1];
            explainImagePagenaation.text = currentPagenation.ToString() + " / " + maxPageNum.ToString();
        }
        else
        {
            currentPagenation += 1;
            explainImage.sprite = explainSprites[currentPagenation - 1];
            explainImagePagenaation.text = currentPagenation.ToString() + " / " + maxPageNum.ToString();
        }

        if (currentPagenation == 1)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(true);
        }
        else if (currentPagenation == maxPageNum)
        {
            leftButton.SetActive(true);
            rightButton.SetActive(false);
        }
        else
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
        }
    }
}
