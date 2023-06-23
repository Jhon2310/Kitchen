using System;
using System.Timers;
using UnityEngine;


public class Toaster : MonoBehaviour
{
    public delegate void ToastEventHandler();
    public event ToastEventHandler TimerIsUp;
    // TODO: Создайте событие TimerIsUp и вызывайте его, когда таймер вышел

    public float Timer { get; private set; } = 10; // Таймер готовности вафли
    private bool _isTimerUp; 

    private void Update()
    {
        // Если таймер вышел - выходим из метода
        if (_isTimerUp)
        {
            return;
        }
        
        // Если таймер не вышел
        if (Timer > 0)
        {
            // Отнимаем время, прошедшее за кадр
            Timer -= Time.deltaTime;
        }
        else
        {
            // Таймер вышел
            InvokeEvent();
            _isTimerUp = true;
            
        }
    }

    public void InvokeEvent()
    {
        if (TimerIsUp != null) TimerIsUp.Invoke();
    }
}



