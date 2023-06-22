using System;
using System.Linq.Expressions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LostAndFound.ViewModels
{
    public partial class ReportPageViewModel : ObservableObject
    {
        [ObservableProperty]
        INavigation navigation;

        [ObservableProperty]
        List<string> categoryList = new List<string>();

        [ObservableProperty]
        string selectedItem;

        [ObservableProperty]
        string title;


        [ObservableProperty]
        ImageSource image1 = "camera.png";

        [ObservableProperty]
        ImageSource image2 = "camera.png";

        [ObservableProperty]
        ImageSource image3 = "camera.png";

        [ObservableProperty]
        ImageSource image4 = "camera.png";

        [ObservableProperty]
        string padding = "100";



        [ObservableProperty]
        string description;

        [ObservableProperty]
        string location;


        [ObservableProperty]
        string reportType;


        [ObservableProperty]
        bool isInputPage = true;

        [ObservableProperty]
        bool isPhotoPage = false;

        public ReportPageViewModel()
        {
            CategoryList.Add("All");
            CategoryList.Add("Mobile");
            CategoryList.Add("Laptop");
            CategoryList.Add("Documents");
            CategoryList.Add("Others");


        }

        [RelayCommand]
        void onClickHome()
        {
            Navigation.PushAsync(new MainPage(new MainPageViewModel()));

        }


        [RelayCommand]
        void onClickSubmit()
        {
            IsInputPage = !IsInputPage;
            IsPhotoPage = !IsPhotoPage;

        }

        [RelayCommand]
        async void selectPhoto(string no)
        {
            System.Diagnostics.Debug.WriteLine(no);
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.PickPhotoAsync();

                if (photo != null)
                {
                    // save the file into local storage
                    string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                    var stream = await photo.OpenReadAsync();
                    int number = int.Parse(no);
                    switch (number)
                    {
                        case 1:
                            Image1 = ImageSource.FromStream(()=>stream);
                            break;
                        case 2:

                            Image2 = ImageSource.FromStream(() => stream);
                            // code block
                            break;

                        case 3:

                            Image3 = ImageSource.FromStream(() => stream);
                            // code block
                            break;
                        default:

                            Image4 = ImageSource.FromStream(() => stream);
                            // code block
                            break;
                    }
                }

            }
            

        }
    }
}

