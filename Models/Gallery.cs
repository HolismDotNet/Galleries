namespace Galleries;

public class Gallery : IEntity
{
    public Gallery()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Title { get; set; }

    public dynamic RelatedItems { get; set; }
}
