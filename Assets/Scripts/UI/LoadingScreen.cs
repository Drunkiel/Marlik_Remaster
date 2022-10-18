using System.Collections;
using UnityEngine;
using TMPro;

public class LoadingScreen : MonoBehaviour
{
    public OpenCloseUI _uiController;

    public IEnumerator StartLoading(string reason)
    {
        _uiController.OpenClose();
        _uiController.main.transform.GetChild(1).GetComponent<TMP_Text>().text = reason;

        yield return new WaitForSeconds(2f);

        _uiController.OpenClose();
    }
}
