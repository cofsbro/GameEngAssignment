using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int counter;
    public TextMeshProUGUI score;
    public string numb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        numb = score.text;
        counter = int.Parse(numb);

        if ((counter >= 15))
        {
            SceneManager.LoadScene(sceneName: "Leve2");
        }

    }
}
