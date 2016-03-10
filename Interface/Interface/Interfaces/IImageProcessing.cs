using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface IImageProcessing
    {
        Task<object> AnalyzeImage(string imagePath);

        Task<string> GetDominantForegroundColor(string imagePath);

        Task<string> RecognizeText(string imagePath);

        Task<bool> RecognizeFace(string imagePath);
    }
}
