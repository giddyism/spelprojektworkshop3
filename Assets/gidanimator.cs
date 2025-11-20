using UnityEngine;

public class gidanimator : MonoBehaviour
{
    Animator knightanimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        knightanimator = GetComponent<Animator>();

        knightanimator.SetBool("IsRunning", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d") || Input.GetKeyDown("a"))
        {
            knightanimator.SetBool("IsRunning", true);
        }

        if (Input.GetKeyUp("d") || Input.GetKeyDown("a"))
        {
            knightanimator.SetBool("IsRunning", false);
        }
    }
}
