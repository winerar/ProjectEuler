using System;
using System.Linq;

namespace ProjectEuler
{
    public interface IProblem
    {
        int Id { get; }
        string Title { get; }
        string Description { get; }
        string Solution { get; }
    }
}
