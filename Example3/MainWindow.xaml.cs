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

namespace Example3
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    int counter = 0;
    public MainWindow()
    {
      InitializeComponent();

      // В конструкторе свяжите событие «Вход мыши» (MouseEnter) с обработчиком, передаваемым при помощи лямбда-выражения. 
      // В лямбда-выражении содержится код, изменяющий заголовок формы на информацию о количестве «входов» мыши на форму.


      // Обработчик описать при помощи лямбда-выражения, при нажатии кнопки мыши фон формы изменять на красный.
      // В обработчик события MouseEnter добавить код, возвращающий фону формы значение White


      MainButton.MouseEnter += (object sender, MouseEventArgs e) => { //Title = counter++.ToString(); Background = Brushes.White; };

      //MainButton.Click += (object sender, RoutedEventArgs e) => { Background = Brushes.Red; };

    }
  }
}
