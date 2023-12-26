using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustGameScene : MonoBehaviour
{
    float scaleChangeRate = 1.0f;
    float scaleWidthRate = 1.0f;
    float scaleHeightRate = 1.0f;
    float width;
    float height;
    float defaultWidth = 1920.0f;
    float defaultHeight = 1080.0f;

    //サイズのスケールを変更するオブジェクト
    public GameObject MainCanvasBackButton;
    public GameObject GameTime;
    public GameObject BackGroundImage;
    public GameObject BackButton;
    public GameObject GameStartAnime;
    public GameObject GameEndAnime;
    public GameObject StartPanel;
    public GameObject StartMessage;
    public GameObject StartMessageCanvasBackButton;
    public GameObject BackButtonBackButton;

    void Awake()
    {
        width = Screen.width;
        height = Screen.height;

        scaleWidthRate = width / defaultWidth;
        scaleHeightRate = height / defaultHeight;
        if (scaleWidthRate <= scaleHeightRate)
        {
            scaleChangeRate = scaleWidthRate;
        }
        else
        {
            scaleChangeRate = scaleHeightRate;
        }

        Vector3 localobjectscale = MainCanvasBackButton.transform.localScale;
        MainCanvasBackButton.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = GameTime.transform.localScale;
        GameTime.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = BackGroundImage.transform.localScale;
        BackGroundImage.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = BackButton.transform.localScale;
        BackButton.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        //localobjectscale = GameStartAnime.transform.localScale;
        //GameStartAnime.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        //localobjectscale = GameEndAnime.transform.localScale;
        //GameEndAnime.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = StartPanel.transform.localScale;
        StartPanel.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = StartMessage.transform.localScale;
        StartMessage.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = StartMessageCanvasBackButton.transform.localScale;
        StartMessageCanvasBackButton.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = BackButtonBackButton.transform.localScale;
        BackButtonBackButton.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);

        Vector3 positionMenuPanel = StartMessage.transform.position;
        StartMessage.transform.position = new Vector3(positionMenuPanel.x * scaleChangeRate, positionMenuPanel.y * scaleChangeRate, positionMenuPanel.z * scaleChangeRate);
         positionMenuPanel = GameTime.transform.position;
        GameTime.transform.position = new Vector3(positionMenuPanel.x * scaleChangeRate, positionMenuPanel.y * scaleChangeRate, positionMenuPanel.z * scaleChangeRate);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
