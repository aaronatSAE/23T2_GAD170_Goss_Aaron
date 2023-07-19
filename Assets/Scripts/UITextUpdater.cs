using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITextUpdater : MonoBehaviour
{
    // When this button is clicked,
    // update the game text object!
    // We need a reference to our text object!
    [SerializeField] private string message;
    [SerializeField] private TextMeshProUGUI messageLabel;

    public void UpdateText()
    {
        //messageLabel.text = messageLabel.text + "Whatever you have on the... yep! Also: " + message;
        // ^ This is the same as:
        //messageLabel.text += "Whatever you have on the... yep! Also: " + message;
        messageLabel.text += "\tHi! " + message;
    }
}
