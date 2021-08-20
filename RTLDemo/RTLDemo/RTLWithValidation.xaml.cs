using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RTLDemo.ViewModels;

namespace RTLDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RTLWithValidation : ContentPage
    {
        public RTLWithValidation()
        {
            this.BindingContext = new ValidationsDemoVM();
            InitializeComponent();
        }
    }
}