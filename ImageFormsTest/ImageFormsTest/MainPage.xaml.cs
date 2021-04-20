using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageFormsTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TitleImage.BindingContext = this;
            TitleImage.SetBinding(ImageEffect.TextProperty, new Binding("Uri"));
        }
        public string Uri { get; set; } = "https://res.zzzmh.cn/origin/db995d90880411ebb6edd017c2d2eca2.jpg";
    }
}
