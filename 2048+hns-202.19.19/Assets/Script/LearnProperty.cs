using UnityEngine;

public class LearnProperty : MonoBehaviour
{
    // ���
    public int passwordField = 123456789;

    // �ݩ�
    // �y�k:
    // �׹��� ������� �ݩʦW�� { �s���l }
    // �۰ʹ�@
    public int passwordProperty { get; set; }
    // get ���o
    // set �]�w
    // �߿W�ݩ� �u����o
    // => �H�ڹF Lambda C# 6.0
    public int myPasswordProperty { get => 999; }

    // �߿W����g�k
    // get �ݨϥ�����r return �^��
    public string nameCharacter
    {
        get 
        {
            print("�ڦb�ݩ� name Character �̭�~");
            return "KID";
        }
    }
    // �߼g����g�k
    // set �ϥ�����r value ��J��
    public float attack
    {
        set 
        {
            print("�����O:" + value);
        }
    }

    // �}�l�ƥ� : ����ɰ���@��
    private void Start()
    {
        // �s�� Set �ݩʸ��
        // �y�k:
        // �ݩʦW�� ���w �� ;
        passwordProperty = 777;
        // ���o Get �ݩʸ��
        // �y�k :
        // �ݩʦW��
        print("�ݩʱK�X : " + passwordProperty);

        // myPasswordProperty = 999;    // ����]�w �߿W�ݩ�
        print("�ڪ��ݩʱK�X : " + myPasswordProperty);

        print(nameCharacter);

        // print(attack);              // ������o �߼g�ݩ�
        attack = 99.9f;
    }
}
