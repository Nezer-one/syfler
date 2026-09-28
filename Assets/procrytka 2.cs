using UnityEngine;
using TMPro;
using System.Collections;

public class procrytka2 : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text text;
    public TMP_InputField iF;
    public TMP_InputField iF2;
    public TMP_InputField iF3;
    public float scs;  //скорость прокрутки текста
    public float sD = 1f; //задержка перед началом прокрутки
    public int Size; //размер шрифта
    Coroutine sC;
    Vector2 sp;//начальная позиция текста

    void Start()
    {
        panel.SetActive(false);
        sp = text.rectTransform.anchoredPosition;
    }

    public void panelOpen()
    {
        text.text = iF.text;
        scs = float.Parse(iF2.text);
        Size = int.Parse(iF3.text);
        text.fontSize = Size;
        panel.SetActive(true);


        sC = StartCoroutine(MoveText());
    }

    IEnumerator MoveText()
    {
        yield return new WaitForSeconds(sD);

        while (true)
        {
            text.rectTransform.anchoredPosition += Vector2.up * scs * Time.deltaTime;
            yield return null;
        }
    }

    public void panelClose()
    {
        StopCoroutine(sC);
        text.rectTransform.anchoredPosition = sp;
        panel.SetActive(false);

    }
}
