namespace Arithmetic.BigInt.Interfaces;

public interface IMultiplier
{
    /// Принимает массивы цифр (little-endian) и возвращает результат
    uint[] Multiply(uint[] left, uint[] right);
}