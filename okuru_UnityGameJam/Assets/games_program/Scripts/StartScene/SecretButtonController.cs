using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretButtonController : MonoBehaviour
{
    // ======================== //
    // 正解コマンド
    // 「右上3」→「左下5」→「左上2」→「右下7」→「右上3」→「右上3」→「右下7」→「左下5」→「右上3」→「左上2」→「左下5」
    // ======================== //

    // シークレットボタンオブジェクト
    public GameObject SecretButton;

    // シークレットボタン呼び出しコマンドカウント
    int SuccessCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        SecretButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickUpLeftButton()
    {
        if (SuccessCount == 2 || SuccessCount == 9)
        {
            SuccessCount += 1;
        }
        else
        {
            SuccessCount = 0;
        }
    }

    public void OnClickUpRightButton()
    {
        if (SuccessCount == 0 || SuccessCount == 4 || SuccessCount == 5 || SuccessCount == 8)
        {
            SuccessCount += 1;
        }
        else
        {
            SuccessCount = 0;
        }
    }

    public void OnClickDownLeftButton()
    {
        if (SuccessCount == 1 || SuccessCount == 7 || SuccessCount == 10)
        {
            SuccessCount += 1;
        }
        else
        {
            SuccessCount = 0;
        }

        if (SuccessCount == 11)
        {
            SecretButton.SetActive(true);
        }
    }

    public void OnClickDownRightButton()
    {
        if (SuccessCount == 3 || SuccessCount == 6)
        {
            SuccessCount += 1;
        }
        else
        {
            SuccessCount = 0;
        }
    }
}
