using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class llenadoRutas
    {
        public List<rutasRegiones> listaRutasRegiones = new List<rutasRegiones>() {
            new rutasRegiones(){ubicacionActual= "Metropolitana ", regionDestino = "Metropolitana ", probabilidad = 0.35 , distanciaRecorrer = 0},
            new rutasRegiones(){ubicacionActual= "Metropolitana ", regionDestino = "Central ", probabilidad = 0.3 , distanciaRecorrer = 63},
            new rutasRegiones(){ubicacionActual= "Metropolitana ", regionDestino = "SurOriente ", probabilidad = 0.15 , distanciaRecorrer = 124},
            new rutasRegiones(){ubicacionActual= "Metropolitana ", regionDestino = "NorOriente ", probabilidad = 0.2 , distanciaRecorrer = 241},
            new rutasRegiones(){ubicacionActual= "Norte ", regionDestino = "Norte ", probabilidad = 0.4 , distanciaRecorrer = 0},
            new rutasRegiones(){ubicacionActual= "Norte ", regionDestino = "Peten ", probabilidad = 0.4 , distanciaRecorrer = 147},
            new rutasRegiones(){ubicacionActual= "Norte ", regionDestino = "NorOriente ", probabilidad = 0.1 , distanciaRecorrer = 138},
            new rutasRegiones(){ubicacionActual= "Norte ", regionDestino = "NorOccidente ", probabilidad = 0.1 , distanciaRecorrer = 145},
            new rutasRegiones(){ubicacionActual= "NorOriente ", regionDestino = "NorOriente ", probabilidad = 0.2 , distanciaRecorrer = 0},
            new rutasRegiones(){ubicacionActual= "NorOriente ", regionDestino = "Metropolitana ", probabilidad = 0.3 , distanciaRecorrer = 241},
            new rutasRegiones(){ubicacionActual= "NorOriente ", regionDestino = "Norte ", probabilidad = 0.15 , distanciaRecorrer = 138},
            new rutasRegiones(){ubicacionActual= "NorOriente ", regionDestino = "SurOriente ", probabilidad = 0.05 , distanciaRecorrer = 231},
            new rutasRegiones(){ubicacionActual= "NorOriente ", regionDestino = "Peten ", probabilidad = 0.3 , distanciaRecorrer = 282},
            new rutasRegiones(){ubicacionActual= "SurOriente ", regionDestino = "SurOriente ", probabilidad = 0.4 , distanciaRecorrer = 0},
            new rutasRegiones(){ubicacionActual= "SurOriente ", regionDestino = "NorOriente ", probabilidad = 0.2 , distanciaRecorrer = 231},
            new rutasRegiones(){ubicacionActual= "SurOriente ", regionDestino = "Metropolitana ", probabilidad = 0.25 , distanciaRecorrer = 124},
            new rutasRegiones(){ubicacionActual= "SurOriente ", regionDestino = "Central ", probabilidad = 0.15 , distanciaRecorrer = 154},
            new rutasRegiones(){ubicacionActual= "Central ", regionDestino = "Central ", probabilidad = 0.35 , distanciaRecorrer = 0},
            new rutasRegiones(){ubicacionActual= "Central ", regionDestino = "Metropolitana ", probabilidad = 0.35 , distanciaRecorrer = 63},
            new rutasRegiones(){ubicacionActual= "Central ", regionDestino = "SurOriente ", probabilidad = 0.05 , distanciaRecorrer = 154},
            new rutasRegiones(){ubicacionActual= "Central ", regionDestino = "SurOccidente ", probabilidad = 0.15 , distanciaRecorrer = 155},
            new rutasRegiones(){ubicacionActual= "Central ", regionDestino = "NorOccidente ", probabilidad = 0.1 , distanciaRecorrer = 269},
            new rutasRegiones(){ubicacionActual= "SurOccidente ", regionDestino = "SurOccidente ", probabilidad = 0.35 , distanciaRecorrer = 0},
            new rutasRegiones(){ubicacionActual= "SurOccidente ", regionDestino = "NorOccidente ", probabilidad = 0.3 , distanciaRecorrer = 87},
            new rutasRegiones(){ubicacionActual= "SurOccidente ", regionDestino = "Central ", probabilidad = 0.35 , distanciaRecorrer = 155},
            new rutasRegiones(){ubicacionActual= "NorOccidente ", regionDestino = "NorOccidente ", probabilidad = 0.4 , distanciaRecorrer = 0},
            new rutasRegiones(){ubicacionActual= "NorOccidente ", regionDestino = "SurOccidente ", probabilidad = 0.3 , distanciaRecorrer = 87},
            new rutasRegiones(){ubicacionActual= "NorOccidente ", regionDestino = "Central ", probabilidad = 0.1 , distanciaRecorrer = 269},
            new rutasRegiones(){ubicacionActual= "NorOccidente ", regionDestino = "Norte ", probabilidad = 0.2 , distanciaRecorrer = 145},
            new rutasRegiones(){ubicacionActual= "Peten ", regionDestino = "Peten ", probabilidad = 0.5 , distanciaRecorrer = 0},
            new rutasRegiones(){ubicacionActual= "Peten ", regionDestino = "Norte ", probabilidad = 0.25 , distanciaRecorrer = 147},
            new rutasRegiones(){ubicacionActual= "Peten ", regionDestino = "NorOriente ", probabilidad = 0.25 , distanciaRecorrer = 282}
        };
    }
    class rutasRegiones
    {
        public string ubicacionActual;
        public string regionDestino;
        public double probabilidad;
        public double distanciaRecorrer;
    }
}
