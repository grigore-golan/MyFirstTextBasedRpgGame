﻿using MyFirstTextBasedRpgGame.Dialogues.Interactive;
using MyFirstTextBasedRpgGame.Events.Visitors;

namespace MyFirstTextBasedRpgGame
{
    public class Program
    {
        public static void Main() 
        {
            SoundPlayer soundPlayer = new()
            {
                SoundLocation = @"D:\Downloads\Chrome\gameBackground.wav"
            };
            soundPlayer.Play();

            Player player = Player.GetInstance();
            EventVisitor visitor = new();

            InitialDialogue dialogue = new();
            dialogue.Dialogue.Display();

            while (player.IsAlive)
            {
                // Generator de evenimente
            }

            Console.WriteLine("What happened next to our brave Adventurer we will find out soon...\n" +
                              "But now, this is the end... Is this the end?");

            Console.ReadLine();
        }
    }
}