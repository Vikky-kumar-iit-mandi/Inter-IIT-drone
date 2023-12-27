using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class click_detection1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public float z;
    public LayerMask mask;
    GameObject canvas;
    public int n;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            GameObject parent = GetClickedGameObject();
            if (parent != null)
            {
                Debug.Log("mil gaya");
                Debug.Log(parent.name);
                /*canvas = transform.GetChild(n).gameObject;
                Debug.Log(canvas.name);
                canvas.SetActive(true);*/
                if (parent.CompareTag("upgrade"))
                {
                    canvas = parent.transform.GetChild(0).gameObject;
                    Debug.Log(canvas.name);
                    canvas.SetActive(true);
                }

            }
        }
        GameObject GetClickedGameObject()
        {
            // Builds a ray from camera point of view to the mouse position 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit 
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
            {

                return hit.transform.gameObject;
            }
            else
                return null;
        }
    }
}