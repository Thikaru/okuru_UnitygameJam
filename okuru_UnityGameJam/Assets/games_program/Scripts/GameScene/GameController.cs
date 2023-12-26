using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject StartGameObject;
    public GameObject EndGameObject;
    public GameObject StartMessageCanvas;
    public Text ShowTimeText;

    public Text EndGameMessage;

    public GameObject WordObject;

    // ====================== //
    // ゲーム状況フラグ
    // 1：開始前
    // 2：ゲーム中
    // 3：ゲーム終了
    // ====================== //
    int GameFlag = 1;

    // ゲーム時間
    float GameTime = 0;
    bool GameEndFlag = false;
    public bool isTimeOver = false;
    public float displayTime = 0;
    float times = 0;
    public bool isCountDown = true;
    float total_times = 0.0f;
    int increaseTimeCount = 0;
    int decreaseTimeCount = 0;
    bool gameStartFlag = false;

    bool isObject = false;
    int judgeNum = 50;
    int biasCount = 0;
    bool isBeforeOWord = false;
    string oString;
    string otherString;

    float objectTime = 0;
    public float objectJudgeTime = 2.0f;

    GameObject wordObject;
    GameObject wordChildObject;
    GameObject wordTextObject;

    string easy_mode_true_strings = "おオoO";
    string easy_mode_false_strings = "あいうえかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわんアイウエカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワンabcdefghijklmnpqqrstuvwxygABCDEFGHIJKLMNPQRSTUVWXYZ";
    string normal_mode_true_strings = "尾雄追負惜起押汚老御折落推小終降緒";
    string normal_mode_false_strings = "飯渉様謙協痘倒奉胃位意違医ゐ委韋良維化家下日蚊課可何禍異遺域宇映延沿我灰拡革閣割株巻看簡危机揮貴疑吸供胸郷勤筋系敬警劇激穴絹権憲源厳誤后孝皇紅降鋼刻穀骨困砂座済裁策冊蚕至私姿視詞誌磁射捨尺若樹収宗就衆従縦縮熟純処署諸除傷障城蒸仁垂推寸盛聖誠宣専泉洗染善奏窓創装層操蔵臓存尊宅担探誕段暖値一右雨円下火花貝学気九休玉金空月犬見五口校左三山子四糸字耳七車手十出首秋週春書場色食心新主守取酒受州拾終習集住重宿所暑助昭消商章勝乗植申身神真深進世整昔全相息速族他打対待代第題炭短談着注柱丁帳調定庭笛転都度投豆島湯登等童農";
    string hard_mode_true_strings = "苧曖塢惡閼於唹乎噁淤毆嫗紆瓮區淤唹堊塢飫毆歐樞噁鴎甌閼甕鶲歐";
    string hard_mode_false_strings = "藜蜊蕣鶩鐙廬筏斑蝗疣甍嗽鶉粳蟒蛇靨鰓櫂鰄嬶篝瘡蓋鎹庚鼎黴簪橇閂樵黍瓩粁鵠楔嚔軛踝楮鐺虱鼈倅薇橙箍鏨胼胝蓼盥粽鶫貂薺棗憖蓴塒鑿莠艀鰰餞羆蜩楸鞴蕗箆釦秣鉞俎蛟樅碼蕨";


    // Start is called before the first frame update
    void Start()
    {
        StartGameObject.GetComponent<Animator>().enabled = false;
        EndGameObject.GetComponent<Animator>().enabled = false;
        //StartGameObject.SetActive(false);
        EndGameObject.SetActive(false);
        if (StaticGameLevel.GameLevel == 1){
            // Easyモード
            GameTime = StaticGameLevel.EasyTime;
            displayTime = StaticGameLevel.EasyTime;
            oString = easy_mode_true_strings;
            otherString = easy_mode_false_strings;
        }
        else if (StaticGameLevel.GameLevel == 2){
            // Normalモード
            GameTime = StaticGameLevel.NormalTime;
            displayTime = StaticGameLevel.NormalTime;
            oString = normal_mode_true_strings;
            otherString = normal_mode_false_strings;
        }
        else if (StaticGameLevel.GameLevel == 3){
            // Hardモード
            GameTime = StaticGameLevel.HardTime;
            displayTime = StaticGameLevel.HardTime;
            oString = hard_mode_true_strings;
            otherString = hard_mode_false_strings;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (GameFlag ==1){
            //ゲーム開始
            //画面がクリックされたかどうか
            if (Input.GetMouseButtonDown(0)){
                StartMessageCanvas.SetActive(false);
                // アニメーション開始
                StartGameObject.GetComponent<Animator>().enabled = true;
                StartGameObject.GetComponent<Animator>().Play("GameStart", 0, 0);
                Invoke("StartGame", 1.0f);
                isTimeOver = false;
                gameStartFlag = true;
                GameEndFlag = false;
            }
        }else if(GameFlag == 2){
            //ゲーム中
            if (gameStartFlag == true && GameEndFlag == false)
            {
                // オブジェクト倒すところ
                //オブジェクト生成

                if (isObject == true)
                {
                    objectTime += Time.deltaTime;
                    if (Input.GetMouseButtonDown(0))
                    {
                        Destroy(wordObject);
                        objectTime = 0;
                        isObject = false;

                        if (isBeforeOWord == true)
                        {
                            increaseTimeCount += 1;
                        }
                        else
                        {
                            decreaseTimeCount += 1;
                        }
                    }else if (objectTime >= objectJudgeTime)
                    {
                        Destroy(wordObject);
                        objectTime = 0;
                        isObject = false;

                        if (isBeforeOWord == true)
                        {
                            decreaseTimeCount += 100000;
                            isTimeOver = true;
                        }
                    }
                }else if (isObject == false)
                {
                    wordObject = Instantiate(WordObject);
                    wordChildObject = wordObject.transform.GetChild(0).gameObject;
                    wordTextObject = wordChildObject.transform.GetChild(0).gameObject;
                    wordTextObject.GetComponent<TextMeshProUGUI>().fontSize = 200;

                    int random_num = UnityEngine.Random.Range(1, 100);
                    if (random_num <= judgeNum)
                    {
                        //「お」と読む文字を選択
                        int random_index = UnityEngine.Random.Range(0, oString.Length - 1);
                        wordTextObject.GetComponent<TextMeshProUGUI>().text = oString[random_index].ToString();
                        isBeforeOWord = true;

                        if (isBeforeOWord == true)
                        {
                            biasCount += 1;
                            if (biasCount >= 2)
                            {
                                judgeNum = judgeNum - 10 * biasCount;
                            }
                        }
                        else
                        {
                            judgeNum = 50;
                            biasCount = 0;
                        }
                    }
                    else
                    {
                        //「お」以外の読み方をするものを選択
                        int random_index = UnityEngine.Random.Range(0, otherString.Length - 1);
                        wordTextObject.GetComponent<TextMeshProUGUI>().text = otherString[random_index].ToString();
                        isBeforeOWord = false;

                        if (isBeforeOWord == false)
                        {
                            biasCount += 1;
                            if (biasCount >= 2)
                            {
                                judgeNum = judgeNum + 10 * biasCount;
                            }
                        }
                        else
                        {
                            judgeNum = 50;
                            biasCount = 0;
                        }
                    }
                    isObject = true;
                }

                Debug.Log("Game Start 2");
                if (isTimeOver == false)
                {
                    Debug.Log("Game Start 3");
                    times += Time.deltaTime;
                    total_times += Time.deltaTime;
                    if (isCountDown)
                    {
                        Debug.Log("Game Start 4");
                        //カウントダウン
                        displayTime = GameTime - times + increaseTimeCount - (decreaseTimeCount *3 ) ;
                        if (displayTime <= 0.0f)
                        {
                            displayTime = 0.0f;
                            isTimeOver = true;
                        }
                    }
                    else
                    {
                        //カウントアップ
                        displayTime = times + increaseTimeCount - (decreaseTimeCount * 3);
                        if (displayTime >= GameTime)
                        {
                            displayTime = GameTime;
                            isTimeOver = true;
                        }
                    }
                    Debug.Log("Times : " + displayTime);
                    ShowTimeText.text = "Time : "+ Math.Floor(displayTime).ToString();
                }

                if (isTimeOver == true)
                {
                    GameEndFlag = true;
                    gameStartFlag = false;
                    if (wordObject != null)
                    {
                        Destroy(wordObject);
                    }
                }
            }

            if (GameEndFlag == true)
            {
                // アニメーション開始
                //EndGameObject.SetActive(true);
                //EndGameObject.GetComponent<Animator>().enabled = true;
                //EndGameObject.GetComponent<Animator>().Play("GameEnd", 0, 0);
                Invoke("EndGame", 0.5f);
            }
        }
        else if(GameFlag == 3){
            //ゲーム終了
            EndGameObject.SetActive(true);
            EndGameObject.GetComponent<Animator>().enabled = true;
            EndGameObject.GetComponent<Animator>().Play("GameEnd", 0, 0);
            Invoke("EndGame", 1.0f);
            if (Input.GetMouseButtonDown(0))
            {
                StaticGameLevel.GamePlayTime = total_times;
                SceneManager.LoadScene("ResultScene");
            }
        }
        
    }

    void StartGame()
    {
        GameFlag = 2;
        StartGameObject.SetActive(false);
    }

    void EndGame()
    {
        GameFlag = 3;
        StartMessageCanvas.SetActive(true);
        EndGameMessage.text = "Click To Result";
    }
}
