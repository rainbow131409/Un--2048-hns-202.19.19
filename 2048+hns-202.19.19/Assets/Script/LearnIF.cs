using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool openDoor;
    private void Start()
    {
        // �P�_�� if
        // �y�k
        // �p�G (���L��) { ���L�� ���� true �|���� �{�����e }
        // �_�h (���L�� ���� false �|���� �{�����e
        if (true)
        {
            print("���L�� true");
        }

        // openDoor == true �P openDoor
        if (openDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }
    }
}
