namespace Domain.Utilities.Entities.CrossCutting
{
    public class EntityBase
    {
        public virtual bool IsValid()
        {
            return false;
        }
    }
}