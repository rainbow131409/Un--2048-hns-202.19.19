using UnityEngine;

public class LearmOop : MonoBehaviour
{
    private void Start()
    {
        // ��X�Ʀr 1~5
        print("�Ʀr:" + 1);
        print("�Ʀr:" + 2);
        print("�Ʀr:" + 3);
        print("�Ʀr:" + 4);
        print("�Ʀr:" + 5);

        // �j��:���ư���
        // while �j��y�k:
        // while (���L��) { ���L�� ���� ture �|���� ���򪽨쥬�L�Ȭ� false �{�����e
        int number = 1;

        while (number < 6)
        {
            print("while �j��Ʀr:" + number);
            number++;
        }

        // for (��l��;)
        for (int x = 1; x < 6; x++)
        {
            print("�j��Ʀr:" + x);
        }
    }
}
