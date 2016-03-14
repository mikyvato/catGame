using System;
using Android.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using System.Collections.Generic;
using Android.OS;
using System.Linq;

namespace catGame
{
    [Activity(Label = "catGame", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        #region Declarar Componentes
        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;
        Button btn9;
        TextView txt1;
        #endregion


        protected int[] toque = new int[50];
        protected int contador = 0;
        protected int cantToq = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            #region Inicializar Botones
            btn1 = FindViewById<Button>(Resource.Id.button1);
            btn2 = FindViewById<Button>(Resource.Id.button2);
            btn3 = FindViewById<Button>(Resource.Id.button3);
            btn4 = FindViewById<Button>(Resource.Id.button4);
            btn5 = FindViewById<Button>(Resource.Id.button5);
            btn6 = FindViewById<Button>(Resource.Id.button6);
            btn7 = FindViewById<Button>(Resource.Id.button7);
            btn8 = FindViewById<Button>(Resource.Id.button8);
            btn9 = FindViewById<Button>(Resource.Id.button9);
            #endregion

            #region Inicializar TextView
            txt1 = FindViewById<TextView>(Resource.Id.textView1);
            #endregion

            #region Inicializar Evento
            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
            btn5.Click += Btn5_Click;
            btn6.Click += Btn6_Click;
            btn7.Click += Btn7_Click;
            btn8.Click += Btn8_Click;
            btn9.Click += Btn9_Click;
            #endregion

            #region Inicializar Buckground
            btn1.SetBackgroundResource(Resource.Drawable.grey);
            btn2.SetBackgroundResource(Resource.Drawable.dark);
            btn3.SetBackgroundResource(Resource.Drawable.red);
            btn4.SetBackgroundResource(Resource.Drawable.orange);
            btn5.SetBackgroundResource(Resource.Drawable.yellow);
            btn6.SetBackgroundResource(Resource.Drawable.green);
            btn7.SetBackgroundResource(Resource.Drawable.turquoise);
            btn8.SetBackgroundResource(Resource.Drawable.indigo);
            btn9.SetBackgroundResource(Resource.Drawable.purple);
            txt1.SetText("Turno Jugador 1".ToString(),null);
            #endregion

        }

        private async void Btn9_Click(object sender, EventArgs e)
        {
            btn9.SetBackgroundResource(Resource.Drawable.purple2);
            await Task.Delay(5);
            btn9.SetBackgroundResource(Resource.Drawable.purple);
            controlar(9);
        }

        private async void Btn8_Click(object sender, EventArgs e)
        {
            btn8.SetBackgroundResource(Resource.Drawable.indigo2);
            await Task.Delay(5);
            btn8.SetBackgroundResource(Resource.Drawable.indigo);
            controlar(8);
        }

        private async void Btn7_Click(object sender, EventArgs e)
        {
            btn7.SetBackgroundResource(Resource.Drawable.turquoise2);
            await Task.Delay(5);
            btn7.SetBackgroundResource(Resource.Drawable.turquoise);
            controlar(7);
        }

        private async void Btn6_Click(object sender, EventArgs e)
        {
            btn6.SetBackgroundResource(Resource.Drawable.green2);
            await Task.Delay(5);
            btn6.SetBackgroundResource(Resource.Drawable.green);
            controlar(6);
        }

        private async void Btn5_Click(object sender, EventArgs e)
        {
            btn5.SetBackgroundResource(Resource.Drawable.yellow2);
            await Task.Delay(5);
            btn5.SetBackgroundResource(Resource.Drawable.yellow);
            controlar(5);
        }

        private async void Btn4_Click(object sender, EventArgs e)
        {
            btn4.SetBackgroundResource(Resource.Drawable.orange2);
            await Task.Delay(5);
            btn4.SetBackgroundResource(Resource.Drawable.orange);
            controlar(4);
        }

        private async void Btn3_Click(object sender, EventArgs e)
        {
            btn3.SetBackgroundResource(Resource.Drawable.red2);
            await Task.Delay(5);
            btn3.SetBackgroundResource(Resource.Drawable.red);
            controlar(3);
        }

        private async void Btn2_Click(object sender, EventArgs e)
        {
            btn2.SetBackgroundResource(Resource.Drawable.dark2);
            await Task.Delay(5);
            btn2.SetBackgroundResource(Resource.Drawable.dark);
            controlar(2);
        }

        private async void Btn1_Click(object sender, EventArgs e)
        {
            btn1.SetBackgroundResource(Resource.Drawable.grey2);
            await Task.Delay(5);
            btn1.SetBackgroundResource(Resource.Drawable.grey);
            controlar(1);
        }

        public void controlar(byte num)
        {
            if (cantToq == 0)
            {
                toque.SetValue(num, cantToq);
                changePlayer();
                cantToq++;
            }
            else {
                if (cantToq == contador)
                {
                    toque.SetValue(num, contador);
                    cantToq++;
                    changePlayer(); // Cambiar Jugador inicializar contador en cero
                    contador = 0;
                }
                else
                {
                    if (toque[contador] != num)
                    {
                        txt1.SetText("Juagor Pierde".ToString(), null);
                        contador = 0;
                    }
                    else {
                        contador++;
                    }
                }                
            }            
        }

        public void changePlayer()
        {
            if (contador == 0 || contador % 2 == 0)
            {
                txt1.SetText("Turno Jugador 2".ToString(), null);
            }
            else {
                txt1.SetText("Turno Jugador 1".ToString(), null);
            }
        }
    }
}

