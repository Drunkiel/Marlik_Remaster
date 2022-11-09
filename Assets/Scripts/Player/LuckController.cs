using UnityEngine;
using TMPro;

public class LuckController : MonoBehaviour
{
    public static LuckController instance;

    public int todaysLuck;
    public Sprite[] luckStars;
    public TMP_Text luckText;

    public SpriteRenderer luckyImage;

    void Awake()
    {
        instance = this;
    }

    public void DrawLuck()
    {
        todaysLuck = Random.Range(0, 4);

        UpdateData();
    }

    void UpdateData()
    {
        switch (todaysLuck)
        {
            case 0:
                luckText.text = "Masz dzisiaj wielkiego pecha";
                break;

            case 1:
                luckText.text = "Masz dzisiaj pecha";
                break;

            case 2:
                luckText.text = "Dzisiaj wszystko zalezy od ciebie";
                break;

            case 3:
                luckText.text = "Masz dzisiaj szczesliwy dzien";
                break;

            case 4:
                luckText.text = "Masz dzisiaj niesamowite szczescie";
                break;
        }

        luckyImage.sprite = luckStars[todaysLuck];
    }
}
