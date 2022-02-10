namespace Galleries;

public class GalleryController : Controller<Gallery, Gallery>
{
    public override ReadBusiness<Gallery> ReadBusiness => new GalleryBusiness();

    public override Business<Gallery, Gallery> Business => new GalleryBusiness();

    [FileUploadChecker]
    [HttpPost]
    public Gallery SetImage(IFormFile file)
    {
        var galleryId = Request.Query["galleryId"];
        if (galleryId.Count == 0)
        {
            throw new ClientException("Please provide galleryId");
        }
        var bytes = file.OpenReadStream().GetBytes();
        var gallery = new GalleryBusiness().ChangeImage(galleryId[0].ToLong(), bytes);
        return gallery;
    }
}