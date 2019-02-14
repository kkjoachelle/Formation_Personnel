namespace DELEGATE
{
    public class PhotoProcessor
        {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Processor(string path , PhotoFilterHandler filterHandler)
            //public void Processor(string path)
        {
            var photo = Photo.Load(path);

            //var filters = new PhotoFilters();
            //filters.ApplyBirghtness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
            //ou
            filterHandler(photo);

            photo.Save();

        }
    }
}
