namespace L6_Delegates
{
    public class PhotoProcessor
    {
        // System.Action<> - points to a method that returns void

        // System.Func<> - points to a method that returns a value

        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}