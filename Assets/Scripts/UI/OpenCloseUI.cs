using UnityEngine;

[System.Serializable]
public class OpenCloseUI 
{
    public GameObject main;
    public bool isOpen;

    public void OpenClose()
    {
        isOpen = !isOpen;
        main.SetActive(isOpen);
    }
}
