namespace Galleries;

public class GalleryBusiness : Business<Gallery, Gallery>
{
    protected override Read<Gallery> Read => Repository.Gallery;

    protected override Write<Gallery> Write => Repository.Gallery;

    protected override void PreCreation(Gallery model)
    {
        model.UtcDate = UniversalDateTime.Now;
        base.PreCreation(model);
    }

    protected override void ModifyItemBeforeReturning(Gallery item)
    {
        if (item.ImageGuid.HasValue)
        {
            item.RelatedItems.ImageUrl = Storage.GetImageUrl(ContainerName, item.ImageGuid.Value);
        }
        base.ModifyItemBeforeReturning(item);
    }

    protected override void ModifyListBeforeReturning(List<Gallery> items)
    {
        new Media.ImageBusiness().Augment(items.Select(i => (IGuid)i).ToList());
        base.ModifyListBeforeReturning(items);
    }
}