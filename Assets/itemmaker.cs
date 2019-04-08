using UnityEngine;
using System.Collections;

public class itemmaker : MonoBehaviour
{   private GameObject unitychan;
    private GameObject gameobject;
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = -160;
    //ゴール地点
    private int goalPos = 120;
    //アイテムを出すx方向の範囲e
    private int interval = 30;
   //private int a;
    private float posRange = 3.4f;
    private int[] basho;
    private int kosuu;
    private int q;

    void Set(int a)
    {
           int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, basho[a]);
                }

            }
            else
            {
                int j = Random.Range(-1, 2);
                //アイテムの種類を決める
                int item = Random.Range(1, 11);
                //アイテムを置くZ座標のオフセットをランダムに設定
                int offsetZ = Random.Range(-5, 6);
                                 //60%コイン配置:30%車配置:10%何もなし
                if (1 <= item && item <= 6)
                {
                    //コインを生成
                    GameObject coin = Instantiate(coinPrefab) as GameObject;
                    coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, basho[a] + offsetZ);
                    
                }
                else if (7 <= item && item < 9)
                {
                    //車を生成
                    GameObject car = Instantiate(carPrefab) as GameObject;
                    car.transform.position = new Vector3(posRange * j, car.transform.position.y, basho[a] + offsetZ);
                    
                }

                //   }

            }//else@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        
       
    }

    // Use this for initialization
    void Start()
    {
       
        this.unitychan = GameObject.Find("unitychan");

        kosuu = (goalPos - startPos) / interval;
        basho = new int[kosuu];
        int i = startPos;
        for (int yy = 0; yy < basho.Length; yy += 1)
        {
            i += interval;

            basho[yy] = i;


        }
        //どのアイテムを出すのかをランダムに設定@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

    }//start
    int b = 0;
    // Update is called once per frame
    void Update()
    {

        this.unitychan = GameObject.Find("unitychan");
        if (goalPos > unitychan.transform.position.z && unitychan.transform.position.z + 50 > basho[b] )
            {
            Set(b);
            Set(b);
            b++;
            }
           
        

    }//UPDATE
}