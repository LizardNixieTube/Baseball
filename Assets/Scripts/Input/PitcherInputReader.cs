using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PitcherInputReader", menuName = "InputReader/Pitcher", order = 1)]
public class PitcherInputReader : ScriptableObject, GameInput.IPitcherActions
{
    public event UnityAction<Vector2> MoveActions;      //Moving cursor (while pitcher is throwing)
    public event UnityAction<Vector2> SelectActions;    //Selecting input
    public event UnityAction          ConfirmActions;   //Confirm (start throwing)

    GameInput gameInput;

    void OnEnable()
    {
        if (gameInput == null)
        {
            gameInput = new GameInput();
            gameInput.Pitcher.SetCallbacks(this);
        }
        gameInput.Pitcher.Enable();
    }

    void OnDisable()
    {
        gameInput.Pitcher.Disable();
    }

    public void OnSelect(InputAction.CallbackContext context)
    {
        if (SelectActions != null && context.performed)
        {
            SelectActions.Invoke(context.ReadValue<Vector2>());
        }
    }

    public void OnConfirm(InputAction.CallbackContext context)
    {
        if (ConfirmActions != null && context.performed)
        {
            ConfirmActions.Invoke();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (MoveActions != null)
        {
            MoveActions.Invoke(context.ReadValue<Vector2>());
        }
    }
}
