using UnityEngine;
using UnityEngine.Events;

public class Lab5Events : MonoBehaviour
{
    public UnityEvent swordDraw, swingSword, swordSheath;

    private void OnEnable()
    {
        swordDraw.Invoke();
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            swingSword.Invoke();
        }
    }

    private void OnDisable()
    {
        swordSheath.Invoke();
    }
}
