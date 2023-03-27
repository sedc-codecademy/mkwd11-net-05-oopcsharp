using SEDC.VideoRental.App.Menus;
using SEDC.VideoRental.Data.Models;
using SEDC.VideoRental.Services.Helpers;
using SEDC.VideoRental.Services.Loaders;
using SEDC.VideoRental.Services.Menus;
using SEDC.VideoRental.Services.Services;
using System;

namespace SEDC.VideoRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "VideoRental";
            
            // global variable that we will reuse thru the application
            var userService = new UserService();
            var movieService = new MovieService();
            var promotionService = new PromotionService();
            User user = null;
            string errorMessage = string.Empty;

            #region Login/SignUp
            Screen.HomeScreen();
            bool isLoggedIn = false;
            while(!isLoggedIn)
            {
                Screens.StartMenu();
                var startMenuInput = InputParser.ToInteger(1, 3);
                switch (startMenuInput)
                {
                    case 1:
                        while (!isLoggedIn) 
                        {
                            user = userService.Login();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 2:
                        while (!isLoggedIn)
                        {
                            user = userService.SignUp();
                            isLoggedIn = !isLoggedIn;
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion

            #region NewsLetter
            // Ask if user if he want to get news letter
            if (!user.IsSubscribedForPromotions)
            {
                Console.WriteLine("Do you want to subscribe to newsletter? y/n");
                bool isSubscribed = InputParser.ToConfirm();
                if (isSubscribed)
                {
                    user.IsSubscribedForPromotions = true;
                    LoadingHelpers.ShowSimplePercentage();
                    Console.WriteLine("Thank you for subscribing!");
                }
            }
            #endregion

            #region ViewSection

            //TODO: next class
            while (true)
            {
                Screen.ClearScreen();
                Screen.ErrorMessage(errorMessage);
                Screen.MainMenu(user.FullName);
                if (user.IsSubscribedForPromotions)
                {
                    Screen.ShowPromotion(promotionService.GetPromotion());
                }
                var selection = InputParser.ToInteger(1, 4);
                switch (selection)
                {
                    case 1:
                        movieService.ViewMovieList(user);
                        break;
                    case 2:
                        // TODO: PART 3
                        movieService.ViewRentedVideos(user);
                        // TODO: END PART 3
                        break;
                    case 3:
                        // TODO: View history
                        try
                        {
                            movieService.ViewRentedHistoryVideos(user);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = ex.Message;
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
            // till here 
            #endregion
        }
    }
}
