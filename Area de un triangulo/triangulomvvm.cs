using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_un_triangulo
{
    partial class triangulomvvm : ObservableObject
    {
        [ObservableProperty]
        public string lado1;

        [ObservableProperty]
        public string lado2;

        [ObservableProperty]
        public string lado3;

        [ObservableProperty]
        public string area;

        [RelayCommand]
        private void CalcularArea()
        {
            if (double.TryParse(Lado1, out double a) && double.TryParse(Lado2, out double b) && double.TryParse(Lado3, out double c))
            {
                if (a + b > c && a + c > b && b + c > a) 
                {
                    double s = (a + b + c) / 2;
                    double areaValue = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    Area = areaValue.ToString();
                }
                else
                {
                    Area = "Los lados que ingresaste no forman un triángulo válido";
                }
            }
            else
            {
                Area = "Ingresa los números válidos";
            }
        }
    }
}

