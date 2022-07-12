using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Battter Input", menuName = "InputReader/Batter")]
public class BatterInputReader : ScriptableObject, GameInput.IBatterNRunnerActions
{
    public event UnityAction<Vector2>   MoveActions;
    public event UnityAction            SwingActions;
    public event UnityAction<bool>      BuntActions;

    private GameInput m_GameInput;

    public void OnEnable()
    {
        if(m_GameInput == null)
        {
            m_GameInput = new GameInput();
            m_GameInput.BatterNRunner.SetCallbacks(this);
        }
        m_GameInput.BatterNRunner.Enable();
    }

    public void OnDisable()
    {
        m_GameInput.BatterNRunner.Disable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (MoveActions != null)
        {
            MoveActions.Invoke(context.ReadValue<Vector2>());
        }
    }
    public void OnSwing(InputAction.CallbackContext context)
    {
        if(SwingActions != null)
        {
            SwingActions.Invoke();
        }
    }
    public void OnBunt(InputAction.CallbackContext context)
    {
        if (MoveActions != null)
        {
            if (context.performed)
            {
                BuntActions.Invoke(true);
            }else if (context.canceled)
            {
                BuntActions.Invoke(false);
            }
        }
    }
}
