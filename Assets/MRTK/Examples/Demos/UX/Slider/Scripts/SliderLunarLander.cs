using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [AddComponentMenu("Scripts/MRTK/Examples/CustomSliderHandler")]
    public class SliderLunarLander : MonoBehaviour
    {
        public GameObject object3dHeatmap; // Assign in inspector
        public GameObject objectV1; // Assign in inspector
        public GameObject objectV2; // Assign in inspector
        public GameObject objectV3; // Assign in inspector

        private void Start()
        {
            SetActiveObject(0.88f); // Set the initial active object
        }

        public void HandleSliderValueChanged(SliderEventData eventData)
        {
            SetActiveObject(eventData.NewValue);
        }

        private void SetActiveObject(float sliderValue)
        {
            // Deactivate all objects
            object3dHeatmap.SetActive(false);
            objectV1.SetActive(false);
            objectV2.SetActive(false);
            objectV3.SetActive(false);

            // Activate object based on slider value
            if (sliderValue >= 0.8f && sliderValue <= 1f)
            {
                object3dHeatmap.SetActive(true);
            }
            else if (sliderValue >= 0.6f && sliderValue < 0.8f)
            {
                objectV1.SetActive(true);
            }
            else if (sliderValue >= 0.4f && sliderValue < 0.6f)
            {
                objectV2.SetActive(true);
            }
            else if (sliderValue >= 0.2f && sliderValue < 0.4f)
            {
                objectV3.SetActive(true);
            }
        }
    }
}