using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donkey
{
    public class Farmyard
    {
        public String PlaySound(String animal)
        {
            switch (animal)
            {
                case "dog":
                    return "woof";
                case "cat":
                    return "meow";
                case "donkey":
                    return "pfft";
                default:
                    break;
            }

            return String.Empty;
        }
    }
}
