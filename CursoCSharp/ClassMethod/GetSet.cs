using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassMethod
{
    class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindradas;

        public Moto(string marca, string modelo, uint cilindradas)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindradas = cilindradas;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindradas(cilindradas);
        }

        public Moto() { }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindradas()
        {
            return Cilindradas;
        }

        public void SetCilindradas(uint cilindradas)
        {
            //opção 1
            //if(cilindradas > 0)
            //{
            //    Cilindradas = cilindradas;
            //}

            //opção 2
            //Cilindradas = Math.Abs(cilindradas);

            Cilindradas = cilindradas;
        }
    }

    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Honda","fan",125);
            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG");
            moto2.SetCilindradas(300);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetCilindradas());
        }
    }
}
