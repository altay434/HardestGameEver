using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setup()
    {
        gameObject.SetActive(true);
        
    }
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
