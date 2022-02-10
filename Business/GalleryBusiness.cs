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

    protected override void ModifyListBeforeReturning(List<Gallery> items)
    {
        new Media.ImageBusiness().Augment(items.Select(i => (IGuid)i).ToList());
        base.ModifyListBeforeReturning(items);
    }

    public Gallery ChangeImage(long galleryId, byte[] bytes)
    {
        var gallery = WriteRepository.Get(galleryId);
        if (gallery.ImageGuid.HasValue)
        {
            Storage.DeleteImage(ContainerName, gallery.ImageGuid.Value);
        }
        var fullHdImage = ImageHelper.MakeImageThumbnail(Resolution.FullHd, null, bytes);
        gallery.ImageGuid = Guid.NewGuid();
        Storage.UploadImage(fullHdImage.GetBytes(), gallery.ImageGuid.Value, ContainerName);
        WriteRepository.Update(gallery);
        return Get(galleryId);
    }
}