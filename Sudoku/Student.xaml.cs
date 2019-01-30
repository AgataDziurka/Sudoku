using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sudoku
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Student : Page
    {
        DispatcherTimer dispatcherTimer;
        int timer;

        public Student()
        {
            this.InitializeComponent();
            int numb = find_numbers();
            this.create_array(numb);
            StartTimers();
        }

        public void StartTimers()
        {
            timer = Int32.Parse(time_Block.Text);
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        void dispatcherTimer_Tick(object sender, object e)
        {
            timer--;
            time_Block.Text = timer.ToString();
            if (timer == 0)
            {
                dispatcherTimer.Stop();
                check_win();
            }
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            check_win();
        }

        async void check_win()
        {
            int n;
            int n2;
            int[] contents;
            n = 4;
            n2 = 16;
            contents = new int[n2];
            try
            {
                contents[0] = Convert.ToInt32(button0.Content);
                contents[1] = Convert.ToInt32(button1.Content);
                contents[2] = Convert.ToInt32(button2.Content);
                contents[3] = Convert.ToInt32(button3.Content);
                contents[4] = Convert.ToInt32(button4.Content);
                contents[5] = Convert.ToInt32(button5.Content);
                contents[6] = Convert.ToInt32(button6.Content);
                contents[7] = Convert.ToInt32(button7.Content);
                contents[8] = Convert.ToInt32(button8.Content);
                contents[9] = Convert.ToInt32(button9.Content);
                contents[10] = Convert.ToInt32(button10.Content);
                contents[11] = Convert.ToInt32(button11.Content);
                contents[12] = Convert.ToInt32(button12.Content);
                contents[13] = Convert.ToInt32(button13.Content);
                contents[14] = Convert.ToInt32(button14.Content);
                contents[15] = Convert.ToInt32(button15.Content);
                int[][] matrixr1;
                matrixr1 = new int[][] { new int[n], new int[n] };
                matrixr1[0][0] = contents[0];
                matrixr1[0][1] = contents[1];
                matrixr1[0][2] = contents[2];
                matrixr1[0][3] = contents[9];
                matrixr1[1][0] = contents[3];
                matrixr1[1][1] = contents[4];
                matrixr1[1][2] = contents[5];
                matrixr1[1][3] = contents[10];
                int[][] matrixr2;
                matrixr2 = new int[][] { new int[n], new int[n] };
                matrixr2[0][0] = contents[6];
                matrixr2[0][1] = contents[7];
                matrixr2[0][2] = contents[8];
                matrixr2[0][3] = contents[11];
                matrixr2[1][0] = contents[12];
                matrixr2[1][1] = contents[13];
                matrixr2[1][2] = contents[14];
                matrixr2[1][3] = contents[15];
                int[][] matrixc1;
                matrixc1 = new int[][] { new int[n], new int[n] };
                matrixc1[0][0] = contents[0];
                matrixc1[0][1] = contents[3];
                matrixc1[0][2] = contents[6];
                matrixc1[0][3] = contents[12];
                matrixc1[1][0] = contents[1];
                matrixc1[1][1] = contents[4];
                matrixc1[1][2] = contents[7];
                matrixc1[1][3] = contents[13];
                int[][] matrixc2;
                matrixc2 = new int[][] { new int[n], new int[n] };
                matrixc2[0][0] = contents[2];
                matrixc2[0][1] = contents[5];
                matrixc2[0][2] = contents[8];
                matrixc2[0][3] = contents[14];
                matrixc2[1][0] = contents[9];
                matrixc2[1][1] = contents[10];
                matrixc2[1][2] = contents[11];
                matrixc2[1][3] = contents[15];
                int[][] matrixs1;
                matrixs1 = new int[][] { new int[n], new int[n] };
                matrixs1[0][0] = contents[0];
                matrixs1[0][1] = contents[1];
                matrixs1[0][2] = contents[3];
                matrixs1[0][3] = contents[4];
                matrixs1[1][0] = contents[2];
                matrixs1[1][1] = contents[5];
                matrixs1[1][2] = contents[9];
                matrixs1[1][3] = contents[10];
                int[][] matrixs2;
                matrixs2 = new int[][] { new int[n], new int[n] };
                matrixs2[0][0] = contents[6];
                matrixs2[0][1] = contents[7];
                matrixs2[0][2] = contents[12];
                matrixs2[0][3] = contents[13];
                matrixs2[1][0] = contents[8];
                matrixs2[1][1] = contents[11];
                matrixs2[1][2] = contents[14];
                matrixs2[1][3] = contents[15];
                int sumr1, sumr2, sumc1, sumc2, sums1, sums2;
                sumr1 = check_table(matrixr1, n / 2);
                sumr2 = check_table(matrixr2, n / 2);
                sumc1 = check_table(matrixc1, n / 2);
                sumc2 = check_table(matrixc2, n / 2);
                sums1 = check_table(matrixs1, n / 2);
                sums2 = check_table(matrixs2, n / 2);
                if (sumr1 + sumr2 == 4 && sumc1 + sumc2 == 4 && sums1 + sums2 == 4)
                {
                    int new_points = 0;
                    Windows.Storage.ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
                    Object value = roamingSettings.Values["punkty"];
                    if (value != null)
                    {
                        new_points = Convert.ToInt32(value.ToString());
                    }
                    new_points += 75;
                    roamingSettings.Values["punkty"] = new_points.ToString();
                    ContentDialog1 dialog = new ContentDialog1("WYGRANA");
                    await dialog.ShowAsync();
                    if (dialog.result_dialog == 1)
                    {
                        Frame.GoBack();
                    }
                }
                else
                {
                    ContentDialog1 dialog = new ContentDialog1("PRZEGRANA");
                    await dialog.ShowAsync();
                    if (dialog.result_dialog == 1)
                    {
                        Frame.GoBack();
                    }
                }
            }
            catch (Exception e1)
            {
                ContentDialog1 dialog = new ContentDialog1("PRZEGRANA");
                await dialog.ShowAsync();
                if (dialog.result_dialog == 1)
                {
                    Frame.GoBack();
                }
            }
        }

        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            this.reload_table();
            int numb = find_numbers();
            this.create_array(numb);
        }

        int find_numbers()
        {
            /* oblicza ilosc uzupelnionych liczb */
            Random percent = new Random();
            int random_percent = percent.Next(28, 42);
            int numbers = (random_percent * 16) / 100;
            return numbers;
        }

        void create_array(int numbers)
        {
            /* tworzy macierz uzupelnionych liczb */
            int[,] A = new int[4, 4];
            int i1, j1;
            for (i1 = 0; i1 < 4; i1++)
            {
                for (j1 = 0; j1 < 4; j1++)
                {
                    A[i1, j1] = 0;
                }
            }
            int _row_number, _row_number2, i, j, k;
            int try_row = 0;
            int l = 0;
            Random rand = new Random();
            _row_number = rand.Next(0, 4);
            int[] B;
            B = new int[4];
            while (try_row == 0)
            {
                for (i = 0; i < 4; i++)
                {
                    B[i] = rand.Next(1, 5);
                }
                try_row = count_diffrence(4, B);
            }
            for (j = 0; j < 4; j++)
            {
                A[_row_number, j] = B[j];
            }
            _row_number2 = rand.Next(0, 4);
            while (_row_number2 == _row_number)
            {
                _row_number2 = rand.Next(0, 4);
            }
            for (k = 3; k > -1; k--, l++)
            {
                A[_row_number2, l] = A[_row_number, k];
            }
            int wrong_numbers = 8 - numbers;
            while (wrong_numbers != 0)
            {
                int _col_number = rand.Next(0, 4);
                int _row_number3;
                if (_col_number % 2 == 0)
                {
                    _row_number3 = _row_number;
                }
                else
                {
                    _row_number3 = _row_number2;
                }
                if (A[_row_number3, _col_number] != 0)
                {
                    A[_row_number3, _col_number] = 0;
                    wrong_numbers--;
                }
            }
            if (A[0, 0] != 0)
            {
                button0.Content = A[0, 0].ToString();
                button0.FontSize = 24;
            }
            else
            {
                button0.Content = "";
            }
            if (A[0, 1] != 0)
            {
                button1.Content = A[0, 1].ToString();
                button1.FontSize = 24;
            }
            else
            {
                button1.Content = "";
            }
            if (A[0, 2] != 0)
            {
                button2.Content = A[0, 2].ToString();
                button2.FontSize = 24;
            }
            else
            {
                button2.Content = "";
            }
            if (A[0, 3] != 0)
            {
                button9.Content = A[0, 3].ToString();
                button9.FontSize = 24;
            }
            else
            {
                button9.Content = "";
            }
            if (A[1, 0] != 0)
            {
                button3.Content = A[1, 0].ToString();
                button3.FontSize = 24;
            }
            else
            {
                button3.Content = "";
            }
            if (A[1, 1] != 0)
            {
                button4.Content = A[1, 1].ToString();
                button4.FontSize = 24;
            }
            else
            {
                button4.Content = "";
            }
            if (A[1, 2] != 0)
            {
                button5.Content = A[1, 2].ToString();
                button5.FontSize = 24;
            }
            else
            {
                button5.Content = "";
            }
            if (A[1, 3] != 0)
            {
                button10.Content = A[1, 3].ToString();
                button10.FontSize = 24;
            }
            else
            {
                button10.Content = "";
            }
            if (A[2, 0] != 0)
            {
                button6.Content = A[2, 0].ToString();
                button6.FontSize = 24;
            }
            else
            {
                button6.Content = "";
            }
            if (A[2, 1] != 0)
            {
                button7.Content = A[2, 1].ToString();
                button7.FontSize = 24;
            }
            else
            {
                button7.Content = "";
            }
            if (A[2, 2] != 0)
            {
                button8.Content = A[2, 2].ToString();
                button8.FontSize = 24;
            }
            else
            {
                button8.Content = "";
            }
            if (A[2, 3] != 0)
            {
                button11.Content = A[2, 3].ToString();
                button11.FontSize = 24;
            }
            else
            {
                button11.Content = "";
            }
            if (A[3, 0] != 0)
            {
                button12.Content = A[3, 0].ToString();
                button12.FontSize = 24;
            }
            else
            {
                button12.Content = "";
            }
            if (A[3, 1] != 0)
            {
                button13.Content = A[3, 1].ToString();
                button13.FontSize = 24;
            }
            else
            {
                button13.Content = "";
            }
            if (A[3, 2] != 0)
            {
                button14.Content = A[3, 2].ToString();
                button14.FontSize = 24;
            }
            else
            {
                button14.Content = "";
            }
            if (A[3, 3] != 0)
            {
                button15.Content = A[3, 3].ToString();
                button15.FontSize = 24;
            }
            else
            {
                button15.Content = "";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int newC;
            if (((Button)sender).FontSize != 24)
            {
                try
                {
                    newC = Convert.ToInt32(((Button)sender).Content);
                }
                catch (Exception)
                {
                    newC = 0;  //tak by zaczynal od 1
                }
                if (newC < 4)  //liczba przyciskow w wierszu
                {
                    newC += 1;
                }
                else
                {
                    newC = 0;
                }
                if (newC == 0)
                {
                    ((Button)sender).Content = "";
                }
                else
                {
                    ((Button)sender).Content = newC.ToString();
                }
            }
        }

        void reload_table()
        {
            /* resetuje wartosci czcionki przyciskow na automatyczna */
            button0.FontSize = 15;
            button1.FontSize = 15;
            button2.FontSize = 15;
            button3.FontSize = 15;
            button4.FontSize = 15;
            button5.FontSize = 15;
            button6.FontSize = 15;
            button7.FontSize = 15;
            button8.FontSize = 15;
            button9.FontSize = 15;
            button10.FontSize = 15;
            button11.FontSize = 15;
            button12.FontSize = 15;
            button13.FontSize = 15;
            button14.FontSize = 15;
            button15.FontSize = 15;
        }

        int maxi(int c, int[] tab2)
        {
            /* zwraca najwiekszy element podanej tablicy */
            int k, m;
            m = tab2[0];
            for (k = 0; k < c; k++)
            {
                if (m < tab2[k])
                {
                    m = tab2[k];
                }
            }
            return m;
        }

        int count_diffrence(int n, int[] tab)
        {
            /* sprawdza czy w podanej tablicy sa rozne liczby */
            int i, j;
            int[] tab1;
            tab1 = new int[n];

            for (i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    tab1[i] = 1;
                }
                else
                {
                    for (j = i; j > 0; j--)
                    {
                        if (tab[j - 1] == tab[i])
                        {
                            tab1[j - 1] = tab1[j - 1] + 1;
                        }
                    }
                    if (j == 0)
                    {
                        tab1[i] = 1;
                    }
                }
            }
            if (maxi(n, tab1) == 1)
            {
                return 1;  //TRUE
            }
            else
            {
                return 0;  //FALSE
            }
        }

        int check_table(int[][] matrix_check, int n)
        {
            /* sprawdza czy w macierzy liczby sa rozne */
            int l;
            int summ = 0;
            for (l = 0; l < n; l++)
            {

                summ += count_diffrence(n, matrix_check[l]);
            }
            return summ;
        }

    }
}
