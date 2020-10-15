using SimioAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class llenado
    {
        public List<servidores> listaServidores = new List<servidores>()
            {
                new servidores() { valorServer = 1, tipoValor = "Server", region =  "Region 1", nombre = "Metropolitana", y = 0, x = 0},
                new servidores() { valorServer = 2, tipoValor = "Server", region =  "Region 2", nombre = "Norte", y = -20, x = 5},
                new servidores() { valorServer = 3, tipoValor = "Server", region =  "Region 3", nombre = "NorOriente", y = -10, x = 30},
                new servidores() { valorServer = 4, tipoValor = "Server", region =  "Region 4", nombre = "SurOriente", y = 20, x = 15},
                new servidores() { valorServer = 5, tipoValor = "Server", region =  "Region 5", nombre = "Central", y = 20, x = -15},
                new servidores() { valorServer = 6, tipoValor = "Server", region =  "Region 6", nombre = "SurOccidente", y = 10, x = -40},
                new servidores() { valorServer = 7, tipoValor = "Server", region =  "Region 7", nombre = "NorOccidente", y = -20, x = -40},
                new servidores() { valorServer = 8, tipoValor = "Server", region =  "Region 8", nombre = "Peten", y = -50, x = 10}
             };

        public llenado()
        {

        }
    }
    class servidores
    {
        public int valorServer;
        public string tipoValor;
        public string region;
        public string nombre;
        public double x;
        public double y;
    }


}
