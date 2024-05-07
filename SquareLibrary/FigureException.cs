using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public class FigureException : Exception
    {
        public FigureException(string? message) : base(message)
        {
            message ??= "Invalid Figure data ";
        }
    }
}

