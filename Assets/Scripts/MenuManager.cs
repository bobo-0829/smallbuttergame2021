using UnityEngine;
using UnityEngine.Audio;// �ޥ� ���� �R�W�Ŷ�
using UnityEngine.SceneManagement;//�ޥ� �����޲z �R�W�Ŷ�

/// <summary>
/// �}�l�e�����޲z��
/// �}�l�C�� �]�w ���}�C��
/// </summary>
/// �~�����O�N�i�H�s���䦨�� :���B�ݩʡB��k
public class MenuManager : MonoBehaviour
{
    // unity ���s�P�{�����q
    // 1.���}����k
    // 2.���s�]�w�I���ƥ� on click

    public AudioMixer mixer;

    ///<summary>
    /// �}�l�C��
    /// </summary>
    public void StartGame(float delay)
    {
        // �ϥ��~�����O�������y�k :
        // �~�����O��k
        // ��k�W��(�������޼�)
        // ���� delay ���I�s ��k
        Invoke("DelayStartGame", delay);
    }
    private void DelayStartGame()
    {
        // �����޲z.���J����(�����W��)
        SceneManager.LoadScene("�Τ�");//���J�C������
        //SceneManager.LoadScene(1);
    }

    ///<summary>
    /// �]�w�C��
    /// </summary>
    public void SettingGameBGM(float volume)
    {
        print("BGM �Ʊ쭵�q"+volume);
        mixer.SetFloat("���qBGM", volume);

    }
    public void SettingGameSFX(float volume)
    {
        print("SFX �Ʊ쭵�q" + volume);
        mixer.SetFloat("����SFX", volume);

    }
    public void SettingGame(float delay)
    {
        Invoke("DelaySettingGame", delay);
    }


    ///<summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame(float delay)
    {
        Invoke("DelayQuitGame", delay);
    }
    private void DalayQuitGame()
    {
        // ���ε{��.���}();
        // Quit ���|�A Editor ����A�o�������� ����BPC
        Application.Quit();

        print("���}�C��~");

    }
}
