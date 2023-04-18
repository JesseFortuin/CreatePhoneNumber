using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePhoneNumber.BL
{
    public interface IPhoneNumberCreator
    {
        public string CreatePhoneNumber(int[] numbers);
    }
}
