namespace Contrato.Entities.Enum
{
    //Não funciona sem o public, e o ": int" aparentimento não faz diferença, aparecendo "Remove redundant ': int'" no visual studio.
    public enum WorkerLevel : int
    {
        Junior = 0,
        MidLevel = 1,
        Senior = 2
    }
}
