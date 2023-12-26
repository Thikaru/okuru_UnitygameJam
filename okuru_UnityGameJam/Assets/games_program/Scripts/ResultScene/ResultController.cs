using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ResultController : MonoBehaviour
{
    public Text HintMessageText;
    public Text ResultPlayTimeMessageText;

    // Start is called before the first frame update
    void Start()
    {
        ResultPlayTimeMessageText.text = StaticGameLevel.GamePlayTime.ToString();
        if (StaticGameLevel.GameLevel == 1 && StaticGameLevel.GamePlayTime >= StaticGameLevel.HintEasyTime){
            HintMessageText.text = StaticGameLevel.HintEasy;
        }else if (StaticGameLevel.GameLevel == 2 && StaticGameLevel.GamePlayTime >= StaticGameLevel.HintNormalTime)
        {
            HintMessageText.text = StaticGameLevel.HintNormal;
        }
        else if(StaticGameLevel.GameLevel == 3 && StaticGameLevel.GamePlayTime >= StaticGameLevel.HintHardTime){
            HintMessageText.text = StaticGameLevel.HintHard;
        }

        ResultPlayTimeMessageText.text = "Play Time\n" + (Mathf.Floor(StaticGameLevel.GamePlayTime *10) / 10).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
