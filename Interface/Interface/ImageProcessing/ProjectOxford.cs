using Interface.Interfaces;
using Microsoft.ProjectOxford.Vision;

namespace Interface.ImageProcessing
{
    public partial class ProjectOxford : IImageProcessing
    {
        private readonly IVisionServiceClient visionClient;

        public ProjectOxford()
        {
            visionClient = new VisionServiceClient(VISION_API_KEY);
        }
    }
}
