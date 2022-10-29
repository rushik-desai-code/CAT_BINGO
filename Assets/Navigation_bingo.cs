using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation_bingo : MonoBehaviour
{
    // Start is called before the first frame update
    public void report_card_nav(int sceneID1)
    {
        SceneManager.LoadScene(sceneID1);
    }
    public void feed_nav(int sceneID1)
    {
        SceneManager.LoadScene(sceneID1);
    }
}
