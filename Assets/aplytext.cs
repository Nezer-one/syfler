using UnityEngine;
using TMPro;
public class aplytext : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text text;

    public void Aplytext()
    {
        text.text = inputField.text;
    }
}
