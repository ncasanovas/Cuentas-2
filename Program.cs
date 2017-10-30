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
            

            Cliente rick = new Cliente();
            rick.DNI = 152232323;
            rick.Nombre="Rick";
            rick.Apellido = "Sanchez";
            rick.Mail = "rick@gmail.com";
            rick.Fecha_Nacimiento = new DateTime(1990, 02, 05);
            rick.Telefono = 45934399;           
            cuenta1.Add(rick);



            Cuenta cuenta1 = new Cuenta();
            cuenta1.Numero = 5000;
            cuenta1.Saldo = 6000;
            cuenta1.Titular = rick;

            cuenta1.DepositarDinero(4000);
            cuenta1.RetirarDinero(3000);



            

           
      

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
