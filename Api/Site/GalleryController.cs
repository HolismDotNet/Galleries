namespace Galleries;

public class GalleryController : ReadController<Gallery>
{
    public override ReadBusiness<Gallery> ReadBusiness => new GalleryBusiness();
}