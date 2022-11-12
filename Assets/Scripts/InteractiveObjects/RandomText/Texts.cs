using UnityEngine;

[System.Serializable]
public class Texts
{
    public string[] texts;

    public string PickText()
    {
        string pickedText = texts[Random.Range(0, texts.Length)];
        return pickedText;
    }
}
