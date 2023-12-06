using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fishCollection : MonoBehaviour
{
    private int totalFish = 0;

    public void collectFish(int i)
    {
        totalFish += i;
        Debug.Log(totalFish);
        if (totalFish == 7){
            Invoke("endGame", 2.5f);
        }
    }

    public int returnFish()
    {
        return totalFish;
    }

    private void endGame()
    {
        SceneManager.LoadScene("end");
    }
}
