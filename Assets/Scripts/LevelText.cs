using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelText : MonoBehaviour
{
    public TextMeshProUGUI displayLevel;
    private int count;
    private int currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        displayLevel.text = "";
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        count = currentLevel - 2;
        displayLevel.text = "Level  " + count;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Invoke("Blank", 2f);
    }

    void Blank()
    {
        displayLevel.text = "";
    }
}
