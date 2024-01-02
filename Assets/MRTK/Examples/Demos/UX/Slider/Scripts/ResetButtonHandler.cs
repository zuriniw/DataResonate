using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class ResetButtonHandler : MonoBehaviour
{
    public PinchSlider slider1; // 将第一个滑块赋值给这个变量
    public PinchSlider slider2; // 将第二个滑块赋值给这个变量

    // 这个函数将被绑定到按钮的点击事件
    public void ResetSliders()
    {
        slider1.SliderValue = 0.85f; // 将第一个滑块的值设置为0.85
        slider2.SliderValue = 0.88f; // 将第二个滑块的值设置为0.88
    }
}