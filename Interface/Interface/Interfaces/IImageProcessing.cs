using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface IImageProcessing
    {
        Task<object> AnalyzeImage(string imagePathOrUrl);

        Task<string> RecognizeText(string imagePathOrUrl);
    }
}
