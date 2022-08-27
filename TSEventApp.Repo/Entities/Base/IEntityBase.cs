namespace TSEventApp.Core.Base
{
    public interface IEntityBase<TId>
    {
        TId Id { get; }
    }
}
