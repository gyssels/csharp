using Generators.Input;

namespace Generators.Exercises
{
    public class Luhn : GeneratorExercise
    {
        protected override void UpdateCanonicalData(CanonicalData canonicalData)
        {
            foreach (var canonicalDataCase in canonicalData.Cases)
                canonicalDataCase.Property = "IsValid";
        }
    }
}
