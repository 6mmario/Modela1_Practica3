using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class llenarBasicNode
    {
        public List<basicnode> listaCardinal = new List<basicnode>()
            {
                new basicnode() { valor = 1, tipo = "TransferNode", nombre = "Norte", y = -100, x = 0},
                new basicnode() { valor = 2, tipo = "TransferNode", nombre = "Sur", y = 70, x = 0},
                new basicnode() { valor = 3, tipo = "TransferNode", nombre = "Oeste", y = 0, x = -90},
                new basicnode() { valor = 4, tipo = "TransferNode", nombre = "Este", y = 0, x = 90},
                //pinto los nodos del mapa
                new basicnode() { valor = 5, tipo = "TransferNode", nombre = "Pto5", y =-90, x =30},
                new basicnode() { valor = 6, tipo = "TransferNode", nombre = "Pto6", y =-90, x =-25},
                new basicnode() { valor = 7, tipo = "TransferNode", nombre = "Pto7", y =-65, x =-25},
                new basicnode() { valor = 8, tipo = "TransferNode", nombre = "Pto8", y =-65, x =-45},
                new basicnode() { valor = 9, tipo = "TransferNode", nombre = "Pto9", y =-55, x =-35},
                new basicnode() { valor = 10, tipo = "TransferNode", nombre = "Pto10", y =-48.75, x =-28.75},
                new basicnode() { valor = 11, tipo = "TransferNode", nombre = "Pto11", y =-43.75, x =-21.25},
                new basicnode() { valor = 12, tipo = "TransferNode", nombre = "Pto12", y =-35, x =-20},
                new basicnode() { valor = 13, tipo = "TransferNode", nombre = "Pto13", y =-35, x =-57.5},
                new basicnode() { valor = 14, tipo = "TransferNode", nombre = "Pto14", y =-25, x =-67.5},
                new basicnode() { valor = 15, tipo = "TransferNode", nombre = "Pto15", y =-10, x =-76.25},
                new basicnode() { valor = 16, tipo = "TransferNode", nombre = "Pto16", y =-2.5, x =-72.5},
                new basicnode() { valor = 17, tipo = "TransferNode", nombre = "Pto17", y =10, x =-68.75},
                new basicnode() { valor = 18, tipo = "TransferNode", nombre = "Pto18", y =27.5, x =-67.5},
                new basicnode() { valor = 19, tipo = "TransferNode", nombre = "Pto19", y =32.5, x =-57.5},
                new basicnode() { valor = 20, tipo = "TransferNode", nombre = "Pto20", y =42.5, x =-40},
                new basicnode() { valor = 21, tipo = "TransferNode", nombre = "Pto21", y =50, x =-25},
                new basicnode() { valor = 22, tipo = "TransferNode", nombre = "Pto22", y =50, x =-10.5},
                new basicnode() { valor = 23, tipo = "TransferNode", nombre = "Pto23", y =47.5, x =2.5},
                new basicnode() { valor = 24, tipo = "TransferNode", nombre = "Pto24", y =47.5, x =5},
                new basicnode() { valor = 25, tipo = "TransferNode", nombre = "Pto25", y =47.58, x =11.25},
                new basicnode() { valor = 26, tipo = "TransferNode", nombre = "Pto26", y =50, x =20},
                new basicnode() { valor = 27, tipo = "TransferNode", nombre = "Pto27", y =50, x =25.75},
                new basicnode() { valor = 28, tipo = "TransferNode", nombre = "Pto28", y =50, x =35},
                new basicnode() { valor = 29, tipo = "TransferNode", nombre = "Pto29", y =45, x =45},
                new basicnode() { valor = 30, tipo = "TransferNode", nombre = "Pto30", y =35, x =50},
                new basicnode() { valor = 31, tipo = "TransferNode", nombre = "Pto31", y =28.75, x =52.5},
                new basicnode() { valor = 32, tipo = "TransferNode", nombre = "Pto32", y =26.25, x =58.75},
                new basicnode() { valor = 33, tipo = "TransferNode", nombre = "Pto33", y =20, x =60},
                new basicnode() { valor = 34, tipo = "TransferNode", nombre = "Pto34", y =15, x =58.75},
                new basicnode() { valor = 35, tipo = "TransferNode", nombre = "Pto35", y =10, x =58.75},
                new basicnode() { valor = 36, tipo = "TransferNode", nombre = "Pto36", y =5, x =61},
                new basicnode() { valor = 37, tipo = "TransferNode", nombre = "Pto37", y =-1.25, x =58.75},
                new basicnode() { valor = 38, tipo = "TransferNode", nombre = "Pto38", y =-4, x =60},
                new basicnode() { valor = 39, tipo = "TransferNode", nombre = "Pto39", y =-12.5, x =67.5},
                new basicnode() { valor = 40, tipo = "TransferNode", nombre = "Pto40", y =-16.5, x =75},
                new basicnode() { valor = 41, tipo = "TransferNode", nombre = "Pto41", y =-23.75, x =81.25},
                new basicnode() { valor = 42, tipo = "TransferNode", nombre = "Pto42", y =-26.25, x =78.75},
                new basicnode() { valor = 43, tipo = "TransferNode", nombre = "Pto43", y =-27.5, x =72.5},
                new basicnode() { valor = 44, tipo = "TransferNode", nombre = "Pto44", y =-20, x =61.25},
                new basicnode() { valor = 45, tipo = "TransferNode", nombre = "Pto45", y =-16.25, x =57.5},
                new basicnode() { valor = 46, tipo = "TransferNode", nombre = "Pto46", y =-15, x =51.25},
                new basicnode() { valor = 47, tipo = "TransferNode", nombre = "Pto47", y =-17.5, x =45},
                new basicnode() { valor = 48, tipo = "TransferNode", nombre = "Pto48", y =-21.625, x =48.625},
                new basicnode() { valor = 49, tipo = "TransferNode", nombre = "Pto49", y =-20, x =55},
                new basicnode() { valor = 50, tipo = "TransferNode", nombre = "Pto50", y =-22, x =59.5},
                new basicnode() { valor = 51, tipo = "TransferNode", nombre = "Pto51", y =-25, x =63},
                new basicnode() { valor = 52, tipo = "TransferNode", nombre = "Pto52", y =-27, x =66.5},
                new basicnode() { valor = 53, tipo = "TransferNode", nombre = "Pto53", y =-30, x =70},
                new basicnode() { valor = 54, tipo = "TransferNode", nombre = "Pto54", y =-30, x =55},
                new basicnode() { valor = 55, tipo = "TransferNode", nombre = "Pto55", y =-30, x =30}
           
    };
        public llenarBasicNode()
        {

        }

    }
    class basicnode
    {
        public int valor;
        public string tipo;
        public string nombre;
        public double x;
        public double y;

    }
}
