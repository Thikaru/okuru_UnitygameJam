using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustTrueStoryScene : MonoBehaviour
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
    public GameObject ShowText;
    public GameObject ToBeContinuedText;

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
