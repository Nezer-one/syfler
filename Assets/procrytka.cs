using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextScrollController : MonoBehaviour
{
    public ScrollRect sr;

    void Start()
    {
        sr.verticalNormalizedPosition = 1f;   
    }

    public void Vernyt()
    {
        sr.verticalNormalizedPosition = 1f;
    }

    
}