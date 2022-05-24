using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace UP_PM05
{
    /// <summary>
    /// Логика взаимодействия для PageEmployee.xaml
    /// </summary>
    
        public partial class PageEmployee : Page
        {
        Minakov_UP_PM05Entities entities = new Minakov_UP_PM05Entities();
            public PageEmployee()
            {
                InitializeComponent();
                entities.Employee.Load();
                lll.ItemsSource = entities.Employee.Local;
            }





            private bool isDirty = true;

            private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
            {

            }

            private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                MessageBox.Show("Отмена");
                isDirty = true;
            }

            private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                MessageBox.Show("Создание");
                isDirty = true;
            }

            private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
            {

            }

            private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                MessageBox.Show("Сохранение");
                isDirty = true;
            }

            private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
            {
                e.CanExecute = !isDirty;
            }

            private void FindCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                MessageBox.Show("Поиск");
                isDirty = true;
            }

            private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
            {

            }

            private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                MessageBox.Show("Изменение");
                isDirty = true;
            }

            private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
            {
                e.CanExecute = isDirty;
            }

            private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                MessageBox.Show("Удаление");
                isDirty = true;
            }

            private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
            {

            }

            private void Page_Loaded(object sender, RoutedEventArgs e)
            {

            }
        
    }
}
