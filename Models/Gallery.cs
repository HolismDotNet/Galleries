namespace Galleries;

public class Gallery : IEntity, IGuid, IOrder
{
    public Gallery()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime UtcDate { get; set; }

    public long Order { get; set; }

    public dynamic RelatedItems { get; set; }
}
