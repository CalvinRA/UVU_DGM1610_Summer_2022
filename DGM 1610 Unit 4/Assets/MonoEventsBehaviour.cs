using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
