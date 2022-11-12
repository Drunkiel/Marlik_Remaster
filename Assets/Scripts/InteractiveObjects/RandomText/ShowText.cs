using UnityEngine;
using TMPro;

public class ShowText : MonoBehaviour
{
    public TMP_Text showingText;
    public Texts texts;

    void Start()
    {
        DisplayRandomText();
    }

    public void DisplayRandomText()
    {
        string textToShow = texts.PickText();
        showingText.text = textToShow;
    }
}
