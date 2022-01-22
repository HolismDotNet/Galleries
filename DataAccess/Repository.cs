namespace Holism.Galleries.DataAccess;

public class Repository
{
    public static Repository<Gallery> Gallery
    {
        get
        {
            return new Repository<Gallery>(new GalleriesContext());
        }
    }
}
