using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private Button[] attackButton;
    [SerializeField] private int enemyHP = 1000;
    [SerializeField] private int playerHP = 1000;
    [SerializeField] private Slider enemyHPSlider;
    [SerializeField] private Slider playerHPSlider;
    int enemyCurrentHp;
    int playerCurrentHp;
    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHp = playerHP;
        enemyCurrentHp = enemyHP;
    }

    // Update is called once per frame
    void Update()
    {
        enemyHPSlider.value = (float)enemyCurrentHp / (float)enemyHP;
        playerHPSlider.value = (float)playerCurrentHp / (float)playerHP;

        if (enemyCurrentHp <= 0) {
            Debug.Log("Playerの勝ち！");
        } else if (playerCurrentHp <= 0) {
            Debug.Log("Playerの負け！");
        }
    }

    public void onAttack(int buttonNumber)
    {
        //SendMessage("Attack",buttonNumber);
        int attackPoint = Attack(buttonNumber);
        enemyCurrentHp -= attackPoint;
        Debug.Log("EnemyHP" + enemyHPSlider.value);
        invisibleButton();
        Invoke("Damage",2f);
    }

    public void invisibleButton() {
        for (int i = 0;i < attackButton.Length;i++) {
            attackButton[i].interactable = false;
        }
        Invoke("visibleButton", 4f);
    }

    public void visibleButton() {
        for (int i = 0; i < attackButton.Length; i++)
        {
            attackButton[i].interactable = true;
        }
    }

    int Attack(int buttonNumber)
    {
        int damage = 0;
        switch (buttonNumber)
        {
            case 1:
                damage = Random.Range(100, 200);
                Debug.Log("攻撃1!!!");
                return damage;
            case 2:
                damage = Random.Range(100, 250);
                Debug.Log("攻撃2!!!");
                return damage;
            case 3:
                damage = Random.Range(100, 150);
                Debug.Log("攻撃3!!!");
                return damage;
            default:
                Debug.Log("引数が渡されてない");
                return damage;
        }
    }
    void Damage() {
        int damage = Random.Range(100,200);
        playerCurrentHp -= damage;
        Debug.Log("PlayerHP" + playerHPSlider.value);
    }
}
