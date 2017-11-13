using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;//mp(発展課題追記）
    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }


    //(発展課題追記）Magic関数
    public void Magic(int mag)
    {
        mp -= 5;
        if (mp > 0)
        {
            Debug.Log("魔法攻撃をした。残りＭＰは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
     

    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        //（課題追記）要素の個数が5の、int型の配列arrayを宣言初期化
        int[] array = { 1, 2, 3, 4, 5 };

        //(課題追記）配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //(課題追記）for文を使い、配列の各要素の値を逆順に表示

        for (int j = 4; j >= 0; j--)

        {
            Debug.Log(array[j]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //（発展課題追記）Magicの関数を呼び出す
        for(int i = 0; i < 11; i++) { lastboss.Magic(5); }

      


    }

    // Update is called once per frame
    void Update()
    {

    }

}