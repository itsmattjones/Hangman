﻿using System;
using System.Collections.Generic;

namespace Hangman {
    class GameVisualizer {
        public void outputWelcome() {
            Console.Clear();
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("In Hangman your goal is to guess all the letters that make up");
            Console.WriteLine("the hidden word! If you get six incorrect guess you lose.");
            Console.WriteLine("Each time you guess correctly, the letter is revealed in the word.");
            Console.WriteLine("A random word is chosen at the start of the game." + Environment.NewLine);
            Console.WriteLine("Press ENTER to start the game...");
            Console.ReadLine();
        }

        public void outputWord(List<char> word) {
            Console.Write(Environment.NewLine + "Word: ");
            foreach (char letter in word) {
                Console.Write(letter);
            }
        }

        public void outputGuessedLetters() {
            Console.Write(Environment.NewLine + "Incorrect Guesses: ");
            foreach (char letter in Program.incorrectPlayerGuesses) {
                Console.Write(letter + ", ");
            }
            Console.WriteLine();
        }

        public void outputLoseMessage() {
            Console.Clear();
            Console.WriteLine("You're out of guesses! You Lose!" + Environment.NewLine);
            Console.WriteLine("The word was: ");
            foreach (char letter in Program.gameWord) {
                Console.Write(letter);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press ENTER to leave the game");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void outputWinMessage() {
            Console.Clear();
            Console.WriteLine(Environment.NewLine + "Congratulations! You Win!");
            Console.WriteLine("You had " + Program.incorrectPlayerGuesses.Count + " incorrect guesses!" + Environment.NewLine);
            Console.WriteLine("The final word was: ");
            foreach (char letter in Program.gameWord) {
                Console.Write(letter);
            }
            Console.ReadLine();
        }
    }
}