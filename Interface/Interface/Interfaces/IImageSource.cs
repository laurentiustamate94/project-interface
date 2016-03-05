using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface IImageSource
    {
        IPhotoStorage Storage { get; set; }

        Task InitializeDevice();

        void TakePhoto(string filename);
    }
}
