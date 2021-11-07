using UnityEngine;

public class LearmOop : MonoBehaviour
{
    private void Start()
    {
        // 块计 1~5
        print("计:" + 1);
        print("计:" + 2);
        print("计:" + 3);
        print("计:" + 4);
        print("计:" + 5);

        // 癹伴:狡磅︽
        // while 癹伴粂猭:
        // while (ガ狶) { 讽ガ狶 单 ture 穦磅︽ 尿ガ狶 false 祘Αず甧
        int number = 1;

        while (number < 6)
        {
            print("while 癹伴计:" + number);
            number++;
        }

        // for (﹍;)
        for (int x = 1; x < 6; x++)
        {
            print("癹伴计:" + x);
        }
    }
}
