using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitArea : MonoBehaviour
{
    // Start is called before the first frame update
    public static float leftSide = -4.5f;
    public static float rightSide = 4.5f;
    public static float internalLeft;
    public static float internalRight;

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;

    }
}
