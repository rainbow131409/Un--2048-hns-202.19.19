using UnityEngine;

/// <summary>
/// �P�_�� switch
/// </summary>
public class LearmSwitch : MonoBehaviour
{
    public string equipment;

    private void Start()
    {
        // switch�y�k:
        // switch (�n�P�_�����)
        // {
        //     case �� 1:
        //          �{�����e;
        //     brwak;
        // {
        //     case �� 2:
        //          �{�����e;
        //     brwak;
        //     default:                 // ���Ƥ��ŦX�W�� case 
        //          �{�����e;
        //     brwak;

        switch (equipment)
        {
            case "�M�l":
                print("�A�{�b���ۤM�l");
                break;
            case "�e�l":
                print("�A�{�b���ۤe�l");
                break;
            default:
                print("�A�����ڥ����O�Z�� =.=!");
                break;
        }
    }

}
