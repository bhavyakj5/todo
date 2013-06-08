using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO;
using System.IO.IsolatedStorage;

namespace ToDo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        public void f1(string button)
        {
            var appstorage = IsolatedStorageFile.GetUserStoreForApplication();
            string filename = "10.txt";
            using (var file = appstorage.OpenFile(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(textBox1.Text);
                }
            }

            if (button == "add")
                MessageBox.Show("To-Do Added!");
            else if (button == "x")
                MessageBox.Show("To-Do Deleted!");
        }

        public void f2(string button)
        {
            var appstorage = IsolatedStorageFile.GetUserStoreForApplication();
            string filename = "20.txt";
            using (var file = appstorage.OpenFile(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(textBox2.Text);
                }
            }

            if (button == "add")
                MessageBox.Show("To-Do Added!");
            else if (button == "x")
                MessageBox.Show("To-Do Deleted!");
        }
        public void f3(string button)
        {
            var appstorage = IsolatedStorageFile.GetUserStoreForApplication();
            string filename = "30.txt";
            using (var file = appstorage.OpenFile(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(textBox3.Text);
                }
            }

            if (button == "add")
                MessageBox.Show("To-Do Added!");
            else if (button == "x")
                MessageBox.Show("To-Do Deleted!");
        }
        public void f4(string button)
        {
            var appstorage = IsolatedStorageFile.GetUserStoreForApplication();
            string filename = "40.txt";
            using (var file = appstorage.OpenFile(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(textBox4.Text);
                }
            }

            if (button == "add")
                MessageBox.Show("To-Do Added!");
            else if (button == "x")
                MessageBox.Show("To-Do Deleted!");
        }
        public void f5(string button)
        {
            var appstorage = IsolatedStorageFile.GetUserStoreForApplication();
            string filename = "50.txt";
            using (var file = appstorage.OpenFile(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(textBox5.Text);
                }

                if (button == "add")
                    MessageBox.Show("To-Do Added!");
                else if (button == "x")
                    MessageBox.Show("To-Do Deleted!");
            }
        }
        public void f6(string button)
        {
            var appstorage = IsolatedStorageFile.GetUserStoreForApplication();
            string filename = "60.txt";
            using (var file = appstorage.OpenFile(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(textBox6.Text);
                }
            }

            if (button == "add")
                MessageBox.Show("To-Do Added!");
            else if (button == "x")
                MessageBox.Show("To-Do Deleted!");
        }

        private void add1_Click(object sender, RoutedEventArgs e)
        {
            x1.Visibility = Visibility.Visible;
            add1.Visibility = Visibility.Collapsed;
            f1("add");
        }

        private void x1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            x1.Visibility = Visibility.Collapsed;
            f1("x");
            add1.Visibility = Visibility.Visible;
        }


        private void add2_Click(object sender, RoutedEventArgs e)
        {
            x2.Visibility = Visibility.Visible;
            add2.Visibility = Visibility.Collapsed;
            f2("add");
        }

        private void x2_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "";
            x2.Visibility = Visibility.Collapsed;
            f2("x");
            add2.Visibility = Visibility.Visible;

        }

        private void add3_Click(object sender, RoutedEventArgs e)
        {
            x3.Visibility = Visibility.Visible;
            add4.Visibility = Visibility.Visible;
            add3.Visibility = Visibility.Collapsed;
            f3("add");
        }

        private void x3_Click(object sender, RoutedEventArgs e)
        {
            textBox3.Text = "";
            x3.Visibility = Visibility.Collapsed;
            f3("x");
            add3.Visibility = Visibility.Visible;
        }

        private void add4_Click(object sender, RoutedEventArgs e)
        {
            x4.Visibility = Visibility.Visible;
            add4.Visibility = Visibility.Collapsed;
            f4("add");
        }

        private void x4_Click(object sender, RoutedEventArgs e)
        {
            textBox4.Text = "";
            x4.Visibility = Visibility.Collapsed;
            add4.Visibility = Visibility.Visible;
            f4("x");
        }

        private void add5_Click(object sender, RoutedEventArgs e)
        {
            x5.Visibility = Visibility.Visible;
            add5.Visibility = Visibility.Collapsed;
            f5("add");
        }

        private void x5_Click(object sender, RoutedEventArgs e)
        {
            textBox5.Text = "";
            x5.Visibility = Visibility.Collapsed;
            f5("x");
            add5.Visibility = Visibility.Visible;
        }

        private void add6_Click(object sender, RoutedEventArgs e)
        {
            x6.Visibility = Visibility.Visible;
            add6.Visibility = Visibility.Collapsed;
            f6("add");
         }

        private void x6_Click(object sender, RoutedEventArgs e)
        {
            textBox6.Text = "";
            x6.Visibility = Visibility.Collapsed;
            f6("x");
            add6.Visibility = Visibility.Visible;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
              using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
                {
                    using (StreamReader sr = new StreamReader(store.OpenFile("10.txt", FileMode.Open, FileAccess.Read)))
                    {
                        textBox1.Text = sr.ReadToEnd();
                    }
                    using (StreamReader sr = new StreamReader(store.OpenFile("20.txt", FileMode.Open, FileAccess.Read)))
                    {
                        textBox2.Text = sr.ReadToEnd();
                    }
                    using (StreamReader sr = new StreamReader(store.OpenFile("30.txt", FileMode.Open, FileAccess.Read)))
                    {
                        textBox3.Text = sr.ReadToEnd();
                    }
                    using (StreamReader sr = new StreamReader(store.OpenFile("40.txt", FileMode.Open, FileAccess.Read)))
                    {
                        textBox4.Text = sr.ReadToEnd();
                    }
                    using (StreamReader sr = new StreamReader(store.OpenFile("50.txt", FileMode.Open, FileAccess.Read)))
                    {
                        textBox5.Text = sr.ReadToEnd();
                    }
                    using (StreamReader sr = new StreamReader(store.OpenFile("60.txt", FileMode.Open, FileAccess.Read)))
                    {
                        textBox6.Text = sr.ReadToEnd();
                    }
                }
            }
            catch
            {
            }

            if (textBox1.Text == "")
                x1.Visibility = Visibility.Collapsed;
            else
                add1.Visibility = Visibility.Collapsed;
            if (textBox2.Text == "")
                x2.Visibility = Visibility.Collapsed;
            else
                add2.Visibility = Visibility.Collapsed;
            if (textBox3.Text == "")
                x3.Visibility = Visibility.Collapsed;
            else
                add3.Visibility = Visibility.Collapsed;
            if (textBox4.Text == "")
                x4.Visibility = Visibility.Collapsed;
            else
                add4.Visibility = Visibility.Collapsed;
            if (textBox5.Text == "")
                x5.Visibility = Visibility.Collapsed;
            else
                add5.Visibility = Visibility.Collapsed;
            if (textBox6.Text == "")
                x6.Visibility = Visibility.Collapsed;
            else
                add6.Visibility = Visibility.Collapsed;
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions: Write down your task in any of the spaces given above, Press 'Add' to Save it!\nOnce done, you can delete it with 'X' button.");
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("About: Great app, simplifies all your To-Do tasks at one single place, no need to write it down anywhere, write-->do-->delete!");
        }
    }
}