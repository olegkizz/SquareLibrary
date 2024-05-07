using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public class CircleException : FigureException
    {
        public CircleException(string? message) : base(message)
        {
            message ??= "Circle was not created.";
        }
    }
}
