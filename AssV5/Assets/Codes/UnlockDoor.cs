using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UnlockDoor : MonoBehaviour
{
    
    public int counter;
    public Transform open;
    public TextMeshProUGUI score;
    public string numb;
    public bool once = true;


    private void Start()
    {
        

    }




    // Update is called once per frame
    void Update()
    {

        numb = score.text;
        counter = int.Parse(numb);

        if ((counter >= 10) && (once))
        {
            int randomdoor = Random.Range(1, 5);

            open = this.gameObject.transform.GetChild(randomdoor);
            open.GetComponent<Renderer>().material.color =
                    Color.HSVToRGB(Random.value, 1, 1);
            once = false;


        }

    }
}
