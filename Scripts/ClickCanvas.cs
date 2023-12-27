using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;

    public void click(GameObject canvas)
    {
        canvas.SetActive(true);
    }
}
