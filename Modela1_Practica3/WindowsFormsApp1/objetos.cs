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
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
   
    class objetos
    {
        private ISimioProject practica4;
        private string ruta = "ModeloBase.spfx";
        private string rutaFinal = "ModeloFinal.spfx";
        
        private string[] warnings;
        private IModel model;
        private IIntelligentObjects intelligentObjects;
        int noPath = 0;
        //private List<servidores> serverRegiones;
        //servidores servidor;
        //private int contFrontera = 1;
        //private int contServer = 1;

        llenado llenado = new llenado();
        llenarBasicNode llenadoBN = new llenarBasicNode();
        llenadoRutas llenadoRutas = new llenadoRutas();
        llenarCarnet llenarCarnet = new llenarCarnet();

        public objetos()
        {
            practica4 = SimioProjectFactory.LoadProject(ruta, out warnings);
            model = practica4.Models[1];
            intelligentObjects = model.Facility.IntelligentObjects;
        }

        public void crearModelo()
        {
            pintarBasicNode();
            pintarServer();
            actualizarObjetos();
            dibujarRuta();
            modificarRegiones();

            

            //Source de la Fuerza Armada
            crearSource("Source","FuerzaArmada",-8.75, -81);
            cambioNombre("Source1", "FuerzaArmada");

            crearModelEntyty("ModelEntity", "avion",-4.356, -78.731);
            cambioNombre("ModelEntity1", "avion");
            modificarPropiedades("FuerzaArmada", "InterarrivalTime", "15");
            modificarPropiedades("FuerzaArmada", "MaximumArrivals", "15");
            modificarPropiedades("FuerzaArmada", "EntityType", "avion");

            crearLink("Conveyor", getNodoServer("FuerzaArmada",0),getNodo("Pto6",1));
            noPath++;


            rutasRegiones();
            // Crea el modelo final
            llenarCarnet.crearModeloCarnet();
            SimioProjectFactory.SaveProject(practica4, rutaFinal, out warnings);

           
        }



        public void pintarServer()
        {
            List<servidores> servidores = llenado.listaServidores;
            foreach (servidores l in servidores)
            {
                this.crearServer(l.tipoValor, l.nombre, l.x, l.y);
            }
        }

        public void pintarBasicNode()
        {
            List<basicnode> basiNode = llenadoBN.listaCardinal;
            foreach (basicnode lbn in basiNode)
            {
                this.crearBasicNode(lbn.tipo, lbn.nombre, lbn.x, lbn.y);
            }
        }

        public void crearBasicNode(string tipo, string nombre, double x, double y)
        {
            this.intelligentObjects.CreateObject(tipo, new FacilityLocation(x, 0, y));
        }

        public void crearServer(string tipo, string nombre, double x, double y)
        {
            this.intelligentObjects.CreateObject(tipo, new FacilityLocation(x, 0, y));
        }

        public void crearSource(string tipo, string nombre, double x, double y)
        {
            this.intelligentObjects.CreateObject(tipo, new FacilityLocation(x, 0, y));
        }

        public void crearModelEntyty(string tipo, string nombre, double x, double y)
        {
            this.intelligentObjects.CreateObject(tipo, new FacilityLocation(x, 0, y));
        }



        public void cambioNombre(string antiguo, string nuevo)
        {
                model.Facility.IntelligentObjects[antiguo].ObjectName =nuevo;
        }

        public void actualizarObjetos()
        {
            //Cambio de nombre los nodos Servidores
            List<servidores> ser = llenado.listaServidores;
            for(int i = 0; i < ser.Count; i++)
            {
                string aux = ser[i].tipoValor + ser[i].valorServer.ToString();
                cambioNombre(aux, ser[i].nombre);
            }

            //Cambio de Nombre los nodos del BasicNode
            List<basicnode> bnod = llenadoBN.listaCardinal;
            for (int i = 0; i < bnod.Count; i++)
            {
                string aux = bnod[i].tipo + bnod[i].valor.ToString();
                cambioNombre(aux, bnod[i].nombre);
            }
        }

       
        public void dibujarRuta()
        {
            //pinto dos pth
            List<basicnode> bnod = llenadoBN.listaCardinal;
            for (int i = 0; i < bnod.Count; i++)
            {
                if (i >= 4)
                {
                    string aux = bnod[i].tipo + bnod[i].valor.ToString();
                    if((i+1) == bnod.Count)
                    {
                        noPath++;
                        crearPath(getNodo(bnod[i].nombre, 1), getNodo(bnod[4].nombre, 1));
                        modificarPropiedades("Conveyor" + noPath.ToString(), "DrawnToScale", "False");
                    }
                    else
                    {
                        noPath++;
                        crearPath(getNodo(bnod[i].nombre, 1), getNodo(bnod[i+1].nombre, 1));
                        modificarPropiedades("Conveyor" + noPath.ToString(), "DrawnToScale", "False");
                        
                    }
                }
            }

           tamanioPath(noPath);
        }

        public void tamanioPath(int numero)
        {
            for(int i = 1; i <= numero; i++)
            {
                if(1 <= i && i <= 13) // 14
                {
                    modificarPropiedades("Conveyor" + i.ToString(), "LogicalLength", "68710");
                    modificarPropiedades("Conveyor" + i.ToString(), "InitialDesiredSpeed", "16.66667");
                }
                else if(14<= i && i <= 23) // 10
                {
                    modificarPropiedades("Conveyor" + i.ToString(), "LogicalLength", "25400");
                    modificarPropiedades("Conveyor" + i.ToString(), "InitialDesiredSpeed", "16.66667");
                } 
                else if(24 <= i && i <= 30) // 6
                {
                    modificarPropiedades("Conveyor" + i.ToString(), "LogicalLength", "33830");
                    modificarPropiedades("Conveyor" + i.ToString(), "InitialDesiredSpeed", "16.66667");
                }
                else if (31<= i && i <= 37) // 7
                {
                    modificarPropiedades("Conveyor" + i.ToString(), "LogicalLength", "36570");
                    modificarPropiedades("Conveyor" + i.ToString(), "InitialDesiredSpeed", "16.66667");
                }
                else if (38 <= i && i <= 48) // 11
                {
                    modificarPropiedades("Conveyor" + i.ToString(), "LogicalLength", "13450");
                    modificarPropiedades("Conveyor" + i.ToString(), "InitialDesiredSpeed", "16.66667");
                }
                else if (49 <= i && i <= 51) // 3
                {
                    modificarPropiedades("Conveyor" + i.ToString(), "LogicalLength", "88670");
                    modificarPropiedades("Conveyor" + i.ToString(), "InitialDesiredSpeed", "16.66667");
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


        // Obtener Nodo TransferNode
        public INodeObject getNodo(String name, int nodo)
        {
           
            return (INodeObject)model.Facility.IntelligentObjects[name];
        }

        // Metodos para Modificar los Server

        public void modificarRegiones()
        {
            List<servidores> ser = llenado.listaServidores;
            foreach (servidores lista in ser)
            {
                switch (lista.valorServer)
                {
                    case 1:
                        modificarPropiedades(lista.nombre, "InitialCapacity", "200");
                        modificarPropiedades(lista.nombre, "ProcessingTime", "Random.Exponential(4)");
                        break;

                    case 2:
                        modificarPropiedades(lista.nombre, "InitialCapacity", "50");
                        modificarPropiedades(lista.nombre, "ProcessingTime", "Random.Exponential(5)");
                        break;

                    case 3:
                        modificarPropiedades(lista.nombre, "InitialCapacity", "40");
                        modificarPropiedades(lista.nombre, "ProcessingTime", "Random.Exponential(3)");
                        break;

                    case 4:
                        modificarPropiedades(lista.nombre, "InitialCapacity", "30");
                        modificarPropiedades(lista.nombre, "ProcessingTime", "Random.Exponential(4)");
                        break;

                    case 5:
                        modificarPropiedades(lista.nombre, "InitialCapacity", "100");
                        modificarPropiedades(lista.nombre, "ProcessingTime", "Random.Exponential(5)");
                        break;

                    case 6:
                        modificarPropiedades(lista.nombre, "InitialCapacity", "120");
                        modificarPropiedades(lista.nombre, "ProcessingTime", "Random.Exponential(3)");
                        break;

                    case 7:
                        modificarPropiedades(lista.nombre, "InitialCapacity", "30");
                        modificarPropiedades(lista.nombre, "ProcessingTime", "Random.Exponential(6)");
                        break;

                    case 8:
                        modificarPropiedades(lista.nombre, "InitialCapacity", "150");
                        modificarPropiedades(lista.nombre, "ProcessingTime", "Random.Exponential(4)");
                        break;
                }
                
            }
        }
        public void modificarPropiedades(String name, String property, String value)
        {
            model.Facility.IntelligentObjects[name].Properties[property].Value = value;
        }

        public void modificarUnidad(String name, String property, String value)
        {
            model.Facility.IntelligentObjects[name].Properties[property].Value = value;
        }

        //Metodo para Agregar las Rutas entre Regiones
        public void rutasRegiones()
        {
            List<rutasRegiones> listaRR = llenadoRutas.listaRutasRegiones;
            foreach(rutasRegiones RR in listaRR)
            {
                crearPath(getNodoServer(RR.ubicacionActual, 1),getNodoServer(RR.regionDestino,0));
                noPath++;
                
                string aux = "Conveyor" + noPath.ToString();
                modificarPropiedades(aux, "SelectionWeight", $"{RR.probabilidad}");
                modificarPropiedades(aux, "DrawnToScale", "False");
                double temp = RR.distanciaRecorrer * 1000;
                modificarPropiedades(aux, "LogicalLength", $"{temp}");
                

            }
        }

        //Obtengo Nodo de Servidores
        public INodeObject getNodoServer(String name, int nodo)
        {
            return ((IFixedObject)model.Facility.IntelligentObjects[name]).Nodes[nodo];
        }
    }




}
