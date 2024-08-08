using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonCLick;

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }

    protected override void OnButtonClick()
    {
        RestartButtonCLick?.Invoke();   
    }
}
