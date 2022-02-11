using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica
{
   public class Convertidor
    {
        public static string PlacaVehiculo(string Placa_Vehiculo)
        {
          
            if (Placa_Vehiculo == "PCQ0111")
            {
                return "Toyota Yaris 2010";
            }
            else if (Placa_Vehiculo == "PBX0211")
            {
                return "Dfsk C37 2016 ";
            }

            else if (Placa_Vehiculo == "PXZ0311")
            {
                return "Ford Ranger 2010";
            }
            else if (Placa_Vehiculo == "PYZ0411")
            {
                return "Nissan Sentra 2007";
            }
            else
            {
                return "No registrado";
            }
        }

        public static string MantenimientoVehiculo(int dia , int mes , int anio  )
        {
            
         
            DateTime date1 = new DateTime(anio, mes, dia);
            DateTime date2 = DateTime.Today;
            int result = (date2 - date1).Days;

            if (result > 90)
            {
                return "Si debe realizar mantenimiento";
            }
            else
                return "no debe realizar mantenimiento ";
    


           


           
        }
        public static string Cambiopiezasvehiculo(int dia, int mes, int anio)
        {


            DateTime date1 = new DateTime(anio, mes, dia);
            DateTime date2 = DateTime.Today;
            int result = ((date2 - date1).Days)/365;
            
            if (result > 5)
            {
                return "Realizar cambio de pieza";
            }
            else
                return "no cambiar pieza ";



        }
    }
}
