using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class hospital
    {
            public virtual void HospitalDetails()
            {
                Console.WriteLine("Generic Hospital Details.");
            }
        

        class Apollo : hospital
        {
            public override void HospitalDetails()
            {
                Console.WriteLine("Apollo Hospital: Known for its advanced healthcare services and state-of-the-art facilities.");
            }
        }

        class Wockhardt : hospital
        {
            public override void HospitalDetails()
            {
                Console.WriteLine("Wockhardt Hospital: Renowned for its cardiac care and specialized medical treatments.");
            }
        }

        class Gokul_Superspeciality : hospital
        {
            public override void HospitalDetails()
            {
                Console.WriteLine("Gokul Superspeciality Hospital: Leading in multi-specialty treatments and patient care.");
            }
        }
    }
}
