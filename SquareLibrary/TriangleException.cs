using System.Runtime.Serialization;

namespace SquareLibrary
{
    [Serializable]
    public class TriangleException : FigureException
    {
        public TriangleException(string? message) : base(message)
        {
            message ??= "Triangle was not created.";
        }
    }
}