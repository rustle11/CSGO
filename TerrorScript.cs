using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TerrorScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MoneyText;
    [SerializeField] TextMeshProUGUI BulletText;
    public GameObject Image;
    static int Money = 0;
    static int Bullet = 30;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Bullet = Bullet - 1;
        BulletText.text = Bullet + "";
        Money = Money + 300;
        MoneyText.text = "$" + Money + "";
        Destroy(Image);
        Destroy(gameObject);
    }
}

