using ExceptionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2020
{
    public class Program
    {
        static void Main(string[] args)
        {

            ExceptionsPractice demo = new ExceptionsPractice();
            #region Inciso 1 del ejercicio 2.
            try
            {
                demo.AttemptToDivideByZero(2);
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("La operación ha finalizado.");
            }
            #endregion

            #region Inciso 2 del ejercicio 2.
            try
            {
                Console.WriteLine("Por favor, ingrese numerador: ");
                int numerador = int.Parse(Console.ReadLine());
                Console.WriteLine("A continuación, ingrese el denominador(En caso de ser 0, la aplicación devolverá un error y finalizará el proceso): ");
                int denominador = int.Parse(Console.ReadLine());
                Console.WriteLine("El Resultado de la división entera es: {0}", demo.IntegerDivision(numerador, denominador));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("¡Solo Chuck Norris divide por cero!");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("¡Seguro ingresó una letra o no ingresó nada!");
            }
            finally
            {
                Console.WriteLine("El programa ha finalizado.");
            }
            #endregion

            Logic demo2 = new Logic();
            #region Inciso 3 del ejercicio 2.
            try
            {
                demo2.ILoveThrowingExceptions();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
            #endregion

            #region Inciso 4 del ejercicio 2.
            try
            {
                demo2.ILoveThrowingCustomExceptions();
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
            #endregion
            Console.ReadKey();
        }
    }
}
