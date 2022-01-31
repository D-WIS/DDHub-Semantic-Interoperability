using System.Collections.Generic;

namespace DWISVocabularyDevelopment
{
    public interface IPopulation: ICollection<TypedIndividual>
    {
        TypedIndividual GetIndividual(string name);
    }
}
