using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrueStoryController : MonoBehaviour
{
    public GameObject backGroundObject;
    public Sprite woBackGroundSprite;
    public Sprite blackBackGroundSprite;
    public Sprite deathBackGroundSprite;
    // 表示したい文字列配列
    public string[] showTexts;
    // 表示するテキストボックス
    public TMP_Text ShowTMPText;
    public TMP_Text TobeContinuedTMPText;
    bool textStop = false;
    int displayTextSpeed=0;
    // ======================= //
    // 0:遅い
    // 1:普通
    // 2:早い
    // ======================= //
    public int speedFlag;
    string displayText;
    int textNumber;
    int textCharNumber;
    bool click = false;
    // ======================= //
    // 0:文字を出力
    // 1:TobeContinue表示
    // 2:スタートページへ
    // ======================= //
    int phaseFlag = 0;


    // Start is called before the first frame update
    void Start()
    {
        textCharNumber = 0;
        textNumber = 0;
        displayText = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (textStop == true)
        {
            if (Input.GetMouseButton(0) && phaseFlag != 2)
            {
                phaseFlag = 2;
                backGroundObject.GetComponent<Image>().sprite = blackBackGroundSprite;
                ShowTMPText.text = "";
                TobeContinuedTMPText.text = "To Be Continued";
                Invoke("TransactionStartScene", 3.0f);
            }else if (phaseFlag == 2)
            {
                if (Input.GetMouseButton(0))
                {
                    //SceneManager.LoadScene("StartScene");
                }
            }
        }

        // 文章表示パート
        if (textStop == false)
        {
            displayTextSpeed++;
            // 速度設定ごとの分岐
            if (speedFlag == 0)
            {
                if (displayTextSpeed % 10 == 0)
                {
                    if (textCharNumber != showTexts[textNumber].Length)
                    {
                        if (showTexts[textNumber][textCharNumber] == '*')
                        {
                            displayText = displayText + "\n";
                        }
                        else
                        {
                            displayText = displayText + showTexts[textNumber][textCharNumber];
                        }
                        textCharNumber += 1;
                    }
                    else
                    {
                        if (textNumber != showTexts.Length -1)
                        {
                            if (click == true)
                            {
                                displayText = "";
                                textCharNumber = 0;
                                textNumber += 1;
                            }
                        }
                        else
                        {
                            if (click == true)
                            {
                                displayText = "";
                                textCharNumber = 0;
                                textStop = true;
                            }
                        }
                    }

                    ShowTMPText.text = displayText;
                    click = false;
                }
                if (Input.GetMouseButton(0))
                {
                    click = true;
                }
            }
            else if (speedFlag == 1)
            {
                if (displayTextSpeed % 30 == 0)
                {
                    if (displayTextSpeed % 1 == 0)
                    {
                        if (textCharNumber != showTexts[textNumber].Length)
                        {
                            if (showTexts[textNumber][textCharNumber] == '*')
                            {
                                displayText = displayText + "\n";
                            }
                            else
                            {
                                displayText = displayText + showTexts[textNumber][textCharNumber];
                            }
                            textCharNumber += 1;
                        }
                        else
                        {
                            if (textNumber != showTexts.Length - 1)
                            {
                                if (click == true)
                                {
                                    displayText = "";
                                    textCharNumber = 0;
                                    textNumber += 1;
                                }
                            }
                            else
                            {
                                if (click == true)
                                {
                                    displayText = "";
                                    textCharNumber = 0;
                                    textStop = true;
                                }
                            }
                        }

                        ShowTMPText.text = displayText;
                        click = false;
                    }
                    if (Input.GetMouseButton(0))
                    {
                        click = true;
                    }
                }
            }
            else if (speedFlag == 2)
            {
                if (displayTextSpeed % 60 == 0)
                {
                    if (displayTextSpeed % 1 == 0)
                    {
                        if (textCharNumber != showTexts[textNumber].Length)
                        {
                            if (showTexts[textNumber][textCharNumber] == '*')
                            {
                                displayText = displayText + "\n";
                            }
                            else
                            {
                                displayText = displayText + showTexts[textNumber][textCharNumber];
                            }
                            textCharNumber += 1;
                        }
                        else
                        {
                            if (textNumber != showTexts.Length - 1)
                            {
                                if (click == true)
                                {
                                    displayText = "";
                                    textCharNumber = 0;
                                    textNumber += 1;
                                }
                            }
                            else
                            {
                                if (click == true)
                                {
                                    displayText = "";
                                    textCharNumber = 0;
                                    textStop = true;
                                }
                            }
                        }

                        ShowTMPText.text = displayText;
                        click = false;
                    }
                    if (Input.GetMouseButton(0))
                    {
                        click = true;
                    }
                }
            }

        }

        // 「を」が登場する画面に変更
        if (textNumber == 6)
        {
            backGroundObject.GetComponent<Image>().sprite = woBackGroundSprite;
            ShowTMPText.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (textNumber == 10)
        {
            backGroundObject.GetComponent<Image>().sprite = deathBackGroundSprite;
            ShowTMPText.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
    }

    void TransactionStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
