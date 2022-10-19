using System.Collections;
using UnityEngine;
using TMPro;

public class DayController : MonoBehaviour
{
    public int daysSpend;
    public TMP_Text daysText;

    Animator anim;

    public PlayerStatsController _statsController;
    public LoadingScreen _loadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SkipDay()
    {
        _loadingScreen.StartCoroutine("StartLoading", "Pomijanie dnia");
        _statsController.Rest();
        daysSpend++;
        daysText.text = "Dzieñ: " + daysSpend.ToString();
        StartCoroutine("Tablet");
    }

    public IEnumerator Tablet()
    {
        anim.Play("Show");

        yield return new WaitForSeconds(4f);

        anim.Play("Hide");
    }
}
