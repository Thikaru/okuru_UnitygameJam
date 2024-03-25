using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartController : MonoBehaviour
{
    [SerializeField] private AudioSource buttonAudio;
    [SerializeField] private AudioSource trueButtonAudio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickGameStartEasyMode()
    {
        buttonAudio.Play();
        StaticGameLevel.GameLevel = 1;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickGameStartNormalMode()
    {
        buttonAudio.Play();
        StaticGameLevel.GameLevel = 2;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickGameStartHardMode()
    {
        buttonAudio.Play();
        StaticGameLevel.GameLevel = 3;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickTrueStoryMode()
    {
        trueButtonAudio.Play();
        SceneManager.LoadScene("TrueStoryScene");
    }

    public void OnClickGameChutorialMode()
    {
        buttonAudio.Play();
        SceneManager.LoadScene("ExplainGameScene");
    }
}
