using UnityEngine;

public class LearmMethodStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A��k
        // �I�s�R�A��k�y�k:
        // ���O�W��.�R�A��k�W��(�������޼�)
        float r = Random.Range(3.5f, 7.5f);
        print("�H���d�� 3.5 ~ 7.5 : " + r);
        // ���h�� Declaration �N����k���h����k:�h�ةI�s�覡
        int rInt = Random.Range(1, 3);    // 1�B2
        print("�H����� 1~ 2: " + rInt);
    }
    private void Update()
    {
        bool space = Input.GetKeyDown(KeyCode.Space);
        print("���a�O�_���ť��� : " + space);
    }
}
