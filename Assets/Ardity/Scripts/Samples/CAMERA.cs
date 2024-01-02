using UnityEngine;

public class InitializeCameraPosition : MonoBehaviour
{
    // 在这里设置你想要的初始位置和旋转
    public Vector3 startPosition = new Vector3(-7.58f, -0.34f, 4.59f);
    public Vector3 startRotation = new Vector3(15f, 90f, 0f);

    void Start()
    {
        // 设置相机的初始位置和旋转
        transform.position = startPosition;
        transform.eulerAngles = startRotation;
    }
}
