namespace DeliveryDriver
{
    using UnityEngine;
    
    public class PlayerController : MonoBehaviour
    {
        [Header("Player Settings")]
        [SerializeField] private float _moveSpeed     = 50f;
        [SerializeField] private float _rotationSpeed = 500f;

        private void Update()
        {
            float rotationInput = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
            float moveInput     = Input.GetAxis("Vertical")   * _moveSpeed     * Time.deltaTime;
            
            transform.Rotate(0f, 0f, -rotationInput);
            transform.Translate(0f, moveInput, 0f);
        }
    }
}