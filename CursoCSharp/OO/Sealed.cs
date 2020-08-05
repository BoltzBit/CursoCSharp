using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double Fortuna()
        {
            return 6565656565656.65;
        }
    }

    //nao pode ser herdados
    //class Filho : SemFilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNome()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNome()
        {
            return true;
        }
    }

    class Filho : Pai
    {
        //não pode sobrescrever sealed
        //public override bool HonrarNome
        //{

        //}


    }


    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.Fortuna());

            Filho filho = new Filho();
            Console.WriteLine(filho.HonrarNome());
        }
    }
}
