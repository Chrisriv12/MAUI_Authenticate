﻿namespace Login_Application
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            // Get the username and password from the entry fields
            string username = txtUserId.Text;
            string password = txtPassword.Text;

            // Create an instance of UserAuthentication
            var userAuth = new DataAccess.UserAuthentication();

            // Authenticate the user
            bool isAuthenticated = userAuth.AuthenticateUser(username, password);

            // Display the result
            if (isAuthenticated)
            {
                DisplayAlert("Success", "User authenticated successfully!", "OK");
            }
            else
            {
                DisplayAlert("Error", "Invalid username or password.", "OK");
            }
        }
    }
}