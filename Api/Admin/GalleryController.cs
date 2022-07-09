namespace Galleries;

public class GalleryController : Controller<Gallery, Gallery>
{
    public override ReadBusiness<Gallery> ReadBusiness => new GalleryBusiness();

    public override Business<Gallery, Gallery> Business => new GalleryBusiness();
}