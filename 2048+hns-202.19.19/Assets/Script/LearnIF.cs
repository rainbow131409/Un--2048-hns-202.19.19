using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool openDoor;
    public int score = 99;
    private void Start()
    {
        // 判斷式 if
        // 語法
        // 如果 (布林值) { 當布林值 等於 true 會執行 程式內容 }
        // 否則 (當布林值 等於 false 會執行 程式內容
        if (true)
        {
            print("布林值 true");
        }

        // openDoor == true 與 openDoor
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }

    private void Update()
    {
        // 如果分數 >= 60 分 及格
        if (score >= 60) 
        {
            print("及格");
        }

        //如果分數 >= 40 分  補考
        // 語法: else if (布林值) {布林值 為 ture 時執行}
        // else if 放在 if 下方與 else 上方，可以無限個 
        else if (score >= 40)
        {
            print("補考");
        }

        // 如果分數 <= 40   死當
        else
        {
            print("死當");
        }
    }



}
