using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLableBehaviour : MonoBehaviour
{
    public Text label;
    public FloatData dataObj;

    private void Start()
    {
        label = GetComponent<Text>();
        UpdatLable();
    }

    public void UpdatLable()
    {
        label.text = dataObj.value.ToString();
    }
}
