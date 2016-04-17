using UnityEngine;
using System.Collections;

public class ResolutionManager : MonoBehaviour 
{
    public int bgWidthToLaod = 800;

    float xWidth;
    float yHeight;

    void Awake()
    {
        xWidth = Screen.width;
        yHeight = Screen.height;

        float aspectRatio = xWidth / yHeight;

        if(aspectRatio >= 1.30f && aspectRatio <= 1.35f)
        {
            // 2048 * 1536
            aspectRatio = 1.33f;
            bgWidthToLaod = 2048;
        }
        else if(aspectRatio >= 1.45f && aspectRatio <= 1.55f)
        {
            // 960 * 640
            aspectRatio = 1.5f;
            bgWidthToLaod = 960;
        }
        else if(aspectRatio >= 1.58f && aspectRatio <= 1.70f)
        {
            // 1280 * 768
            aspectRatio = 1.67f;
            bgWidthToLaod = 1280;
        }
        else if(aspectRatio >= 1.75f && aspectRatio <= 1.80f)
        {
            // 1136 * 640
            aspectRatio = 1.78f;
            bgWidthToLaod = 1136;
        }
        else
        {
            aspectRatio = 1.67f;
            bgWidthToLaod = 1280;
        }
    }

    void Start()
    {

    }
}