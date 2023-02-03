﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGeme();

        }

        private void SetUpGeme()
        {
            List<string> animalEmoji = new List<string>() // Создаст список из восьми пар эмодзи
            {
            "🐯", "🐯",
            "👽", "👽",
            "🤖", "🤖",
            "🐰", "🐰",
            "🐭", "🐭",
            "🐙", "🐙",
            "🦝", "🦝",
            "🦨", "🦨",

            };

            Random random = new Random(); // Создаст новый генератор случайных чисел

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())  // Находит каждый элемент TextBlock в сетке и повторяет следующие команды для каждого элемента
            {
                int index = random.Next(animalEmoji.Count); // Выбирает случайное число от 0 до количества эмодзи в списке и назначает ему имя «index»
                string nextEmoji = animalEmoji[index]; //  Использует случайное число с именем «index» для получения случайного эмодзи из списка
                textBlock.Text = nextEmoji; // Обновляет Text Block случайным эмодзи из списка
                animalEmoji.RemoveAt(index); // Удаляет случайный эмодзи из списка
            }
        }
    }
}