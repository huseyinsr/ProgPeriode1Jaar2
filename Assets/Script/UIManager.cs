using System.Collections;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_Text introductionField;
    public TMP_Text messageField;

    void Start()
    {
        // Introduction gebruikt nu dezelfde ShowMessage functie
        ShowMessage("Welcome to Space 4 8. \n Move your ship with the arrows or WASD. \n Shoot with SPACE. \n Gather pickups and cycle with 'Left CTR'.  \n  Use pickups with 'E'.", 5f);
    }

    public void ShowMessage(string message, float displayTime = 3f)
    {
        StartCoroutine(DisplayMessage(message, displayTime));
    }

    private IEnumerator DisplayMessage(string message, float displayTime)
    {
        messageField.enabled = true;
        messageField.text = message;
        yield return new WaitForSeconds(displayTime);
        messageField.enabled = false;
    }
}