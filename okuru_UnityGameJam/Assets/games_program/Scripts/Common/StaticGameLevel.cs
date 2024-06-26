using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticGameLevel
{
    // ======================== //
    // ゲームの難易度を管理する変数の内容
    // GameLevel
    // ・1：Easy
    // ・2：Normal
    // ・3：Hard
    // ======================== //
    public static int GameLevel = 1;

    // ゲームの行えた秒数を保存
    public static float GamePlayTime = 0;

    // 難易度ごとのゲーム秒数
    public static float EasyTime = 40.0f;
    public static float NormalTime = 40.0f;
    public static float HardTime = 50.0f;

    // 難易度ごとのTrueStoryモードヒント表示秒数
    public static float HintEasyTime = 40;
    public static float HintNormalTime = 50;
    public static float HintHardTime = 70;

    // 倒したオブジェクトの情報
    public static string KillOWords = "";
    public static string KillOtherWords = "";
    public static string GameOverWord = "";

    // 難易度ごとに表示されるヒント情報
    public static string HintEasy = "S-3-5-2";
    public static string HintNormal = "7-3-3-7-5";
    public static string HintHard = "3-2-5-E";
}
