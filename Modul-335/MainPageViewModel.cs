using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Modul_335
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int count;
        private string buttonText;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            Count = 0;
            ButtonText = "RUN!";
            ClickCommand = new Command(OnCounterClicked);
        }

        public string ButtonText
        {
            get => buttonText;
            set
            {
                buttonText = value;
                OnPropertyChanged();
            }
        }

        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
                ShowDistanceMessage();
            }
        }

        public ICommand ClickCommand { get; }

        private void OnCounterClicked()
        {
            Count++;
        }

        private void ShowDistanceMessage()
        {
            string message = "";

            switch (Count)
            {
                case 10:
                    message = "You've walked the length of a standard basketball court!";
                    break;
                case 50:
                    message = "You've walked about the distance of a city block!";
                    break;
                case 69:
                    message = "That's a SUS number. Why did you stop running? GO!";
                    break;
                case 105:
                    message = "You've walked as far as a football field!";
                    break;
                case 150:
                    message = "You've walked the length of two football fields!";
                    break;
                case 200:
                    message = "You've walked the distance of a marathon (approximately 0.5 km)!";
                    break;
                case 300:
                    message = "You've walked about the distance of a long walk in the park!";
                    break;
                case 500:
                    message = "You've walked the distance of a small hiking trail!";
                    break;
                case 1000:
                    message = "You've walked 1 kilometer!";
                    break;
                case 2500:
                    message = "You've walked about the distance of a 5K run!";
                    break;
                case 5000:
                    message = "You've walked 5 kilometers!";
                    break;
                case 10000:
                    message = "You've walked the distance of a half marathon (approximately 21 km)!";
                    break;
            }

            if (!string.IsNullOrEmpty(message))
            {
                Application.Current.MainPage.DisplayAlert("Congratulations!", message, "OK");
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
