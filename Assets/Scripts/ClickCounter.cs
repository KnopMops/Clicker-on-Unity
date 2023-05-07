using UnityEngine;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour
{
    public static int money;
    public static int rate = 1;

    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        rate = PlayerPrefs.GetInt("rate", 1);
    }

    public void Click() 
    {
        money += rate;
        PlayerPrefs.SetInt("money", money);
    }

    public void UpgradeClick()
    {
        if (money >= 100)
        {
            money -= 15;
            PlayerPrefs.SetInt("money", money);
            rate += 1;
            PlayerPrefs.SetInt("rate", rate);   
        }
    }

    private void Update()
    {
        moneyText.text = "$" + money;
    }
}
