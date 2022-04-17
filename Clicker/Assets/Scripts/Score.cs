using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private int _money;
    [SerializeField] private Text MoneyText;
    [SerializeField] private GameObject Shop;
    [SerializeField] private GameObject FirstButton, SecondButton, ThirdButton;
    
    
    private int _moneyUp  = 1;

    private bool _check = true;

    public void Start()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            _money = PlayerPrefs.GetInt("Money");
        }

    }


    void Update()
    {
        
        MoneyText.text = _money + "Ð";
    }


    public void OnMainButtonDowm()
    {
        _money += _moneyUp;
        

    }

    public void OnShopButtonDown()
    {
        if (_check == true)
        {
            Shop.SetActive(true);
            _check = false;
            PlayerPrefs.SetInt("Money", _money);
        }

        else 
        {
            Shop.SetActive(false);
            _check = true;
            PlayerPrefs.SetInt("Money", _money);
        }
    }
    public void OnBuyButton1Down()
    {
        if (_money >= 100)
        {
            _moneyUp = 1;
            _moneyUp *= 2;
            _money -= 100;
            PlayerPrefs.SetInt("Money", _money);
            Destroy(FirstButton);
        }
        
        
    }
    public void OnBuyButton2Down()
    {
        if (_money >= 300)
        {

            _moneyUp = 1;
            _moneyUp *= 3;
            _money -= 300;
            PlayerPrefs.SetInt("Money", _money);
            Destroy(SecondButton);
        }
        
        
    }
    public void OnBuyButton3Down()
    {
        if (_money >= 600)
        {
            _moneyUp = 1;
            _moneyUp *= 4;
            _money -= 600;
            PlayerPrefs.SetInt("Money", _money);
            Destroy(ThirdButton);
        }
        
        
    }


}
