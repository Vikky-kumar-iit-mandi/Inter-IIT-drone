using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    // Start is called before the first frame update
    public int curr_capacity;
    public int curr_level;
    public int upgrade_cost;
    public int upgrade_capacity;
    public float wait_time;
    public AudioSource const_sound;
    public AudioSource final_sound;
    public GameObject canvas;
    public Wallet wallet;
    public Text amount;
    private void Update()
    {
        
    }
    public void some()
    {

        if (wallet.current_amount >= upgrade_cost)
        {
            StartCoroutine(upgrading());

            IEnumerator upgrading()
            {

                const_sound.Play();

                canvas.SetActive(false);
                yield return new WaitForSeconds(wait_time);
                const_sound.Stop();
                wallet.current_amount -= upgrade_cost;
                amount.text = wallet.current_amount.ToString();
                curr_capacity = upgrade_capacity;
                upgrade_capacity = upgrade_capacity + 100;
                curr_level = curr_level + 1;
                upgrade_cost = upgrade_cost + 50000;
                
                final_sound.Play();
                yield return new WaitForSeconds(1f);
                final_sound.Stop();


            }
        }
    }
}
