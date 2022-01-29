using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(int buttonNumber)
    {
        int damage = 0;
        switch (buttonNumber)
        {
            case 1:
                damage = Random.Range(100, 500);
                Debug.Log("攻撃1!!!");
                break;
            case 2:
                damage = Random.Range(100, 250);
                Debug.Log("攻撃2!!!");
                break;
            case 3:
                damage = Random.Range(300, 400);
                Debug.Log("攻撃3!!!");
                break;
            default:
                Debug.Log("引数が渡されてない");
                break;
        }
    }
}
