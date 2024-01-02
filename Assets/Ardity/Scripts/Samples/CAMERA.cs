using UnityEngine;

public class InitializeCameraPosition : MonoBehaviour
{
    // ��������������Ҫ�ĳ�ʼλ�ú���ת
    public Vector3 startPosition = new Vector3(-7.58f, -0.34f, 4.59f);
    public Vector3 startRotation = new Vector3(15f, 90f, 0f);

    void Start()
    {
        // ��������ĳ�ʼλ�ú���ת
        transform.position = startPosition;
        transform.eulerAngles = startRotation;
    }
}
