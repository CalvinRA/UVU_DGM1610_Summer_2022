using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLableBehaviour : MonoBehaviour
{
    private Text label;
    public UnityEvent startEvent;

    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdatLable(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLable(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
