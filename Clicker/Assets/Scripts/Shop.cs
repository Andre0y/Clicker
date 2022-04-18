using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    
    public void ShopButtonDown()
    {
        GameManager.Instance.OnShopButton();
    }
    public void ShopBuyButton1()
    {
        GameManager.Instance.OnBuyButton1Down();
        
    }
    public void ShopBuyButton2()
    {
        GameManager.Instance.OnBuyButton2Down();
    }
    public void ShopBuyButton3()
    {
        GameManager.Instance.OnBuyButton3Down();
    }
}
