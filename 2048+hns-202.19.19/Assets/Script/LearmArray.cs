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

    private void Start()
    {
        score3 = 60;
    }
}
