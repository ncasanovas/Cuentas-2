using System;
using System.Collections.Generic;


namespace Ejercicio_Cuentas
{
    class Program
    {

        static void MostrarMenu(){
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1-Retirar dinero");
            Console.WriteLine("2-Depositar dinero");
            Console.WriteLine("3-Consultar saldo");

        }

        static void Main(string[] args)
        {
            List<Cliente> listaTitulares = new List<Cliente>();

            Cliente cliente = new Cliente();
            cliente.DNI = 152232323;
            cliente.Nombre="Rick";
            cliente.Apellido = "Sanchez";
            cliente.Mail = "rick@gmail.com";
            cliente.Telefono = 45934399;           
            

            listaTitulares.Add(cliente);



            Cuenta cuenta = new Cuenta();
            cuenta.Numero = 5000;
            cuenta.Saldo = 6000;



            

           
      

            Console.WriteLine("Bienvenido al cajero");
            MostrarMenu();
            
            int opcion = int.Parse(Console.ReadLine());

            Movimientos movimientos = new Movimientos();

           while(opcion!=0)  
            { 
                switch(opcion){

                    case 1:
                        Console.WriteLine("Ingrese su número de cuenta");
                        cuenta.Numero = int.Parse(Console.ReadLine());;
                        Console.WriteLine(cliente.NombreCompleto());
                        Console.WriteLine("Ingrese el monto a retirar");
                        movimientos.Retiro = int.Parse(Console.ReadLine());
                        cuenta.Saldo = cuenta.Saldo-movimientos.Retiro;
                        Console.WriteLine("Su saldo actual es:"+ cuenta.Saldo);
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());
                        break;

                    case 2: 
                        Console.WriteLine("Ingrese su número de cuenta");
                        cuenta.Numero = int.Parse(Console.ReadLine());;
                        Console.WriteLine(cliente.NombreCompleto());
                        Console.WriteLine("Ingrese el monto a depositar");
                        movimientos.Deposito = int.Parse(Console.ReadLine());
                        cuenta.Saldo = cuenta.Saldo+movimientos.Deposito;
                        Console.WriteLine("Su saldo actual es:"+ cuenta.Saldo);
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());
                        break;

                  case 3: 

                        Console.WriteLine("Ingrese su número de cuenta");
                        cuenta.Numero = int.Parse(Console.ReadLine());;
                        Console.WriteLine(cliente.NombreCompleto());
                        Console.WriteLine("Su saldo actual es:"+ cuenta.Saldo);
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());
                        break;
            }

                MostrarMenu();

                Console.WriteLine("Chau!!!!");
                Console.ReadKey();
            }
        }

    }
}
