using UnityEngine;
using UnityEngine.UI;

public class StringData : MonoBehaviour
{
    public string words;

    public void WriteWords(string write)
    {
        words = write;
    }

    public void DisplayWords(Text txt)
    {
        txt.text = words;
    }
}
