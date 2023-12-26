using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustResultScene : MonoBehaviour
{
    float scaleChangeRate = 1.0f;
    float scaleWidthRate = 1.0f;
    float scaleHeightRate = 1.0f;
    float width;
    float height;
    float defaultWidth = 1920.0f;
    float defaultHeight = 1080.0f;

    //サイズのスケールを変更するオブジェクト
    public GameObject BackGroundImage;
    public GameObject ResultMessage;
    public GameObject HintMessage;
    public GameObject ResultGameTime;
    public GameObject ClickMessage;

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


        Vector3 localobjectscale = BackGroundImage.transform.localScale;
        BackGroundImage.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = ResultMessage.transform.localScale;
        ResultMessage.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = HintMessage.transform.localScale;
        HintMessage.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = ResultGameTime.transform.localScale;
        ResultGameTime.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);
        localobjectscale = ClickMessage.transform.localScale;
        ClickMessage.transform.localScale = new Vector3(localobjectscale.x * scaleChangeRate, localobjectscale.y * scaleChangeRate, localobjectscale.z * scaleChangeRate);

        Vector3 positionMenuPanel = ClickMessage.transform.position;
        ClickMessage.transform.position = new Vector3(positionMenuPanel.x * scaleChangeRate, positionMenuPanel.y * scaleChangeRate, positionMenuPanel.z * scaleChangeRate);
        positionMenuPanel = HintMessage.transform.position;
        HintMessage.transform.position = new Vector3(positionMenuPanel.x * scaleChangeRate, positionMenuPanel.y * scaleChangeRate, positionMenuPanel.z * scaleChangeRate);
        positionMenuPanel = ResultMessage.transform.position;
        ResultMessage.transform.position = new Vector3(positionMenuPanel.x * scaleChangeRate, positionMenuPanel.y * scaleChangeRate, positionMenuPanel.z * scaleChangeRate);
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
