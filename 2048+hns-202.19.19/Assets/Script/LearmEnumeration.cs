using UnityEngine;

/// <summary>
/// �C�|: �U�Ԧ����
/// </summary>
public class LearmEnumeration : MonoBehaviour
{
    // 1. �w�q�C�|
    // �y�k: �׹��� �C�|�W�� ���W�� (�C�|��1�A�C�|��2...�C�|��n)
    public enum stateEnemy
    {
        Idle,Walk,Track,Attack,Dead
    }
    // 2. �ϥΦC�|
    // �y�k: �׹��� �C�|�W�� ���W�� ���w ��;
    public stateEnemy state;

    private void Update()
    {
        switch (state)
        {
            case stateEnemy.Idle:
                print("���ݤ�");
                break;
            case stateEnemy.Walk:
                print("������");
                break;
            case stateEnemy.Track:
                print("�l�ܤ�");
                break;
            case stateEnemy.Attack:
                print("������");
                break;
            case stateEnemy.Dead:
                print("���`��");
                break;
        }
    }
}
