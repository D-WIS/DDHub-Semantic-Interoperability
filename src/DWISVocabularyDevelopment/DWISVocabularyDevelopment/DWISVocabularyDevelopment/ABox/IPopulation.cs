using System.Collections.Generic;

namespace DWIS.Vocabulary.Development
{
    public interface IPopulation: ICollection<TypedIndividual>
    {
        TypedIndividual GetIndividual(string name);
    }
}
