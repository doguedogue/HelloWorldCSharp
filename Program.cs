using System;

namespace MyApp {
    class Escuela {
        public string nombre;
        public string direccion;
        public void timbrar(){
            Console.Beep(2000,2000);
        }
    }

    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            var miescuela = new Escuela();
            miescuela.nombre = "UTM";
            miescuela.direccion = "Oax. Mex";
            miescuela.timbrar();
        }
    }
}
