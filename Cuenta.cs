using System;
using System.Collections.Generic;

namespace Ejercicio_Cuentas
{
    public class Cuenta
    {
        public long Numero { get; set;}
        public List<Cliente> Titular { get; set;}

        //Constructor
        public Cuenta(){
            this.Saldo= 0;
            this.Titular = new List<Cliente>();
        }


        public decimal Saldo { get; set;}
        
         //Se retira dinero de la cuenta. True si la operacion es correcta.
        public bool RetirarDinero(decimal cantidad) {
            
            if(Saldo>=cantidad){

            this.Saldo -= cantidad;
            return true;
            }

            return false;
        }

        //Se deposita dinero en la cuenta
        public decimal DepositarDinero(decimal cantidad) {
            this.Saldo += cantidad;
            return this.Saldo;
        }
        
    }
}