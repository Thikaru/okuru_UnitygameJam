using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class ResultController : MonoBehaviour
{
    public Text HintMessageText;
    public Text ResultPlayTimeMessageText;
    public TMP_Text KillOWordsText;
    public TMP_Text KillOtherWordsText;
    public TMP_Text GameOverWordsText;
    [SerializeField] private AudioSource EndAudio;

    // Start is call before the first frame update
    void Start()
    {
        KillOtherWordsText.text = "";
        KillOWordsText.text = "";
        GameOverWordsText.text = "";

        if (StaticGameLevel.KillOWords != "")
        {
            KillOWordsText.text = "倒した「お」という読み：" + StaticGameLevel.KillOWords;
        }

        if (StaticGameLevel.KillOtherWords != "")
        {
            KillOtherWordsText.text = "倒した「お」以外の読み：" + StaticGameLevel.KillOtherWords;
        }

        if (StaticGameLevel.GameOverWord != "")
        {
            GameOverWordsText.text = "倒せなかった「お」と読む字：" + StaticGameLevel.GameOverWord;
        }

        ResultPlayTimeMessageText.text = StaticGameLevel.GamePlayTime.ToString();
        if (StaticGameLevel.GameLevel == 1 && StaticGameLevel.GamePlayTime >= StaticGameLevel.HintEasyTime)
        {
            HintMessageText.text = StaticGameLevel.HintEasy;
        }
        else if (StaticGameLevel.GameLevel == 2 && StaticGameLevel.GamePlayTime >= StaticGameLevel.HintNormalTime)
        {
            HintMessageText.text = StaticGameLevel.HintNormal;
        }
        else if (StaticGameLevel.GameLevel == 3 && StaticGameLevel.GamePlayTime >= StaticGameLevel.HintHardTime)
        {
            HintMessageText.text = StaticGameLevel.HintHard;
        }

        ResultPlayTimeMessageText.text = "Play Time\n" + (Mathf.Floor(StaticGameLevel.GamePlayTime * 10) / 10).ToString() + " 秒";

        EndAudio.Play();
    }

    // Update is call once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StaticGameLevel.KillOWords = "";
            StaticGameLevel.KillOtherWords = "";
            StaticGameLevel.GameOverWord = "";
            SceneManager.LoadScene("StartScene");
        }
    }
}
