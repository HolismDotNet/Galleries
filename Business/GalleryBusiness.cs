using Holism.Galleries.DataAccess;

namespace Holism.Galleries.DataAccess;

public class GalleryBusiness : Business<Gallery, Gallery>
{
    protected override ReadRepository<Gallery> ReadRepository => Repository.Gallery;

    protected override Repository<Gallery> WriteRepository => Repository.Gallery;
}