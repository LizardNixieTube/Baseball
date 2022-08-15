using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "MenuInputReader", menuName = "InputReader/Menu", order = 1)]
public class MenuInputReader : ScriptableObject, MenuInput.IMenuActions
{
    public event UnityAction StartActions;   //Confirm (start throwing)

    private MenuInput m_MenuInput;

    void OnEnable()
    {
        if (m_MenuInput == null)
        {
            m_MenuInput = new MenuInput();
            m_MenuInput.Menu.SetCallbacks(this);
        }
        m_MenuInput.Menu.Enable();
    }

    void OnDisable()
    {
        m_MenuInput.Menu.Disable();
    }

    public void OnStartGame(InputAction.CallbackContext context)
    {
        if(StartActions != null && context.canceled) 
        {
            StartActions.Invoke();    
        }
    }
}
