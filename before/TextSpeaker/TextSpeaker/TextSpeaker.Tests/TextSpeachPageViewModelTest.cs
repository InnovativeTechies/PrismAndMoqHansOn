using Xunit;

// ReSharper disable once CheckNamespace
namespace TextSpeaker.ViewModels.Tests
{
    public class TextSpeechPageViewModelTest
    {
        [Fact]
        public void SpeechTest()
        {
            var viewModel = new TextSpeechPageViewModel();
            viewModel.Speech();
        }
    }
}
