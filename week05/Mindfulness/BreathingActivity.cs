using System;

public class BreathingActivity: Activity
{     
    public BreathingActivity()
        : base("Breathing Activity",
              "This activity will help you relax by guiding you through breathing slowly.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            elapsed += 4;

            if (elapsed >= _duration)
                break;

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
            elapsed += 4;
        }

        DisplayEndingMessage();
    }

}