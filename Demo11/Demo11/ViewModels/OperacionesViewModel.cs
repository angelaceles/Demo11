using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo11.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {
        int valorA;
        public int ValorA
        { 
            get { return valorA; }
            set 
            { if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }

        int valorB;
        public int ValorB 
        {
            get { return valorB; } 
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoS;
        public int ResultadoS
        {
            get { return resultadoS; } 
            set
            {
                if (resultadoS != value)
                {
                    resultadoS = value;
                    OnPropertyChanged();
                }
            }
        }
        int resultadoR;
        public int ResultadoR
        {
            get { return resultadoR; }
            set
            {
                if (resultadoR != value)
                {
                    resultadoR = value;
                    OnPropertyChanged();
                }
            }
        }
        int resultadoM;
        public int ResultadoM
        {
            get { return resultadoM; }
            set
            {
                if (resultadoM != value)
                {
                    resultadoM = value;
                    OnPropertyChanged();
                }
            }
        }
        int resultadoD;
        public int ResultadoD
        {
            get { return resultadoD; }
            set
            {
                if (resultadoD != value)
                {
                    resultadoD = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand Sumar { get; set; }
        public ICommand Restar { get; set; }
        public ICommand Multiplicar { get; set; }
        public ICommand Dividir { get; set; }

        public OperacionesViewModel() 
        {
            Sumar = new Command(() =>
            {
                ResultadoS = ValorA + ValorB;
            });
            Restar = new Command(() =>
            {
                ResultadoR = ValorA - ValorB;
            });
            Multiplicar = new Command(() =>
            {
                ResultadoM = ValorA * ValorB;
            });
            Dividir = new Command(() =>
            {
                ResultadoD = ValorA / ValorB;
            });
        }
    }
}
