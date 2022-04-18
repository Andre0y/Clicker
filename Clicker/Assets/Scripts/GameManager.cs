using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    [SerializeField] private int _money;
    [SerializeField] private Text _moneyText;
    [SerializeField] private GameObject _shop, _firstShopButton, _secondShopButton, _thirdShopButton;

    private int _moneyCount = 1;

    private bool _check = true;
    

    public static GameManager Instance;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        _money = PlayerPrefs.HasKey("Money") ? PlayerPrefs.GetInt("Money") : 0;
        _moneyCount = PlayerPrefs.HasKey("MoneyCount") ? PlayerPrefs.GetInt("MoneyCount") : 1;

        if (_moneyCount == 2)
        {
            Destroy(_firstShopButton);
        }
        if (_moneyCount == 3)
        {
            Destroy (_secondShopButton);
            
        }
        if (_moneyCount == 4)
        {
            Destroy(_thirdShopButton);
        }

        _moneyText.text = _money + "Ð";

        
    }

    private void Update()
    {
        _moneyText.text = _money + "Ð";
    }




    public void UpdateMoney()
    {
        _money += _moneyCount;
        PlayerPrefs.SetInt("Money", _money);
        
    }

    public void OnShopButton()
    {
        if (_check == true)
        {
            _shop.SetActive(true); 
            _check = false; 
        }
        else
        {
            _shop.SetActive(false);
            _check = true;  
        }
        
        


    }

    public void OnBuyButton1Down()
    {
        if (_money >= 100)
        {
            _moneyCount = 1;
            _money -= 100;
            _moneyCount *= 2;
            PlayerPrefs.SetInt("MoneyCount", _moneyCount);
            
            PlayerPrefs.SetInt("Money", _money);
            Destroy(_firstShopButton);
        }
        


    }
    public void OnBuyButton2Down()
    {
        if (_money >= 300)
        {

            _moneyCount = 1;
            _money -= 300;
            _moneyCount *= 3;
            PlayerPrefs.SetInt("MoneyCount", _moneyCount);

            PlayerPrefs.SetInt("Money", _money);
            Destroy(_secondShopButton);
        }
        


    }
    public void OnBuyButton3Down()
    {
        if (_money >= 600)
        {
            _moneyCount = 1;
            _money -= 600;
            _moneyCount *= 4;
            PlayerPrefs.SetInt("MoneyCount", _moneyCount);

            PlayerPrefs.SetInt("Money", _money);
            Destroy(_thirdShopButton);
        }
        


    }
}
