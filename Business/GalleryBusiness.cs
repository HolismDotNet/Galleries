namespace Galleries;

public class GalleryBusiness : Business<Gallery, Gallery>
{
    protected override ReadRepository<Gallery> ReadRepository => Repository.Gallery;

    protected override Repository<Gallery> WriteRepository => Repository.Gallery;

    protected override void PreCreation(Gallery model)
    {
        model.UtcDate = UniversalDateTime.Now;
        base.PreCreation(model);
    }

    protected override void ModifyItemBeforeReturning(Gallery item)
    {

    }

    protected override void ModifyListBeforeReturning(List<Gallery> items)
    {
        new Media.ImageBusiness().Augment(items.Select(i => (IGuid)i).ToList());
    }
}