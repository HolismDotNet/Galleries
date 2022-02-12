namespace Galleries;

public class Repository
{
    public static Write<Galleries.Gallery> Gallery
    {
        get
        {
            return new Write<Galleries.Gallery>(new GalleriesContext());
        }
    }
}
