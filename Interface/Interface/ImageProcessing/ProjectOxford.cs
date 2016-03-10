using Interface.Interfaces;
using Microsoft.ProjectOxford.Vision;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Emotion;

namespace Interface.ImageProcessing
{
    public partial class ProjectOxford : IImageProcessing
    {
        private readonly IVisionServiceClient visionClient;
        private readonly IFaceServiceClient faceClient;
        private readonly IEmotionServiceClient emotionClient;

        public ProjectOxford()
        {
            visionClient = new VisionServiceClient(VISION_API_KEY);
            faceClient = new FaceServiceClient(FACE_API_KEY);
            emotionClient = new EmotionServiceClient(EMOTION_API_KEY);
        }
    }
}
