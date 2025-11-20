using UnityEngine;
using UnityEngine.Events;

public class OnEventStart : MonoBehaviour
{
    public UnityEvent onStart, onTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onStart.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        onTrigger.Invoke();
    }
}
