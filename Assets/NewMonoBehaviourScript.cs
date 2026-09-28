using UnityEngine;
using TMPro;

public class srift : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text text;

    public void ChangeSize(string size)
    {
        if (float.TryParse(inputField.text, out float number))
        {
            text.fontSize = number;
        }
    }
}