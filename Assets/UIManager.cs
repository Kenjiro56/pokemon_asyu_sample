using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private Button[] attackButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onAttack(int buttonNumber)
    {
        //switch (buttonNumber)
        //{
        //    case 1:
        //        break;
        //    case 2:
        //        break;
        //    case 3:
        //        break;
        //    default:
        //        Debug.Log("引数が渡されてない");
        //        break;
        //}
        SendMessage("Attack",buttonNumber);
    }

    public void invisibleButton() {

    }

    public void visibleButton() {

    }
}
