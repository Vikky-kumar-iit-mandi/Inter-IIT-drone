using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    // Start is called before the first frame update
    public int initialAmount;
    public int current_amount;
    void Start()
    {
        current_amount =  initialAmount;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
