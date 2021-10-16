using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriaEsfera
{
    class GeoEsfera
    {
        private double PI;
        private double Raio;

        public GeoEsfera()
        {

        }
        public GeoEsfera(double Raio)
        {
            SetPi(3.144);
            SetRaio(Raio);
        }
        public double Vol_Esfera()
        {
            return (4 / 3) * GetPi() * (GetRaio()* GetRaio()* GetRaio());
        }
        public void SetRaio(double raio) => this.Raio = raio;
        public double GetRaio() => this.Raio;
        public double GetPi() => this.PI;
        private void SetPi(double PI) => this.PI = PI;
    }
}
