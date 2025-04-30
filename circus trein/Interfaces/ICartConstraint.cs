using CircusTrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circus_trein.Rules
{
    internal interface ICartConstraint
    {

        public bool CanAddAnimal(Animal animal, Cart cart);


    }
}
