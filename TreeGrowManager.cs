using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrowManager : MonoBehaviour
{

    public float maxSize;
    public float growRate;
    public float scale= 0.0f;
    public Color[] colorVariation; 
    // Start is called before the first frame update
    void Start()
    {
        maxSize = Random.Range(0.07f,0.085f);
        growRate = Random.Range(0.02f, 0.08f);

    }

    // Update is called once per frame
    void Update()
    {
        if (scale < maxSize)
        {
            this.transform.localScale = Vector3.one * scale;
            scale += growRate  *0.1f* Time.deltaTime;
        }
    }
}
