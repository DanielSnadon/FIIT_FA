using Arithmetic.BigInt.Interfaces;

namespace Arithmetic.BigInt.MultiplyStrategy;

public class FftMultiplier : IMultiplier
{
    public uint[] Multiply(uint[] left, uint[] right) => throw new NotImplementedException("O(n log n log log n)");
}