using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    [SerializeField]
    TextMeshProUGUI killcounter;
    public int counter;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }


    public void UpdatekillCounter()
    {
        killcounter.text = counter.ToString();
    }



}
