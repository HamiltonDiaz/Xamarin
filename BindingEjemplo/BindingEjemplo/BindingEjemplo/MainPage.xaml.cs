using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingEjemplo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Estudiantes NuevoEstudiante {get; set;}

        public MainPage()
        {
            NuevoEstudiante = new Estudiantes();
            NuevoEstudiante.NombreCompleto = "Hamilton Diaz Rubio";
            NuevoEstudiante.Email = "diaz3220@hotmail.com";
            BindingContext = NuevoEstudiante;
            InitializeComponent();
        }
    }
}
