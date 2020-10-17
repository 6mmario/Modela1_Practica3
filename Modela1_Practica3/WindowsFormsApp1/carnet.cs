using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimioAPI;
using SimioAPI.Extensions;
using SimioAPI.Graphics;
using Simio;
using Simio.SimioEnums;

namespace WindowsFormsApp1
{

    class llenarCarnet
    {
        private ISimioProject apiCarnet;
        private string ruta = "ModeloBase.spfx";
        private string rutaFinal = "Carnets.spfx";
        //variables
        private string[] warnings;
        private IModel model;
        private IIntelligentObjects intelligentObjects;

        public List<carnet> listaCarnet = new List<carnet>()
        {
            new carnet(){valor = 1, tipo = "TransferNode", numero = "2", x = -130, y = -40},
            new carnet(){valor = 2, tipo = "TransferNode", numero = "2", x = -110, y = -40},
            new carnet(){valor = 3, tipo = "TransferNode", numero = "2", x = -130, y = -20},
            new carnet(){valor = 4, tipo = "TransferNode", numero = "2", x = -110, y = -20},
            new carnet(){valor = 5, tipo = "TransferNode", numero = "2", x = -130, y = 0},
            new carnet(){valor = 6, tipo = "TransferNode", numero = "2", x = -110, y = 0},

            new carnet(){valor = 7, tipo = "TransferNode", numero = "0", x = -100, y = -40},
            new carnet(){valor = 8, tipo = "TransferNode", numero = "0", x = -80, y = -40},
            new carnet(){valor = 9, tipo = "TransferNode", numero = "0", x = -100, y = -20},
            new carnet(){valor = 10, tipo = "TransferNode", numero = "0", x = -80, y = -20},
            new carnet(){valor = 11, tipo = "TransferNode", numero = "0", x = -100, y = 0},
            new carnet(){valor = 12, tipo = "TransferNode", numero = "0", x = -80, y = 0},

            new carnet(){valor = 13, tipo = "TransferNode", numero = "1", x = -70, y = -20},
            new carnet(){valor = 14, tipo = "TransferNode", numero = "1", x = -50, y = -40},
            new carnet(){valor = 15, tipo = "TransferNode", numero = "1", x = -50, y = -20},
            new carnet(){valor = 16, tipo = "TransferNode", numero = "1", x = -50, y = 0},

            new carnet(){valor = 17, tipo = "TransferNode", numero = "2", x = -40, y = -40},
            new carnet(){valor = 18, tipo = "TransferNode", numero = "2", x = -20, y = -40},
            new carnet(){valor = 19, tipo = "TransferNode", numero = "2", x = -40, y = -20},
            new carnet(){valor = 20, tipo = "TransferNode", numero = "2", x = -20, y = -20},
            new carnet(){valor = 21, tipo = "TransferNode", numero = "2", x = -40, y = 0},
            new carnet(){valor = 22, tipo = "TransferNode", numero = "2", x = -20, y = 0},
            // centro
            new carnet(){valor = 23, tipo = "TransferNode", numero = "1", x = -10, y = -20},
            new carnet(){valor = 24, tipo = "TransferNode", numero = "1", x = 10, y = -40},
            new carnet(){valor = 25, tipo = "TransferNode", numero = "1", x = 10, y = -20},
            new carnet(){valor = 26, tipo = "TransferNode", numero = "1", x = 10, y = 0},

            new carnet(){valor = 27, tipo = "TransferNode", numero = "3", x = 20, y = -40},
            new carnet(){valor = 28, tipo = "TransferNode", numero = "3", x = 40, y = -40},
            new carnet(){valor = 29, tipo = "TransferNode", numero = "3", x = 20, y = -20},
            new carnet(){valor = 30, tipo = "TransferNode", numero = "3", x = 40, y = -20},
            new carnet(){valor = 31, tipo = "TransferNode", numero = "3", x = 20, y = 0},
            new carnet(){valor = 32, tipo = "TransferNode", numero = "3", x = 40, y = 0},

            new carnet(){valor = 33, tipo = "TransferNode", numero = "2", x = 50, y = -40},
            new carnet(){valor = 34, tipo = "TransferNode", numero = "2", x = 70, y = -40},
            new carnet(){valor = 35, tipo = "TransferNode", numero = "2", x = 50, y = -20},
            new carnet(){valor = 36, tipo = "TransferNode", numero = "2", x = 70, y = -20},
            new carnet(){valor = 37, tipo = "TransferNode", numero = "2", x = 50, y = 0},
            new carnet(){valor = 38, tipo = "TransferNode", numero = "2", x = 70, y = 0},

            new carnet(){valor = 39, tipo = "TransferNode", numero = "8", x = 80, y = -40},
            new carnet(){valor = 40, tipo = "TransferNode", numero = "8", x = 100, y = -40},
            new carnet(){valor = 41, tipo = "TransferNode", numero = "8", x = 80, y = -20},
            new carnet(){valor = 42, tipo = "TransferNode", numero = "8", x = 100, y = -20},
            new carnet(){valor = 43, tipo = "TransferNode", numero = "8", x = 80, y = 0},
            new carnet(){valor = 44, tipo = "TransferNode", numero = "8", x = 100, y = 0},

            new carnet(){valor = 45, tipo = "TransferNode", numero = "3", x = 110, y = -40},
            new carnet(){valor = 46, tipo = "TransferNode", numero = "3", x = 130, y = -40},
            new carnet(){valor = 47, tipo = "TransferNode", numero = "3", x = 110, y = -20},
            new carnet(){valor = 48, tipo = "TransferNode", numero = "3", x = 130, y = -20},
            new carnet(){valor = 49, tipo = "TransferNode", numero = "3", x = 110, y = 0},
            new carnet(){valor = 50, tipo = "TransferNode", numero = "3", x = 130, y = 0},



            new carnet(){valor = 51, tipo = "TransferNode", numero = "2", x = -130, y = 10},
            new carnet(){valor = 52, tipo = "TransferNode", numero = "2", x = -110, y = 10},
            new carnet(){valor = 53, tipo = "TransferNode", numero = "2", x = -130, y = 30},
            new carnet(){valor = 54, tipo = "TransferNode", numero = "2", x = -110, y = 30},
            new carnet(){valor = 55, tipo = "TransferNode", numero = "2", x = -130, y = 50},
            new carnet(){valor = 56, tipo = "TransferNode", numero = "2", x = -110, y = 50},

            new carnet(){valor = 57, tipo = "TransferNode", numero = "0", x = -100, y = 10},
            new carnet(){valor = 58, tipo = "TransferNode", numero = "0", x = -80, y = 10},
            new carnet(){valor = 59, tipo = "TransferNode", numero = "0", x = -100, y = 30},
            new carnet(){valor = 60, tipo = "TransferNode", numero = "0", x = -80, y = 30},
            new carnet(){valor = 61, tipo = "TransferNode", numero = "0", x = -100, y = 50},
            new carnet(){valor = 62, tipo = "TransferNode", numero = "0", x = -80, y = 50},

            new carnet(){valor = 63, tipo = "TransferNode", numero = "0", x = -70, y = 10},
            new carnet(){valor = 64, tipo = "TransferNode", numero = "0", x = -50, y = 10},
            new carnet(){valor = 65, tipo = "TransferNode", numero = "0", x = -70, y = 30},
            new carnet(){valor = 66, tipo = "TransferNode", numero = "0", x = -50, y = 30},
            new carnet(){valor = 67, tipo = "TransferNode", numero = "0", x = -70, y = 50},
            new carnet(){valor = 68, tipo = "TransferNode", numero = "0", x = -50, y = 50},

            new carnet(){valor = 69, tipo = "TransferNode", numero = "5", x = -40, y = 10},
            new carnet(){valor = 70, tipo = "TransferNode", numero = "5", x = -20, y = 10},
            new carnet(){valor = 71, tipo = "TransferNode", numero = "5", x = -40, y = 30},
            new carnet(){valor = 72, tipo = "TransferNode", numero = "5", x = -20, y = 30},
            new carnet(){valor = 73, tipo = "TransferNode", numero = "5", x = -40, y = 50},
            new carnet(){valor = 74, tipo = "TransferNode", numero = "5", x = -20, y = 50},

            new carnet(){valor = 75, tipo = "TransferNode", numero = "1", x = -10, y = 30},
            new carnet(){valor = 76, tipo = "TransferNode", numero = "1", x = 10, y = 10},
            new carnet(){valor = 77, tipo = "TransferNode", numero = "1", x = 10, y = 30},
            new carnet(){valor = 78, tipo = "TransferNode", numero = "1", x = 10, y = 50},

            new carnet(){valor = 79, tipo = "TransferNode", numero = "7", x = 20, y = 10},
            new carnet(){valor = 80, tipo = "TransferNode", numero = "7", x = 40, y = 10},
            new carnet(){valor = 81, tipo = "TransferNode", numero = "7", x = 40, y = 30},
            new carnet(){valor = 82, tipo = "TransferNode", numero = "7", x = 40, y = 50},

            new carnet(){valor = 83, tipo = "TransferNode", numero = "8", x = 50, y = 10},
            new carnet(){valor = 84, tipo = "TransferNode", numero = "8", x = 70, y = 10},
            new carnet(){valor = 85, tipo = "TransferNode", numero = "8", x = 50, y = 30},
            new carnet(){valor = 86, tipo = "TransferNode", numero = "8", x = 70, y = 30},
            new carnet(){valor = 87, tipo = "TransferNode", numero = "8", x = 50, y = 50},
            new carnet(){valor = 88, tipo = "TransferNode", numero = "8", x = 70, y = 50},

            new carnet(){valor = 89, tipo = "TransferNode", numero = "0", x = 80, y = 10},
            new carnet(){valor = 90, tipo = "TransferNode", numero = "0", x = 100, y = 10},
            new carnet(){valor = 91, tipo = "TransferNode", numero = "0", x = 80, y = 30},
            new carnet(){valor = 92, tipo = "TransferNode", numero = "0", x = 100, y = 30},
            new carnet(){valor = 93, tipo = "TransferNode", numero = "0", x = 80, y = 50},
            new carnet(){valor = 94, tipo = "TransferNode", numero = "0", x = 100, y = 50},

            new carnet(){valor = 95, tipo = "TransferNode", numero = "3", x = 110, y = 10},
            new carnet(){valor = 96, tipo = "TransferNode", numero = "3", x = 130, y = 10},
            new carnet(){valor = 97, tipo = "TransferNode", numero = "3", x = 110, y = 30},
            new carnet(){valor = 98, tipo = "TransferNode", numero = "3", x = 130, y = 30},
            new carnet(){valor = 99, tipo = "TransferNode", numero = "3", x = 110, y = 50},
            new carnet(){valor = 100, tipo = "TransferNode", numero = "3", x = 130, y = 50},
        };
        public llenarCarnet()
        {
            apiCarnet = SimioProjectFactory.LoadProject(ruta, out warnings);
            model = apiCarnet.Models[1];
            intelligentObjects = model.Facility.IntelligentObjects;

        }

        public void crearModeloCarnet()
        {
            pintarCarnet();
            dibujarPath();
            // Crea el modelo final
            SimioProjectFactory.SaveProject(apiCarnet, rutaFinal, out warnings);
        }

        public void pintarCarnet()
        {
            
            foreach (carnet lista in listaCarnet)
            {
                crearBasicNode(lista.tipo, "", lista.x, lista.y);
            }
        }

        public void crearBasicNode(string tipo, string nombre, double x, double y)
        {
            this.intelligentObjects.CreateObject(tipo, new FacilityLocation(x, 0, y));
        }

        public void dibujarPath()
        {
            int aux = 1;
            
            foreach(carnet lista in listaCarnet)
            {
                switch (lista.numero)
                {
                    case "2":
                        if(aux == 1)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 2)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if(aux == 3)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if(aux == 4)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor - 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if(aux == 5)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if(aux == 6)
                        {
                            aux = 1;
                        }
                        break;
                    case "0":
                        if (aux == 1)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 2)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor - 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 3)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 4)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor - 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 5)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 6)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor - 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux = 1;
                        }
                        break;
                    case "1":
                        if (aux == 1)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 2)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1 ).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 3)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 4)
                        {
                            aux = 1;
                        }
                        break;
                    case "3":
                        if (aux == 1)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 2)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor +2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 3)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 4)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor +2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 5)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 6)
                        {
                            aux = 1;
                        }
                        break;
                    case "8":
                        if (aux == 1)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 2)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor -1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 3)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            nombre = lista.tipo + lista.valor.ToString();
                            nombre2 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 4)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor - 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            nombre = lista.tipo + lista.valor.ToString();
                            nombre2 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 5)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 6)
                        {
                            aux = 1;
                        }
                        break;
                    case "5":
                        if (aux == 1)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));

                            string nombre3 = lista.tipo + lista.valor.ToString();
                            string nombre4 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre3, 1), getNodo(nombre4, 1));
                            aux++;
                        }
                        else if (aux == 2)
                        {
                            aux++;
                        }
                        else if (aux == 3)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 4)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 2).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 5)
                        { 
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 6)
                        {
                            aux = 1;
                        }
                        break;
                    case "7":
                        if (aux == 1)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 2)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 3)
                        {
                            string nombre = lista.tipo + lista.valor.ToString();
                            string nombre2 = lista.tipo + (lista.valor + 1).ToString();
                            crearPath(getNodo(nombre, 1), getNodo(nombre2, 1));
                            aux++;
                        }
                        else if (aux == 4)
                        {
                            aux = 1;
                        }
                        break;
                }
            }
        }

        public void crearPath(INodeObject nodo1, INodeObject nodo2)
        {
            crearLink("Conveyor", nodo1, nodo2);
        }


        public void crearLink(String type, INodeObject nodo1, INodeObject nodo2)
        {
            intelligentObjects.CreateLink(type, nodo1, nodo2, null);
        }

        public INodeObject getNodo(String name, int nodo)
        {

            return (INodeObject)model.Facility.IntelligentObjects[name];
        }


    }
    class carnet
    {
        public int valor;
        public string tipo;
        public string numero;
        public double x;
        public double y;
    }
}
