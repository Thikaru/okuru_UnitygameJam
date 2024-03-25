using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectAppearToDelete : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    [SerializeField] private TextMeshProUGUI timeText;
    public float fadeTime = 0.5f;
    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeleteObject", fadeTime);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        this.transform.localPosition += velocity * Time.deltaTime;
        timeText.color = new Color(timeText.color.r, timeText.color.g, timeText.color.b, 1 - (time / fadeTime));
    }

    void DeleteObject()
    {
        Destroy(gameObject);
    }
}
