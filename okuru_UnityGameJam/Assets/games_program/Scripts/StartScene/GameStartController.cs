using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartController : MonoBehaviour
{
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
        StaticGameLevel.GameLevel = 1;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickGameStartNormalMode()
    {
        StaticGameLevel.GameLevel = 2;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickGameStartHardMode()
    {
        StaticGameLevel.GameLevel = 3;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickTrueStoryMode()
    {
        SceneManager.LoadScene("TrueStoryScene");
    }

    public void OnClickGameChutorialMode()
    {
        SceneManager.LoadScene("ExplainGameScene");
    }
}
