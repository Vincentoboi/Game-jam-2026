using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour// script done by Nova
{

    [SerializeField] UIDocument mainMenuDocument;

    private Button startButton;
    private Button controllsButton;
    private Button exitButton;

    public static bool StartButtonPressed = false;
    private void Start()
    {
        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = CursorLockMode.None;
    }
    private void Awake()
    {
        VisualElement root = mainMenuDocument.rootVisualElement;// refrencing to UI toolkit

        startButton = root.Q<Button>("StartButton");
        controllsButton = root.Q<Button>("ControllsButton");
        exitButton = root.Q<Button>("ExitButton");// makes it clickacble

        startButton.clickable.clicked += PlayGame;
        controllsButton.clickable.clicked += ShowControllsMenu;
        exitButton.clickable.clicked += ExitGame;//does so the buttons is presable
    }


    private void ShowControllsMenu()
    {
        print("show settings menu");
    }

    private void PlayGame()
    {
        StartButtonPressed = true;
        SceneManager.LoadScene("TransitionLevel");//goes to new scene when pressing the start button
    }

    private void ExitGame()
    {
        print("Exiting game");
        Application.Quit();//quits game(only work when game is built)
    }
}
