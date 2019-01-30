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
    public sealed partial class Hard : Page
    {
        public Hard()
        {
            this.InitializeComponent();
            int numb = find_numbers();
            this.create_array(numb);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            this.reload_table();
            int numb = find_numbers();
            this.create_array(numb);
        }

        private async void Check_Click(object sender, RoutedEventArgs e)
        {
            int[] contents;
            contents = new int[25];
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
                contents[16] = Convert.ToInt32(button16.Content);
                contents[17] = Convert.ToInt32(button17.Content);
                contents[18] = Convert.ToInt32(button18.Content);
                contents[19] = Convert.ToInt32(button19.Content);
                contents[20] = Convert.ToInt32(button20.Content);
                contents[21] = Convert.ToInt32(button21.Content);
                contents[22] = Convert.ToInt32(button22.Content);
                contents[23] = Convert.ToInt32(button23.Content);
                contents[24] = Convert.ToInt32(button24.Content);
                int[] matrixr1;
                int[] matrixr2;
                int[] matrixr3;
                int[] matrixr4;
                int[] matrixr5;
                matrixr1 = new int[5] { contents[0], contents[1], contents[2], contents[3], contents[4] };
                matrixr2 = new int[5] { contents[5], contents[6], contents[7], contents[8], contents[9] };
                matrixr3 = new int[5] { contents[10], contents[11], contents[12], contents[13], contents[14] };
                matrixr4 = new int[5] { contents[15], contents[16], contents[17], contents[18], contents[19] };
                matrixr5 = new int[5] { contents[20], contents[21], contents[22], contents[23], contents[24] };
                int sumr1 = count_diffrence(5, matrixr1);
                int sumr2 = count_diffrence(5, matrixr2);
                int sumr3 = count_diffrence(5, matrixr3);
                int sumr4 = count_diffrence(5, matrixr4);
                int sumr5 = count_diffrence(5, matrixr5);
                int sumR = sumr1 + sumr2 + sumr3 + sumr4 + sumr5;
                int[] matrixc1;
                int[] matrixc2;
                int[] matrixc3;
                int[] matrixc4;
                int[] matrixc5;
                matrixc1 = new int[5] { contents[0], contents[5], contents[10], contents[15], contents[20] };
                matrixc2 = new int[5] { contents[1], contents[6], contents[11], contents[16], contents[21] };
                matrixc3 = new int[5] { contents[2], contents[7], contents[12], contents[17], contents[22] };
                matrixc4 = new int[5] { contents[3], contents[8], contents[13], contents[18], contents[23] };
                matrixc5 = new int[5] { contents[4], contents[9], contents[14], contents[19], contents[24] };
                int sumc1 = count_diffrence(5, matrixc1);
                int sumc2 = count_diffrence(5, matrixc2);
                int sumc3 = count_diffrence(5, matrixc3);
                int sumc4 = count_diffrence(5, matrixc4);
                int sumc5 = count_diffrence(5, matrixc5);
                int sumC = sumc1 + sumc2 + sumc3 + sumc4 + sumc5;
                int[] matrixs1;
                int[] matrixs2;
                int[] matrixs3;
                int[] matrixs4;
                int[] matrixs5;
                matrixs1 = new int[5] { contents[0], contents[1], contents[2], contents[5], contents[6] };
                matrixs2 = new int[5] { contents[7], contents[11], contents[12], contents[13], contents[17] };
                matrixs3 = new int[5] { contents[3], contents[4], contents[8], contents[9], contents[14] };
                matrixs4 = new int[5] { contents[10], contents[15], contents[16], contents[20], contents[21] };
                matrixs5 = new int[5] { contents[18], contents[19], contents[22], contents[23], contents[24] };
                int sums1 = count_diffrence(5, matrixs1);
                int sums2 = count_diffrence(5, matrixs2);
                int sums3 = count_diffrence(5, matrixs3);
                int sums4 = count_diffrence(5, matrixs4);
                int sums5 = count_diffrence(5, matrixs5);
                int sumS = sums1 + sums2 + sums3 + sums4 + sums5;
                if (sumR == 5 && sumC == 5 && sumS == 5)
                {
                    int new_points = 0;
                    Windows.Storage.ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
                    Object value = roamingSettings.Values["punkty"];
                    if (value != null)
                    {
                        new_points = Convert.ToInt32(value.ToString());
                    }
                    new_points += 110;
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
                if (newC < 5)  //liczba przyciskow w wierszu
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

        int find_numbers()
        {
            /* oblicza ilosc uzupelnionych liczb */
            Random percent = new Random();
            int random_percent = percent.Next(28, 46);
            int numbers = (random_percent * 25) / 100;
            return numbers;
        }

        void create_array(int numbers)
        {
            /* tworzy macierz uzupelnionych liczb */
            int[,] A = new int[5, 5];
            int i1, j1;
            for (i1 = 0; i1 < 5; i1++)
            {
                for (j1 = 0; j1 < 5; j1++)
                {
                    A[i1, j1] = 0;
                }
            }
            int _row_number, _col_number, i, j;
            int try_row = 0;
            Random rand = new Random();
            _row_number = rand.Next(0, 5);
            int[] B;
            B = new int[5];
            while (try_row == 0)
            {
                for (i = 0; i < 5; i++)
                {
                    B[i] = rand.Next(1, 6);
                }
                try_row = count_diffrence(5, B);
            }
            for (j = 0; j < 5; j++)
            {
                A[_row_number, j] = B[j];
            }
            _col_number = rand.Next(0, 5);
            int[] C;
            C = new int[5];
            int try_col = 0;
            int i2, j2;
            while (try_col == 0)
            {
                for (i2 = 0; i2 < 5; i2++)
                {
                    if (A[i2, _col_number] != 0)
                    {
                        C[i2] = A[i2, _col_number];
                    }
                    else
                    {
                        int tymc = rand.Next(1, 6);
                        if (_col_number == 0)
                        {
                            if (i2 == 0 || i2 == 1)
                            {
                                while (tymc == A[0, 0] || tymc == A[0, 1] || tymc == A[0, 2] || tymc == A[1, 0] || tymc == A[1, 1])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                            else
                            {
                                while (tymc == A[2, 0] || tymc == A[3, 0] || tymc == A[3, 1] || tymc == A[4, 0] || tymc == A[4, 1])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                        }
                        else if (_col_number == 1)
                        {
                            if (i2 == 0 || i2 == 1)
                            {
                                while (tymc == A[0, 0] || tymc == A[0, 1] || tymc == A[0, 2] || tymc == A[1, 0] || tymc == A[1, 1])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                            else if (i2 == 3 || i2 == 4)
                            {
                                while (tymc == A[2, 0] || tymc == A[3, 0] || tymc == A[3, 1] || tymc == A[4, 0] || tymc == A[4, 1])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                            else
                            {
                                while (tymc == A[1, 2] || tymc == A[2, 1] || tymc == A[2, 2] || tymc == A[2, 3] || tymc == A[3, 2])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                        }
                        else if (_col_number == 2)
                        {
                            if (i2 == 0)
                            {
                                while (tymc == A[0, 0] || tymc == A[0, 1] || tymc == A[0, 2] || tymc == A[1, 0] || tymc == A[1, 1])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                            else if (i2 == 4)
                            {
                                while (tymc == A[4, 2] || tymc == A[4, 3] || tymc == A[4, 4] || tymc == A[3, 3] || tymc == A[3, 4])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                            else
                            {
                                while (tymc == A[1, 2] || tymc == A[2, 1] || tymc == A[2, 2] || tymc == A[2, 3] || tymc == A[3, 2])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                        }
                        else if (_col_number == 3)
                        {
                            if (i2 == 0 || i2 == 1)
                            {
                                while (tymc == A[0, 3] || tymc == A[0, 4] || tymc == A[1, 3] || tymc == A[1, 4] || tymc == A[2, 4])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                            else if (i2 == 3 || i2 == 4)
                            {
                                while (tymc == A[4, 2] || tymc == A[4, 3] || tymc == A[4, 4] || tymc == A[3, 3] || tymc == A[3, 4])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                            else
                            {
                                while (tymc == A[1, 2] || tymc == A[2, 1] || tymc == A[2, 2] || tymc == A[2, 3] || tymc == A[3, 2])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                        }
                        else
                        {
                            if (i2 == 0 || i2 == 1 || i2 == 2)
                            {
                                while (tymc == A[0, 3] || tymc == A[0, 4] || tymc == A[1, 3] || tymc == A[1, 4] || tymc == A[2, 4])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                            else
                            {
                                while (tymc == A[4, 2] || tymc == A[4, 3] || tymc == A[4, 4] || tymc == A[3, 3] || tymc == A[3, 4])
                                {
                                    tymc = rand.Next(1, 6);
                                }
                            }
                        }
                        C[i2] = tymc;
                    }
                }
                try_col = count_diffrence(5, C);
            }
            for (j2 = 0; j2 < 5; j2++)
            {
                A[j2, _col_number] = C[j2];
            }
            int wrong_numbers = 12 - numbers;
            if (wrong_numbers < 0)
            {
                wrong_numbers *= -1;
            }
            while (wrong_numbers != 0)
            {
                int _col_number2 = rand.Next(0, 5);
                int _row_number2 = rand.Next(0, 5);
                if (A[_row_number2, _col_number2] != 0)
                {
                    A[_row_number2, _col_number2] = 0;
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
                button3.Content = A[0, 3].ToString();
                button3.FontSize = 24;
            }
            else
            {
                button3.Content = "";
            }
            if (A[0, 4] != 0)
            {
                button4.Content = A[0, 4].ToString();
                button4.FontSize = 24;
            }
            else
            {
                button4.Content = "";
            }
            if (A[1, 0] != 0)
            {
                button5.Content = A[1, 0].ToString();
                button5.FontSize = 24;
            }
            else
            {
                button5.Content = "";
            }
            if (A[1, 1] != 0)
            {
                button6.Content = A[1, 1].ToString();
                button6.FontSize = 24;
            }
            else
            {
                button6.Content = "";
            }
            if (A[1, 2] != 0)
            {
                button7.Content = A[1, 2].ToString();
                button7.FontSize = 24;
            }
            else
            {
                button7.Content = "";
            }
            if (A[1, 3] != 0)
            {
                button8.Content = A[1, 3].ToString();
                button8.FontSize = 24;
            }
            else
            {
                button8.Content = "";
            }
            if (A[1, 4] != 0)
            {
                button9.Content = A[1, 4].ToString();
                button9.FontSize = 24;
            }
            else
            {
                button9.Content = "";
            }
            if (A[2, 0] != 0)
            {
                button10.Content = A[2, 0].ToString();
                button10.FontSize = 24;
            }
            else
            {
                button10.Content = "";
            }
            if (A[2, 1] != 0)
            {
                button11.Content = A[2, 1].ToString();
                button11.FontSize = 24;
            }
            else
            {
                button11.Content = "";
            }
            if (A[2, 2] != 0)
            {
                button12.Content = A[2, 2].ToString();
                button12.FontSize = 24;
            }
            else
            {
                button12.Content = "";
            }
            if (A[2, 3] != 0)
            {
                button13.Content = A[2, 3].ToString();
                button13.FontSize = 24;
            }
            else
            {
                button13.Content = "";
            }
            if (A[2, 4] != 0)
            {
                button14.Content = A[2, 4].ToString();
                button14.FontSize = 24;
            }
            else
            {
                button14.Content = "";
            }
            if (A[3, 0] != 0)
            {
                button15.Content = A[3, 0].ToString();
                button15.FontSize = 24;
            }
            else
            {
                button15.Content = "";
            }
            if (A[3, 1] != 0)
            {
                button16.Content = A[3, 1].ToString();
                button16.FontSize = 24;
            }
            else
            {
                button16.Content = "";
            }
            if (A[3, 2] != 0)
            {
                button17.Content = A[3, 2].ToString();
                button17.FontSize = 24;
            }
            else
            {
                button17.Content = "";
            }
            if (A[3, 3] != 0)
            {
                button18.Content = A[3, 3].ToString();
                button18.FontSize = 24;
            }
            else
            {
                button18.Content = "";
            }
            if (A[3, 4] != 0)
            {
                button19.Content = A[3, 4].ToString();
                button19.FontSize = 24;
            }
            else
            {
                button19.Content = "";
            }
            if (A[4, 0] != 0)
            {
                button20.Content = A[4, 0].ToString();
                button20.FontSize = 24;
            }
            else
            {
                button20.Content = "";
            }
            if (A[4, 1] != 0)
            {
                button21.Content = A[4, 1].ToString();
                button21.FontSize = 24;
            }
            else
            {
                button21.Content = "";
            }
            if (A[4, 2] != 0)
            {
                button22.Content = A[4, 2].ToString();
                button22.FontSize = 24;
            }
            else
            {
                button22.Content = "";
            }
            if (A[4, 3] != 0)
            {
                button23.Content = A[4, 3].ToString();
                button23.FontSize = 24;
            }
            else
            {
                button23.Content = "";
            }
            if (A[4, 4] != 0)
            {
                button24.Content = A[4, 4].ToString();
                button24.FontSize = 24;
            }
            else
            {
                button24.Content = "";
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
            button16.FontSize = 15;
            button17.FontSize = 15;
            button18.FontSize = 15;
            button19.FontSize = 15;
            button20.FontSize = 15;
            button21.FontSize = 15;
            button22.FontSize = 15;
            button23.FontSize = 15;
            button24.FontSize = 15;
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
    }
}
