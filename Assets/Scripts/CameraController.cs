using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeliveryDriver
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Vector3 _cameraOffset;
        [SerializeField] private GameObject _cameraTarget;
        
        private void LateUpdate()
        {
            transform.position = _cameraTarget.transform.position + _cameraOffset;
        }
    }
}
