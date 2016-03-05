using System;
using System.Threading.Tasks;
using Interface.Interfaces;
using Windows.Media.Capture;

namespace Interface.ImageSource
{
    public class LocalCameraImageSource : IImageSource
    {
        public IPhotoStorage Storage { get; set; }

        public MediaCapture MediaDevice { get; private set; }

        public LocalCameraImageSource(IPhotoStorage storage, MediaCapture mediaDevice)
        {
            Storage = storage;
            MediaDevice = mediaDevice;
        }

        public async Task InitializeDevice()
        {
            await MediaDevice.InitializeAsync();

            MediaDevice.Failed += new MediaCaptureFailedEventHandler(MediaCapture_Failed);
        }

        public void TakePhoto(string filename)
        {
            Storage.Save(filename);
        }

        private async void MediaCapture_Failed(MediaCapture currentCaptureObject, MediaCaptureFailedEventArgs currentFailure)
        {
            throw new NotImplementedException();
        }
    }
}
