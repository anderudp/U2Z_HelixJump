using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TMP_Text levelText;
    public TMP_Text bestText;
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = $"Current Level: {PlayerController.level}";
        bestText.text = $"Best Level: {PlayerController.bestLevel}";
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = $"Current Level: {PlayerController.level}";
        bestText.text = $"Best Level: {PlayerController.bestLevel}";
    }
}
