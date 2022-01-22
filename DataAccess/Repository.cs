namespace Galleries;

public class Repository
{
    public static Repository<Galleries.Gallery> Gallery
    {
        get
        {
            return new Repository<Galleries.Gallery>(new GalleriesContext());
        }
    }
}
