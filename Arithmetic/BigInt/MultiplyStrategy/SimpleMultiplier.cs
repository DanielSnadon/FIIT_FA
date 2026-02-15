using Arithmetic.BigInt.Interfaces;

namespace Arithmetic.BigInt.MultiplyStrategy;

public class SimpleMultiplier : IMultiplier
{
    public uint[] Multiply(uint[] left, uint[] right) => throw new NotImplementedException("O(n^2)");
}