using UnityEngine;

public class LearmArray : MonoBehaviour
{
    // 5個學生的分數
    public int score1 = 100;
    public int score2 = 10;
    public int score3 = 80;
    public int score4 = 70;
    public int score5 = 65;

    // 資料類型[] - 列陣資料類型
    // 列陣: 儲存相同資料類型
    public int[] score;
    // 定義一個包含數量的陣列
    public float[] attacks = new float[3];
    // 定義一個包含值的陣列
    public string[] props = { " 紅水, 藍水, 蘋果 " };
    private void Start()
    {
        score3 = 60;

        // 存取陣列資料
        // 取得陣列資料
        // 語法: 陣列名稱[編號] - 編號聰零開始
        print("第三個道具:" + props[2]);
        // print("第三個道具:" + props[3]); // OutOfRange 超出範圍錯誤
        // 設定陣列資料
        // 語法: 陣列名稱[編號] 指定 值
        props[0] = "黃水";

        // 陣列數量 Length
        print("道具數量:" + props.Length);

        // 利用迴圈設定陣列值: 10 ~ 50
        for (int i = 0; i < score.Length; i++)
        {
            score[i] = i * 10 + 10;
        }
    }



}
