using UnityEngine;
using UnityEngine.Audio;            // �ޥ�
using UnityEngine.SceneManagement;  // �ޥ� �����޲z �R�W�Ŷ�

/// <summary>
/// �}�l�e�����޲z��
/// �}�l�e���B�]�w�B���}�C��
/// </summary>
public class MenuManager : MonoBehaviour
{
    // Unity ���s�P�{�����q
    // 1. ���}��k
    // 2. ���s�]�w�I���ƥ� On Click

    public AudioMixer mixer;

    /// <summary>
    /// �}�l�C��
    /// </summary>
    public void StartGame() 
    {
        // �����޲z.���J����(�����W��)
        SceneManager.LoadScene("�C������");
    }

    /// <summary>
    /// �C���]�w
    /// </summary>
    public void SettingGameBGM(float volume) 
    {
        mixer.SetFloat("���qBGM", volume);
    }

    /// <summary>
    /// �C���]�w
    /// </summary>
    public void SettingGameSFX(float volume)
    {
        mixer.SetFloat("����SFX", volume);
    }

    /// <summary>
    /// �����C��
    /// </summary>
    public void QuitGame() 
    {
        // ���ε{��.���}();
        // Quit ���|�A Editor ����A�o�������� ����BPC
        Application.Quit();

        print("���}�C��");
    }
}
