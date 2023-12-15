using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public int capsuleNumber = 3; // The variable to display
    public TMP_Text capsulesToKill; // The TextMeshPro object to display

    // Update is called once per frame
    void Update()
    {
        capsulesToKill.SetText("Kill the Capsules! Capsules remaining:  " + capsuleNumber);
        if (capsuleNumber == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void DecreaseCapsuleNumber()
    {
        capsuleNumber--;
    }


  

}

