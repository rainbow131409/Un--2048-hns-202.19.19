using UnityEngine;

/// <summary>
/// summary �K�n
/// ��ƻ����A��ܦb vs �sĶ�����ܤW
/// </summary>
public class LearnMethod : MonoBehaviour
{
    // ��k Method�BFunction (�禡)
    // �@��:������������{�����e
    // �y�k:
    // �׹��� �Ǧ^������� ��k�W�� (�Ѽ�) { �{�����e }
    // �L�Ǧ^ void
    // �R�W�ߺD : Unity ��k�H�j�g�}�Y
    // �ۭq��k : ���|����
    public void Test ()
    {
        print("�ڬO���դ�k~");
    }

    private void Start()
    {
        // �I�s��k
        // ��k�W��();
        Test();
        Test();
        Drive90();
        Drive150();
        // �I�s��k : �޼�
        Drive(70);
        Drive(200);
    }

    // �����ݨD
    // ���񭵮�
    // �T���i�H�[�t�A�ɳt�� 90
    // �T���i�H�[�t�A�ɳt�� 150
    public void Drive90()
    {
        print("�}���A�ɳt:" + 90);
        print("����");
    }

    public void Drive150()
    {
        print("�}���A�ɳt:" + 150);
        print("����");
    }

    // �w�q��k
    // �Ѽ� : ������� �ѼƦW��
   public void Drive(int speed)
    {
        print("�}���A�ɳt:" + speed);
        print("����");
    }
}
