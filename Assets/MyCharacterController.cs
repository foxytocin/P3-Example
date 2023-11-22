using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class MyCharacterController : MonoBehaviour
{
    public XRRayInteractor leftTeleportRay;
    public InputActionReference teleportActivationButton;

    private void OnEnable()
    {
        teleportActivationButton.action.started += OnTeleportActivationButtonPressed;
        teleportActivationButton.action.canceled += OnTeleportActivationButtonReleased;
    }
    
    private void OnDestroy()
    {
        teleportActivationButton.action.performed -= OnTeleportActivationButtonPressed;
        teleportActivationButton.action.canceled -= OnTeleportActivationButtonReleased;
    }
    
    private void OnTeleportActivationButtonPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Teleport button pressed");
        leftTeleportRay.enabled = true;
    }
    
    private void OnTeleportActivationButtonReleased(InputAction.CallbackContext obj)
    {
        Debug.Log("Teleport button released");
        leftTeleportRay.enabled = false;
    }
}
