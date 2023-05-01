using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationCalculus.Interfacess
{
    public interface IConverter<IInput, IOutput>
    {
        /// <summary>
        /// This method will convert certain type of value and the value itself in other type of value
        /// </summary>
        /// <param name="input">The value that the method will recieve</param>
        /// <returns>Returns an Output (the method recieve an input tho give us an output)</returns>
        public IOutput Convert(IInput input);

        /// <summary>
        /// This is the opposite opperation to the conversion, it recieve an output to give us its input
        /// </summary>
        /// <param name="output">This method will recieve an output as a param</param>
        /// <returns>Returns the input of the output inserted</returns>
        public IInput Unconvert(IOutput output);
    }
}
