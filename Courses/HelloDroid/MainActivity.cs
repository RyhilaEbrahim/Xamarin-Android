using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloDroid
{
    [Activity(Label = "My Calculator", MainLauncher = true, Icon = "@drawable/calculator")]
    public class MainActivity : Activity
    {
        int count = 1;
        private TextView _numbers;
        private string   display="";

        private Button _button1,
            _button2,
            _button3,
            _button4,
            _button5,
            _button6,
            _button7,
            _button8,
            _button9,
            _button10,
            _buttonPlus,
            _buttonMinus,
            _buttonDivide,
            _buttonMultiply,
            _buttonEqual,
            _buttonClear;

        private string _number1, _number2, _number3, _number4, _number5, _number6, _number7, _number8, _number9, _number0;

 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            _numbers = FindViewById<TextView>(Resource.Id.txtViewDisplay);
            _button1 = FindViewById<Button>(Resource.Id.btnNumber1);
            _button2 = FindViewById<Button>(Resource.Id.btnNumber2);
            _button3 = FindViewById<Button>(Resource.Id.btnNumber3);
            _button4 = FindViewById<Button>(Resource.Id.btnNumber4);
            _button5 = FindViewById<Button>(Resource.Id.btnNumber5);
            _button6 = FindViewById<Button>(Resource.Id.btnNumber6);
            _button7 = FindViewById<Button>(Resource.Id.btnNumber7);
            _button8 = FindViewById<Button>(Resource.Id.btnNumber8);
            _button9 = FindViewById<Button>(Resource.Id.btnNumber9);
            _buttonPlus = FindViewById<Button>(Resource.Id.btnPlus);
            _buttonMinus = FindViewById<Button>(Resource.Id.btnMinus);
            _buttonDivide = FindViewById<Button>(Resource.Id.btnDivide);
            _buttonMultiply = FindViewById<Button>(Resource.Id.btnMultiply);
            _button10 = FindViewById<Button>(Resource.Id.btnNumbe10);
            _buttonEqual = FindViewById<Button>(Resource.Id.btnEqual);
            _buttonClear = FindViewById<Button>(Resource.Id.btnClear);


            _button1.Click += delegate
            {
                _numbers.Text += "1";
                Toast.MakeText(this,"1",ToastLength.Long).Show();
            };
            _button2.Click += delegate
            {
                _numbers.Text += "2";
                Toast.MakeText(this,"2",ToastLength.Long).Show();
            };
            _button3.Click += delegate
            {
                _numbers.Text += "3";
                Toast.MakeText(this,"3",ToastLength.Long).Show();
            };
            _button4.Click += delegate
            {
                _numbers.Text += "4";
                Toast.MakeText(this,"4",ToastLength.Long).Show();
            };
            _button5.Click += delegate
            {
                _numbers.Text += "5";
                Toast.MakeText(this,"5",ToastLength.Long).Show();
            };
            _button6.Click += delegate
            {
                _numbers.Text += "6";
                Toast.MakeText(this,"6",ToastLength.Long).Show();
            };
            _button7.Click += delegate
            {
                _numbers.Text += "7";
                Toast.MakeText(this,"7",ToastLength.Long).Show();
            };
            _button8.Click += delegate
            {
                _numbers.Text += "8";
                Toast.MakeText(this,"8",ToastLength.Long).Show();
            };
            _button9.Click += delegate
            {
                _numbers.Text = "9";
                Toast.MakeText(this,"9",ToastLength.Long).Show();
            };
            _button10.Click += delegate
            {
                _numbers.Text += "10";
                Toast.MakeText(this,"10",ToastLength.Long).Show();
            };


            _button10.Click += delegate
            {
                _numbers.Text += "0";
                Toast.MakeText(this,"0",ToastLength.Long).Show();
            };
            _buttonPlus.Click += delegate
            {
                _numbers.Text += "+";
                Toast.MakeText(this,"+",ToastLength.Long).Show();
            };

            _buttonMinus.Click += delegate
            {
                _numbers.Text += "-";
                Toast.MakeText(this,"-",ToastLength.Long).Show();
            };

            _buttonDivide.Click += delegate
            {
                _numbers.Text += "/";
                Toast.MakeText(this,"/",ToastLength.Long).Show();
            };

            _buttonMultiply.Click += delegate
            {
                _numbers.Text += "*";
                Toast.MakeText(this,"*",ToastLength.Long).Show();
            };

            _buttonEqual.Click += delegate
            {
                
                Toast.MakeText(this,"Equal",ToastLength.Long).Show();
            };

            _buttonClear.Click += delegate
            {
                _numbers.Text = "";
                Toast.MakeText(this,"Clear",ToastLength.Long).Show();
            };
            
            _numbers.Text =display;

        }


    }
}

