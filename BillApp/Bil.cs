using System;

namespace BillApp
{
    public class Bil
    {
        public int BilId { get; set; }

        public string Model { get; set; }

        //public int AntalCylindre { get; set; }  //nej  .. brug propfull se herunder
        private int antalCylindre;

        public int AntalCylindre
        {
            get { return antalCylindre; }
            set {
                antalCylindre = value;
                if (value < 4 || value > 8)
                //    value = 4;   //en muligehed ...'
                    throw new ApplicationException("Forkert antal cylinbdre"); // en anden mulighed
                    
            }
        }

        public virtual void Print()
        {
            Console.WriteLine("Bil : " + this.Model);
        }

        public Bil()
        {

        }

        public Bil(int model)
        {

        }




    }

    public class PersonBil : Bil
    {
        public int AntalBarneSæder { get; set; }

        public override void Print()
        {
            Console.WriteLine("Persombil : " + this.Model);
        }
    }

    public class LastBil : Bil
    {
        public int LasteEvne { get; set; }
    }



}


