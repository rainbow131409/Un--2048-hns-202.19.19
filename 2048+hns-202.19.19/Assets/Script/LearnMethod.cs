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
        // ���w�]�Ȫ��Ѽƥi�H����g�A�ϥιw�]��
        Drive(70, "������");
        Drive(200,"�F�F�F");
        Drive(300);
        // �ɳt 50�A�w�]���ġA���Y
        // ���w�w�]�ȰѼƻy�k �ѼƦW�� �긹 ��
        Drive(50, effect: "���Y");

        int t = Ten();
        print("�Ǧ^��k��:" + t);

        print("���ϥ��ܼ��x�s�Ǧ^��:" + Ten());

        int damage = Damage(90, 30);
        print("90 �����O�P 30 ���m�O���ˮ`:" + damage);
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
    // �Ѽ� : ������� �ѼƦW�� (���w �w�]��)
    // �Ѽ�1�A�Ѽ�2�A......�A�Ѽ�N
   public void Drive(int speed, string sound = "������", string effect = "�ǹ�")
    {
        print("�}���A�ɳt:" + speed);
        print("���� : " + sound);
        print("�S��:" + effect);
    }

    // ���Ǧ^������k�����ϥ� return
    public int Ten()
    {
        return 10;
    }

    // �D���n���ܭ��n!
    // 90 - 30 = 60
    /// <summary>
    /// �p��ˮ`�ȡA�����O - ���m�O = �ˮ`��
    /// </summary>
    /// <param name="attack"></param>
    /// <param name="defence"></param>
    /// <returns></returns>
    public int Damage(int attack, int defence)
    {
        return attack - defence;
    }
}
