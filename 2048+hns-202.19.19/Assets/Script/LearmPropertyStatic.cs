using UnityEngine;

public class LearmPropertyStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ� Static Property
        // ���o�R�A�ݩ�
        // �y�k: ���O�W��.�R�A�ݩʦW��
        print("�H����:" + Random.value);
        print("��v���`��:" + Camera.allCamerasCount);

        // �]�w�R�A�ݩ�
        // �y�k: ���O�W��.�R�A�ݩʦW�� ���w ��
        Cursor.visible = false;
        // Mathf.PI = 9.999999f;        // (Read Only) ����]�w �߿W�ݩ�
    }
}
