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
    public sealed partial class Normal : Page
    {
        public Normal()
        {
            this.InitializeComponent();
            this.reload_table();
            int numb = find_numbers();
            this.create_array(numb);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int newC;
            if (((Button)sender).FontSize != 18)
            {
                try
                {
                    newC = Convert.ToInt32(((Button)sender).Content);
                }
                catch (Exception)
                {
                    newC = 0;  //tak by zaczynal od 1
                }
                if (newC < 9)  //liczba przyciskow w wierszu
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

        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            this.reload_table();
            int numb = find_numbers();
            this.create_array(numb);
        }

        private async void Check_Click(object sender, RoutedEventArgs e)
        {
            int[] contents;
            contents = new int[81];
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
                contents[25] = Convert.ToInt32(button25.Content);
                contents[26] = Convert.ToInt32(button26.Content);
                contents[27] = Convert.ToInt32(button27.Content);
                contents[28] = Convert.ToInt32(button28.Content);
                contents[29] = Convert.ToInt32(button29.Content);
                contents[30] = Convert.ToInt32(button30.Content);
                contents[31] = Convert.ToInt32(button31.Content);
                contents[32] = Convert.ToInt32(button32.Content);
                contents[33] = Convert.ToInt32(button33.Content);
                contents[34] = Convert.ToInt32(button34.Content);
                contents[35] = Convert.ToInt32(button35.Content);
                contents[36] = Convert.ToInt32(button36.Content);
                contents[37] = Convert.ToInt32(button37.Content);
                contents[38] = Convert.ToInt32(button38.Content);
                contents[39] = Convert.ToInt32(button39.Content);
                contents[40] = Convert.ToInt32(button40.Content);
                contents[41] = Convert.ToInt32(button41.Content);
                contents[42] = Convert.ToInt32(button42.Content);
                contents[43] = Convert.ToInt32(button43.Content);
                contents[44] = Convert.ToInt32(button44.Content);
                contents[45] = Convert.ToInt32(button45.Content);
                contents[46] = Convert.ToInt32(button46.Content);
                contents[47] = Convert.ToInt32(button47.Content);
                contents[48] = Convert.ToInt32(button48.Content);
                contents[49] = Convert.ToInt32(button49.Content);
                contents[50] = Convert.ToInt32(button50.Content);
                contents[51] = Convert.ToInt32(button51.Content);
                contents[52] = Convert.ToInt32(button52.Content);
                contents[53] = Convert.ToInt32(button53.Content);
                contents[54] = Convert.ToInt32(button54.Content);
                contents[55] = Convert.ToInt32(button55.Content);
                contents[56] = Convert.ToInt32(button56.Content);
                contents[57] = Convert.ToInt32(button57.Content);
                contents[58] = Convert.ToInt32(button58.Content);
                contents[59] = Convert.ToInt32(button59.Content);
                contents[60] = Convert.ToInt32(button60.Content);
                contents[61] = Convert.ToInt32(button61.Content);
                contents[62] = Convert.ToInt32(button62.Content);
                contents[63] = Convert.ToInt32(button63.Content);
                contents[64] = Convert.ToInt32(button64.Content);
                contents[65] = Convert.ToInt32(button65.Content);
                contents[66] = Convert.ToInt32(button66.Content);
                contents[67] = Convert.ToInt32(button67.Content);
                contents[68] = Convert.ToInt32(button68.Content);
                contents[69] = Convert.ToInt32(button69.Content);
                contents[70] = Convert.ToInt32(button70.Content);
                contents[71] = Convert.ToInt32(button71.Content);
                contents[72] = Convert.ToInt32(button72.Content);
                contents[73] = Convert.ToInt32(button73.Content);
                contents[74] = Convert.ToInt32(button74.Content);
                contents[75] = Convert.ToInt32(button75.Content);
                contents[76] = Convert.ToInt32(button76.Content);
                contents[77] = Convert.ToInt32(button77.Content);
                contents[78] = Convert.ToInt32(button78.Content);
                contents[79] = Convert.ToInt32(button79.Content);
                contents[80] = Convert.ToInt32(button80.Content);
                int[] matrixr1;
                int[] matrixr2;
                int[] matrixr3;
                int[] matrixr4;
                int[] matrixr5;
                int[] matrixr6;
                int[] matrixr7;
                int[] matrixr8;
                int[] matrixr9;
                matrixr1 = new int[9] { contents[0], contents[1], contents[2], contents[3], contents[4], contents[5], contents[6], contents[7], contents[8] };
                matrixr2 = new int[9] { contents[9], contents[10], contents[11], contents[12], contents[13], contents[14], contents[15], contents[16], contents[17] };
                matrixr3 = new int[9] { contents[18], contents[19], contents[20], contents[21], contents[22], contents[23], contents[24], contents[25], contents[26] };
                matrixr4 = new int[9] { contents[27], contents[28], contents[29], contents[30], contents[31], contents[32], contents[33], contents[34], contents[35] };
                matrixr5 = new int[9] { contents[36], contents[37], contents[38], contents[39], contents[40], contents[41], contents[42], contents[43], contents[44] };
                matrixr6 = new int[9] { contents[45], contents[46], contents[47], contents[48], contents[49], contents[50], contents[51], contents[52], contents[53] };
                matrixr7 = new int[9] { contents[54], contents[55], contents[56], contents[57], contents[58], contents[59], contents[60], contents[61], contents[62] };
                matrixr8 = new int[9] { contents[63], contents[64], contents[65], contents[66], contents[67], contents[68], contents[69], contents[70], contents[71] };
                matrixr9 = new int[9] { contents[72], contents[73], contents[74], contents[75], contents[76], contents[77], contents[78], contents[79], contents[80] };
                int sumr1 = count_diffrence(9, matrixr1);
                int sumr2 = count_diffrence(9, matrixr2);
                int sumr3 = count_diffrence(9, matrixr3);
                int sumr4 = count_diffrence(9, matrixr4);
                int sumr5 = count_diffrence(9, matrixr5);
                int sumr6 = count_diffrence(9, matrixr6);
                int sumr7 = count_diffrence(9, matrixr7);
                int sumr8 = count_diffrence(9, matrixr8);
                int sumr9 = count_diffrence(9, matrixr9);
                int sumR = sumr1 + sumr2 + sumr3 + sumr4 + sumr5 + sumr6 + sumr7 + sumr8 + sumr9;
                int[] matrixc1;
                int[] matrixc2;
                int[] matrixc3;
                int[] matrixc4;
                int[] matrixc5;
                int[] matrixc6;
                int[] matrixc7;
                int[] matrixc8;
                int[] matrixc9;
                matrixc1 = new int[9] { contents[0], contents[9], contents[18], contents[27], contents[36], contents[45], contents[54], contents[63], contents[72] };
                matrixc2 = new int[9] { contents[1], contents[10], contents[19], contents[28], contents[37], contents[46], contents[55], contents[64], contents[73] };
                matrixc3 = new int[9] { contents[2], contents[11], contents[20], contents[29], contents[38], contents[47], contents[56], contents[65], contents[74] };
                matrixc4 = new int[9] { contents[3], contents[12], contents[21], contents[30], contents[39], contents[48], contents[57], contents[66], contents[75] };
                matrixc5 = new int[9] { contents[4], contents[13], contents[22], contents[31], contents[40], contents[49], contents[58], contents[67], contents[76] };
                matrixc6 = new int[9] { contents[5], contents[14], contents[23], contents[32], contents[41], contents[50], contents[59], contents[68], contents[77] };
                matrixc7 = new int[9] { contents[6], contents[15], contents[24], contents[33], contents[42], contents[51], contents[60], contents[69], contents[78] };
                matrixc8 = new int[9] { contents[7], contents[16], contents[25], contents[34], contents[43], contents[52], contents[61], contents[70], contents[79] };
                matrixc9 = new int[9] { contents[8], contents[17], contents[26], contents[35], contents[44], contents[53], contents[62], contents[71], contents[80] };
                int sumc1 = count_diffrence(9, matrixc1);
                int sumc2 = count_diffrence(9, matrixc2);
                int sumc3 = count_diffrence(9, matrixc3);
                int sumc4 = count_diffrence(9, matrixc4);
                int sumc5 = count_diffrence(9, matrixc5);
                int sumc6 = count_diffrence(9, matrixc6);
                int sumc7 = count_diffrence(9, matrixc7);
                int sumc8 = count_diffrence(9, matrixc8);
                int sumc9 = count_diffrence(9, matrixc9);
                int sumC = sumc1 + sumc2 + sumc3 + sumc4 + sumc5 + sumc6 + sumc7 + sumc8 + sumc9;
                int[] matrixs1;
                int[] matrixs2;
                int[] matrixs3;
                int[] matrixs4;
                int[] matrixs5;
                int[] matrixs6;
                int[] matrixs7;
                int[] matrixs8;
                int[] matrixs9;
                matrixs1 = new int[9] { contents[0], contents[1], contents[2], contents[9], contents[10], contents[11], contents[18], contents[19], contents[20] };
                matrixs2 = new int[9] { contents[3], contents[4], contents[5], contents[12], contents[13], contents[14], contents[21], contents[22], contents[23] };
                matrixs3 = new int[9] { contents[6], contents[7], contents[8], contents[15], contents[16], contents[17], contents[24], contents[25], contents[26] };
                matrixs4 = new int[9] { contents[27], contents[28], contents[29], contents[36], contents[37], contents[38], contents[45], contents[46], contents[47] };
                matrixs5 = new int[9] { contents[30], contents[31], contents[32], contents[39], contents[40], contents[41], contents[48], contents[49], contents[50] };
                matrixs6 = new int[9] { contents[33], contents[34], contents[35], contents[42], contents[43], contents[44], contents[51], contents[52], contents[53] };
                matrixs7 = new int[9] { contents[54], contents[55], contents[56], contents[63], contents[64], contents[65], contents[72], contents[73], contents[74] };
                matrixs8 = new int[9] { contents[57], contents[58], contents[59], contents[66], contents[67], contents[68], contents[75], contents[76], contents[77] };
                matrixs9 = new int[9] { contents[60], contents[61], contents[62], contents[69], contents[70], contents[71], contents[78], contents[79], contents[80] };
                int sums1 = count_diffrence(9, matrixs1);
                int sums2 = count_diffrence(9, matrixs2);
                int sums3 = count_diffrence(9, matrixs3);
                int sums4 = count_diffrence(9, matrixs4);
                int sums5 = count_diffrence(9, matrixs5);
                int sums6 = count_diffrence(9, matrixs6);
                int sums7 = count_diffrence(9, matrixs7);
                int sums8 = count_diffrence(9, matrixs8);
                int sums9 = count_diffrence(9, matrixs9);
                int sumS = sums1 + sums2 + sums3 + sums4 + sums5 + sums6 + sums7 + sums8 + sums9;
                if (sumR == 9 && sumC == 9 && sumS == 9)
                {
                    int new_points = 0;
                    Windows.Storage.ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
                    Object value = roamingSettings.Values["punkty"];
                    if (value != null)
                    {
                        new_points = Convert.ToInt32(value.ToString());
                    }
                    new_points += 90;
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

        int find_numbers()
        {
            /* oblicza ilosc uzupelnionych liczb */
            Random percent = new Random();
            int random_percent = percent.Next(28, 36);
            int numbers = (random_percent * 81) / 100;
            return numbers;
        }

        void create_array(int numbers)
        {
            /* tworzy macierz uzupelnionych liczb */
            int[,] A = new int[9, 9];
            int i1, j1;
            for (i1 = 0; i1 < 9; i1++)
            {
                for (j1 = 0; j1 < 9; j1++)
                {
                    A[i1, j1] = 0;
                }
            }
            int _row_number, _row_number2, i, j, k;
            int try_row = 0;
            int l = 0;
            Random rand = new Random();
            _row_number = rand.Next(0, 9);
            int[] B;
            B = new int[9];
            while (try_row == 0)
            {
                for (i = 0; i < 9; i++)
                {
                    B[i] = rand.Next(1, 10);
                }
                try_row = count_diffrence(9, B);
            }
            for (j = 0; j < 9; j++)
            {
                A[_row_number, j] = B[j];
            }
            if (_row_number > 5)
            {
                _row_number2 = rand.Next(0, 6);
            }
            else
            {
                _row_number2 = rand.Next(_row_number + 3, 9);
            }
            for (k = 8; k > -1; k--, l++)
            {
                A[_row_number2, l] = A[_row_number, k];
            }
            int _col_num = rand.Next(0, 9);
            while (_col_num == 4)
            {
                _col_num = rand.Next(0, 9);
            }
            int tmp = A[_row_number2, 4];
            A[_row_number2, 4] = A[_row_number2, _col_num];
            A[_row_number2, _col_num] = tmp;
            int _col_num2 = rand.Next(0, 9);
            int[] colA;
            colA = new int[9];
            int try_col2 = 0;
            int i2, j2;
            while (try_col2 == 0)
            {
                for (i2 = 0; i2 < 9; i2++)
                {
                    if (A[i2, _col_num2] != 0)
                    {
                        colA[i2] = A[i2, _col_num2];
                    }
                    else
                    {
                        int tymc1 = rand.Next(1, 10);
                        if (_col_num2 < 3)
                        {
                            if (i2 < 3)
                            {
                                while (tymc1 == A[0, 0] || tymc1 == A[0, 1] || tymc1 == A[0, 2] || tymc1 == A[1, 0] || tymc1 == A[1, 1] || tymc1 == A[1, 2] || tymc1 == A[2, 0] || tymc1 == A[2, 1] || tymc1 == A[2, 2])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                            else if (i2 > 2 && i2 < 6)
                            {
                                while (tymc1 == A[3, 0] || tymc1 == A[3, 1] || tymc1 == A[3, 2] || tymc1 == A[4, 0] || tymc1 == A[4, 1] || tymc1 == A[4, 2] || tymc1 == A[5, 0] || tymc1 == A[5, 1] || tymc1 == A[5, 2])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                            else
                            {
                                while (tymc1 == A[6, 0] || tymc1 == A[6, 1] || tymc1 == A[6, 2] || tymc1 == A[7, 0] || tymc1 == A[7, 1] || tymc1 == A[7, 2] || tymc1 == A[8, 0] || tymc1 == A[8, 1] || tymc1 == A[8, 2])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                        }
                        else if (_col_num2 > 2 && _col_num2 < 6)
                        {
                            if (i2 < 3)
                            {
                                while (tymc1 == A[0, 3] || tymc1 == A[0, 4] || tymc1 == A[0, 5] || tymc1 == A[1, 3] || tymc1 == A[1, 4] || tymc1 == A[1, 5] || tymc1 == A[2, 3] || tymc1 == A[2, 4] || tymc1 == A[2, 5])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                            else if (i2 > 2 && i2 < 6)
                            {
                                while (tymc1 == A[3, 3] || tymc1 == A[3, 4] || tymc1 == A[3, 5] || tymc1 == A[4, 3] || tymc1 == A[4, 4] || tymc1 == A[4, 5] || tymc1 == A[5, 3] || tymc1 == A[5, 4] || tymc1 == A[5, 5])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                            else
                            {
                                while (tymc1 == A[6, 3] || tymc1 == A[6, 4] || tymc1 == A[6, 5] || tymc1 == A[7, 3] || tymc1 == A[7, 4] || tymc1 == A[7, 5] || tymc1 == A[8, 3] || tymc1 == A[8, 4] || tymc1 == A[8, 5])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                        }
                        else
                        {
                            if (i2 < 3)
                            {
                                while (tymc1 == A[0, 6] || tymc1 == A[0, 7] || tymc1 == A[0, 8] || tymc1 == A[1, 6] || tymc1 == A[1, 7] || tymc1 == A[1, 8] || tymc1 == A[2, 6] || tymc1 == A[2, 7] || tymc1 == A[2, 8])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                            else if (i2 > 2 && i2 < 6)
                            {
                                while (tymc1 == A[3, 6] || tymc1 == A[3, 7] || tymc1 == A[3, 8] || tymc1 == A[4, 6] || tymc1 == A[4, 7] || tymc1 == A[4, 8] || tymc1 == A[5, 6] || tymc1 == A[5, 7] || tymc1 == A[5, 8])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                            else
                            {
                                while (tymc1 == A[6, 6] || tymc1 == A[6, 7] || tymc1 == A[6, 8] || tymc1 == A[7, 6] || tymc1 == A[7, 7] || tymc1 == A[7, 8] || tymc1 == A[8, 6] || tymc1 == A[8, 7] || tymc1 == A[8, 8])
                                {
                                    tymc1 = rand.Next(1, 10);
                                }
                            }
                        }
                        colA[i2] = tymc1;
                    }
                }
                try_col2 = count_diffrence(9, colA);
            }
            for (j2 = 0; j2 < 9; j2++)
            {
                A[j2, _col_num2] = colA[j2];
            }
            int _col_num3;
            if (_col_num2 > 5)
            {
                _col_num3 = rand.Next(0, 6);
            }
            else
            {
                _col_num3 = rand.Next(_col_num2 + 3, 9);
            }
            int[] colB;
            colB = new int[9];
            int try_col3 = 0;
            int i3, j3;
            while (try_col3 == 0)
            {
                for (i3 = 0; i3 < 9; i3++)
                {
                    if (A[i3, _col_num3] != 0)
                    {
                        colB[i3] = A[i3, _col_num3];
                    }
                    else
                    {
                        int tymc = rand.Next(1, 10);
                        if (_col_num3 < 3)
                        {
                            if (i3 < 3)
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[0, 0] || tymc == A[0, 1] || tymc == A[0, 2] || tymc == A[1, 0] || tymc == A[1, 1] || tymc == A[1, 2] || tymc == A[2, 0] || tymc == A[2, 1] || tymc == A[2, 2])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                            else if (i3 > 2 && i3 < 6)
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[3, 0] || tymc == A[3, 1] || tymc == A[3, 2] || tymc == A[4, 0] || tymc == A[4, 1] || tymc == A[4, 2] || tymc == A[5, 0] || tymc == A[5, 1] || tymc == A[5, 2])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                            else
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[6, 0] || tymc == A[6, 1] || tymc == A[6, 2] || tymc == A[7, 0] || tymc == A[7, 1] || tymc == A[7, 2] || tymc == A[8, 0] || tymc == A[8, 1] || tymc == A[8, 2])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                        }
                        else if (_col_num3 > 2 && _col_num3 < 6)
                        {
                            if (i3 < 3)
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[0, 3] || tymc == A[0, 4] || tymc == A[0, 5] || tymc == A[1, 3] || tymc == A[1, 4] || tymc == A[1, 5] || tymc == A[2, 3] || tymc == A[2, 4] || tymc == A[2, 5])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                            else if (i3 > 2 && i3 < 6)
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[3, 3] || tymc == A[3, 4] || tymc == A[3, 5] || tymc == A[4, 3] || tymc == A[4, 4] || tymc == A[4, 5] || tymc == A[5, 3] || tymc == A[5, 4] || tymc == A[5, 5])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                            else
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[6, 3] || tymc == A[6, 4] || tymc == A[6, 5] || tymc == A[7, 3] || tymc == A[7, 4] || tymc == A[7, 5] || tymc == A[8, 3] || tymc == A[8, 4] || tymc == A[8, 5])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                        }
                        else
                        {
                            if (i3 < 3)
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[0, 6] || tymc == A[0, 7] || tymc == A[0, 8] || tymc == A[1, 6] || tymc == A[1, 7] || tymc == A[1, 8] || tymc == A[2, 6] || tymc == A[2, 7] || tymc == A[2, 8])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                            else if (i3 > 2 && i3 < 6)
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[3, 6] || tymc == A[3, 7] || tymc == A[3, 8] || tymc == A[4, 6] || tymc == A[4, 7] || tymc == A[4, 8] || tymc == A[5, 6] || tymc == A[5, 7] || tymc == A[5, 8])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                            else
                            {
                                while (tymc == A[i3, _col_num2] || tymc == A[6, 6] || tymc == A[6, 7] || tymc == A[6, 8] || tymc == A[7, 6] || tymc == A[7, 7] || tymc == A[7, 8] || tymc == A[8, 6] || tymc == A[8, 7] || tymc == A[8, 8])
                                {
                                    tymc = rand.Next(1, 10);
                                }
                            }
                        }
                        colB[i3] = tymc;
                    }
                }
                try_col3 = count_diffrence(9, colB);
            }
            for (j3 = 0; j3 < 9; j3++)
            {
                A[j3, _col_num3] = colB[j3];
            }
            int wrong_numbers = 36 - numbers;
            if (wrong_numbers < 0)
            {
                wrong_numbers *= -1;
            }
            while (wrong_numbers != 0)
            {
                int _col_number = rand.Next(0, 9);
                int _row_number3 = rand.Next(0, 9);
                if (A[_row_number3, _col_number] != 0)
                {
                    A[_row_number3, _col_number] = 0;
                    wrong_numbers--;
                }
            }
            if (A[0, 0] != 0)
            {
                button0.Content = A[0, 0].ToString();
                button0.FontSize = 18;
            }
            else
            {
                button0.Content = "";
            }
            if (A[0, 1] != 0)
            {
                button1.Content = A[0, 1].ToString();
                button1.FontSize = 18;
            }
            else
            {
                button1.Content = "";
            }
            if (A[0, 2] != 0)
            {
                button2.Content = A[0, 2].ToString();
                button2.FontSize = 18;
            }
            else
            {
                button2.Content = "";
            }
            if (A[0, 3] != 0)
            {
                button3.Content = A[0, 3].ToString();
                button3.FontSize = 18;
            }
            else
            {
                button3.Content = "";
            }
            if (A[0, 4] != 0)
            {
                button4.Content = A[0, 4].ToString();
                button4.FontSize = 18;
            }
            else
            {
                button4.Content = "";
            }
            if (A[0, 5] != 0)
            {
                button5.Content = A[0, 5].ToString();
                button5.FontSize = 18;
            }
            else
            {
                button5.Content = "";
            }
            if (A[0, 6] != 0)
            {
                button6.Content = A[0, 6].ToString();
                button6.FontSize = 18;
            }
            else
            {
                button6.Content = "";
            }
            if (A[0, 7] != 0)
            {
                button7.Content = A[0, 7].ToString();
                button7.FontSize = 18;
            }
            else
            {
                button7.Content = "";
            }
            if (A[0, 8] != 0)
            {
                button8.Content = A[0, 8].ToString();
                button8.FontSize = 18;
            }
            else
            {
                button8.Content = "";
            }
            if (A[1, 0] != 0)
            {
                button9.Content = A[1, 0].ToString();
                button9.FontSize = 18;
            }
            else
            {
                button9.Content = "";
            }
            if (A[1, 1] != 0)
            {
                button10.Content = A[1, 1].ToString();
                button10.FontSize = 18;
            }
            else
            {
                button10.Content = "";
            }
            if (A[1, 2] != 0)
            {
                button11.Content = A[1, 2].ToString();
                button11.FontSize = 18;
            }
            else
            {
                button11.Content = "";
            }
            if (A[1, 3] != 0)
            {
                button12.Content = A[1, 3].ToString();
                button12.FontSize = 18;
            }
            else
            {
                button12.Content = "";
            }
            if (A[1, 4] != 0)
            {
                button13.Content = A[1, 4].ToString();
                button13.FontSize = 18;
            }
            else
            {
                button13.Content = "";
            }
            if (A[1, 5] != 0)
            {
                button14.Content = A[1, 5].ToString();
                button14.FontSize = 18;
            }
            else
            {
                button14.Content = "";
            }
            if (A[1, 6] != 0)
            {
                button15.Content = A[1, 6].ToString();
                button15.FontSize = 18;
            }
            else
            {
                button15.Content = "";
            }
            if (A[1, 7] != 0)
            {
                button16.Content = A[1, 7].ToString();
                button16.FontSize = 18;
            }
            else
            {
                button16.Content = "";
            }
            if (A[1, 8] != 0)
            {
                button17.Content = A[1, 8].ToString();
                button17.FontSize = 18;
            }
            else
            {
                button17.Content = "";
            }
            if (A[2, 0] != 0)
            {
                button18.Content = A[2, 0].ToString();
                button18.FontSize = 18;
            }
            else
            {
                button18.Content = "";
            }
            if (A[2, 1] != 0)
            {
                button19.Content = A[2, 1].ToString();
                button19.FontSize = 18;
            }
            else
            {
                button19.Content = "";
            }
            if (A[2, 2] != 0)
            {
                button20.Content = A[2, 2].ToString();
                button20.FontSize = 18;
            }
            else
            {
                button20.Content = "";
            }
            if (A[2, 3] != 0)
            {
                button21.Content = A[2, 3].ToString();
                button21.FontSize = 18;
            }
            else
            {
                button21.Content = "";
            }
            if (A[2, 4] != 0)
            {
                button22.Content = A[2, 4].ToString();
                button22.FontSize = 18;
            }
            else
            {
                button22.Content = "";
            }
            if (A[2, 5] != 0)
            {
                button23.Content = A[2, 5].ToString();
                button23.FontSize = 18;
            }
            else
            {
                button23.Content = "";
            }
            if (A[2, 6] != 0)
            {
                button24.Content = A[2, 6].ToString();
                button24.FontSize = 18;
            }
            else
            {
                button24.Content = "";
            }
            if (A[2, 7] != 0)
            {
                button25.Content = A[2, 7].ToString();
                button25.FontSize = 18;
            }
            else
            {
                button25.Content = "";
            }
            if (A[2, 8] != 0)
            {
                button26.Content = A[2, 8].ToString();
                button26.FontSize = 18;
            }
            else
            {
                button26.Content = "";
            }
            if (A[3, 0] != 0)
            {
                button27.Content = A[3, 0].ToString();
                button27.FontSize = 18;
            }
            else
            {
                button27.Content = "";
            }
            if (A[3, 1] != 0)
            {
                button28.Content = A[3, 1].ToString();
                button28.FontSize = 18;
            }
            else
            {
                button28.Content = "";
            }
            if (A[3, 2] != 0)
            {
                button29.Content = A[3, 2].ToString();
                button29.FontSize = 18;
            }
            else
            {
                button29.Content = "";
            }
            if (A[3, 3] != 0)
            {
                button30.Content = A[3, 3].ToString();
                button30.FontSize = 18;
            }
            else
            {
                button30.Content = "";
            }
            if (A[3, 4] != 0)
            {
                button31.Content = A[3, 4].ToString();
                button31.FontSize = 18;
            }
            else
            {
                button31.Content = "";
            }
            if (A[3, 5] != 0)
            {
                button32.Content = A[3, 5].ToString();
                button32.FontSize = 18;
            }
            else
            {
                button32.Content = "";
            }
            if (A[3, 6] != 0)
            {
                button33.Content = A[3, 6].ToString();
                button33.FontSize = 18;
            }
            else
            {
                button33.Content = "";
            }
            if (A[3, 7] != 0)
            {
                button34.Content = A[3, 7].ToString();
                button34.FontSize = 18;
            }
            else
            {
                button34.Content = "";
            }
            if (A[3, 8] != 0)
            {
                button35.Content = A[3, 8].ToString();
                button35.FontSize = 18;
            }
            else
            {
                button35.Content = "";
            }
            if (A[4, 0] != 0)
            {
                button36.Content = A[4, 0].ToString();
                button36.FontSize = 18;
            }
            else
            {
                button36.Content = "";
            }
            if (A[4, 1] != 0)
            {
                button37.Content = A[4, 1].ToString();
                button37.FontSize = 18;
            }
            else
            {
                button37.Content = "";
            }
            if (A[4, 2] != 0)
            {
                button38.Content = A[4, 2].ToString();
                button38.FontSize = 18;
            }
            else
            {
                button38.Content = "";
            }
            if (A[4, 3] != 0)
            {
                button39.Content = A[4, 3].ToString();
                button39.FontSize = 18;
            }
            else
            {
                button39.Content = "";
            }
            if (A[4, 4] != 0)
            {
                button40.Content = A[4, 4].ToString();
                button40.FontSize = 18;
            }
            else
            {
                button40.Content = "";
            }
            if (A[4, 5] != 0)
            {
                button41.Content = A[4, 5].ToString();
                button41.FontSize = 18;
            }
            else
            {
                button41.Content = "";
            }
            if (A[4, 6] != 0)
            {
                button42.Content = A[4, 6].ToString();
                button42.FontSize = 18;
            }
            else
            {
                button42.Content = "";
            }
            if (A[4, 7] != 0)
            {
                button43.Content = A[4, 7].ToString();
                button43.FontSize = 18;
            }
            else
            {
                button43.Content = "";
            }
            if (A[4, 8] != 0)
            {
                button44.Content = A[4, 8].ToString();
                button44.FontSize = 18;
            }
            else
            {
                button44.Content = "";
            }
            if (A[5, 0] != 0)
            {
                button45.Content = A[5, 0].ToString();
                button45.FontSize = 18;
            }
            else
            {
                button45.Content = "";
            }
            if (A[5, 1] != 0)
            {
                button46.Content = A[5, 1].ToString();
                button46.FontSize = 18;
            }
            else
            {
                button46.Content = "";
            }
            if (A[5, 2] != 0)
            {
                button47.Content = A[5, 2].ToString();
                button47.FontSize = 18;
            }
            else
            {
                button47.Content = "";
            }
            if (A[5, 3] != 0)
            {
                button48.Content = A[5, 3].ToString();
                button48.FontSize = 18;
            }
            else
            {
                button48.Content = "";
            }
            if (A[5, 4] != 0)
            {
                button49.Content = A[5, 4].ToString();
                button49.FontSize = 18;
            }
            else
            {
                button49.Content = "";
            }
            if (A[5, 5] != 0)
            {
                button50.Content = A[5, 5].ToString();
                button50.FontSize = 18;
            }
            else
            {
                button50.Content = "";
            }
            if (A[5, 6] != 0)
            {
                button51.Content = A[5, 6].ToString();
                button51.FontSize = 18;
            }
            else
            {
                button51.Content = "";
            }
            if (A[5, 7] != 0)
            {
                button52.Content = A[5, 7].ToString();
                button52.FontSize = 18;
            }
            else
            {
                button52.Content = "";
            }
            if (A[5, 8] != 0)
            {
                button53.Content = A[5, 8].ToString();
                button53.FontSize = 18;
            }
            else
            {
                button53.Content = "";
            }
            if (A[6, 0] != 0)
            {
                button54.Content = A[6, 0].ToString();
                button54.FontSize = 18;
            }
            else
            {
                button54.Content = "";
            }
            if (A[6, 1] != 0)
            {
                button55.Content = A[6, 1].ToString();
                button55.FontSize = 18;
            }
            else
            {
                button55.Content = "";
            }
            if (A[6, 2] != 0)
            {
                button56.Content = A[6, 2].ToString();
                button56.FontSize = 18;
            }
            else
            {
                button56.Content = "";
            }
            if (A[6, 3] != 0)
            {
                button57.Content = A[6, 3].ToString();
                button57.FontSize = 18;
            }
            else
            {
                button57.Content = "";
            }
            if (A[6, 4] != 0)
            {
                button58.Content = A[6, 4].ToString();
                button58.FontSize = 18;
            }
            else
            {
                button58.Content = "";
            }
            if (A[6, 5] != 0)
            {
                button59.Content = A[6, 5].ToString();
                button59.FontSize = 18;
            }
            else
            {
                button59.Content = "";
            }
            if (A[6, 6] != 0)
            {
                button60.Content = A[6, 6].ToString();
                button60.FontSize = 18;
            }
            else
            {
                button60.Content = "";
            }
            if (A[6, 7] != 0)
            {
                button61.Content = A[6, 7].ToString();
                button61.FontSize = 18;
            }
            else
            {
                button61.Content = "";
            }
            if (A[6, 8] != 0)
            {
                button62.Content = A[6, 8].ToString();
                button62.FontSize = 18;
            }
            else
            {
                button62.Content = "";
            }
            if (A[7, 0] != 0)
            {
                button63.Content = A[7, 0].ToString();
                button63.FontSize = 18;
            }
            else
            {
                button63.Content = "";
            }
            if (A[7, 1] != 0)
            {
                button64.Content = A[7, 1].ToString();
                button64.FontSize = 18;
            }
            else
            {
                button64.Content = "";
            }
            if (A[7, 2] != 0)
            {
                button65.Content = A[7, 2].ToString();
                button65.FontSize = 18;
            }
            else
            {
                button65.Content = "";
            }
            if (A[7, 3] != 0)
            {
                button66.Content = A[7, 3].ToString();
                button66.FontSize = 18;
            }
            else
            {
                button66.Content = "";
            }
            if (A[7, 4] != 0)
            {
                button67.Content = A[7, 4].ToString();
                button67.FontSize = 18;
            }
            else
            {
                button67.Content = "";
            }
            if (A[7, 5] != 0)
            {
                button68.Content = A[7, 5].ToString();
                button68.FontSize = 18;
            }
            else
            {
                button68.Content = "";
            }
            if (A[7, 6] != 0)
            {
                button69.Content = A[7, 6].ToString();
                button69.FontSize = 18;
            }
            else
            {
                button69.Content = "";
            }
            if (A[7, 7] != 0)
            {
                button70.Content = A[7, 7].ToString();
                button70.FontSize = 18;
            }
            else
            {
                button70.Content = "";
            }
            if (A[7, 8] != 0)
            {
                button71.Content = A[7, 8].ToString();
                button71.FontSize = 18;
            }
            else
            {
                button71.Content = "";
            }
            if (A[8, 0] != 0)
            {
                button72.Content = A[8, 0].ToString();
                button72.FontSize = 18;
            }
            else
            {
                button72.Content = "";
            }
            if (A[8, 1] != 0)
            {
                button73.Content = A[8, 1].ToString();
                button73.FontSize = 18;
            }
            else
            {
                button73.Content = "";
            }
            if (A[8, 2] != 0)
            {
                button74.Content = A[8, 2].ToString();
                button74.FontSize = 18;
            }
            else
            {
                button74.Content = "";
            }
            if (A[8, 3] != 0)
            {
                button75.Content = A[8, 3].ToString();
                button75.FontSize = 18;
            }
            else
            {
                button75.Content = "";
            }
            if (A[8, 4] != 0)
            {
                button76.Content = A[8, 4].ToString();
                button76.FontSize = 18;
            }
            else
            {
                button76.Content = "";
            }
            if (A[8, 5] != 0)
            {
                button77.Content = A[8, 5].ToString();
                button77.FontSize = 18;
            }
            else
            {
                button77.Content = "";
            }
            if (A[8, 6] != 0)
            {
                button78.Content = A[8, 6].ToString();
                button78.FontSize = 18;
            }
            else
            {
                button78.Content = "";
            }
            if (A[8, 7] != 0)
            {
                button79.Content = A[8, 7].ToString();
                button79.FontSize = 18;
            }
            else
            {
                button79.Content = "";
            }
            if (A[8, 8] != 0)
            {
                button80.Content = A[8, 8].ToString();
                button80.FontSize = 18;
            }
            else
            {
                button80.Content = "";
            }
        }

        void reload_table()
        {
            /* resetuje wartosci czcionki przyciskow na automatyczna */
            button0.FontSize = 13;
            button1.FontSize = 13;
            button2.FontSize = 13;
            button3.FontSize = 13;
            button4.FontSize = 13;
            button5.FontSize = 13;
            button6.FontSize = 13;
            button7.FontSize = 13;
            button8.FontSize = 13;
            button9.FontSize = 13;
            button10.FontSize = 13;
            button11.FontSize = 13;
            button12.FontSize = 13;
            button13.FontSize = 13;
            button14.FontSize = 13;
            button15.FontSize = 13;
            button16.FontSize = 13;
            button17.FontSize = 13;
            button18.FontSize = 13;
            button19.FontSize = 13;
            button20.FontSize = 13;
            button21.FontSize = 13;
            button22.FontSize = 13;
            button23.FontSize = 13;
            button24.FontSize = 13;
            button25.FontSize = 13;
            button26.FontSize = 13;
            button27.FontSize = 13;
            button28.FontSize = 13;
            button29.FontSize = 13;
            button30.FontSize = 13;
            button31.FontSize = 13;
            button32.FontSize = 13;
            button33.FontSize = 13;
            button34.FontSize = 13;
            button35.FontSize = 13;
            button36.FontSize = 13;
            button37.FontSize = 13;
            button38.FontSize = 13;
            button39.FontSize = 13;
            button40.FontSize = 13;
            button41.FontSize = 13;
            button42.FontSize = 13;
            button43.FontSize = 13;
            button44.FontSize = 13;
            button45.FontSize = 13;
            button46.FontSize = 13;
            button47.FontSize = 13;
            button48.FontSize = 13;
            button49.FontSize = 13;
            button50.FontSize = 13;
            button51.FontSize = 13;
            button52.FontSize = 13;
            button53.FontSize = 13;
            button54.FontSize = 13;
            button55.FontSize = 13;
            button56.FontSize = 13;
            button57.FontSize = 13;
            button58.FontSize = 13;
            button59.FontSize = 13;
            button60.FontSize = 13;
            button61.FontSize = 13;
            button62.FontSize = 13;
            button63.FontSize = 13;
            button64.FontSize = 13;
            button65.FontSize = 13;
            button66.FontSize = 13;
            button67.FontSize = 13;
            button68.FontSize = 13;
            button69.FontSize = 13;
            button70.FontSize = 13;
            button71.FontSize = 13;
            button72.FontSize = 13;
            button73.FontSize = 13;
            button74.FontSize = 13;
            button75.FontSize = 13;
            button76.FontSize = 13;
            button77.FontSize = 13;
            button78.FontSize = 13;
            button79.FontSize = 13;
            button80.FontSize = 13;
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
