using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> ListaTransportes = new List<Transporte>();

            for (int i = 1; i <= 10; i++) {
                if (i <= 5) {
                    Transporte Avion = new Avion(i * 100);
                    ListaTransportes.Add(Avion);
                }else{
                    Transporte Autommovil = new Automovil(i - 5);
                    ListaTransportes.Add(Autommovil);
                }
            }

            for (int i = 0; i <10; i++){
                if (i <= 4){
                    Console.WriteLine("Avión {0}: {1} pasajeros.", i+1, ListaTransportes[i].Pasajeros);
                    Console.WriteLine(ListaTransportes[i].Avanzar());
                    Console.WriteLine(ListaTransportes[i].Detenerse());
                }else{
                    Console.WriteLine("Automóvil {0}: {1} pasajeros.", i+1, ListaTransportes[i].Pasajeros);
                    Console.WriteLine(ListaTransportes[i].Avanzar());
                    Console.WriteLine(ListaTransportes[i].Detenerse());
                }
            }

            Console.ReadKey();
        }
    }
}
