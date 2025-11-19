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
        if (Input.GetKeyDown("e") || (Input.GetKeyDown("d")))
        {
            knightanimator.SetBool("IsRunning", true);
        }

        if (Input.GetKeyUp("e") || (Input.GetKeyUp("d")))
        {
            knightanimator.SetBool("IsRunning", false);
        }
    }
}
