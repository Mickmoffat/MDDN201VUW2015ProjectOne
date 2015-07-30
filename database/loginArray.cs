 protected void loginImageButton_Click(object sender, ImageClickEventArgs e)
    {
         //array decloration username
        string[] usernameLoginArray = new string[5];

        usernameLoginArray[0] = "Bob";
        usernameLoginArray[1] = "Rob";
        usernameLoginArray[2] = "Jim";
        usernameLoginArray[3] = "Jack";
        usernameLoginArray[4] = "Rose";

        // array decloration password
        string[] passwordLogininArray = new string[5];

        passwordLogininArray[0] = "bob101";
        passwordLogininArray[1] = "robisthebest";
        passwordLogininArray[2] = "jimmyboy";
        passwordLogininArray[3] = "beanstalk";
        passwordLogininArray[4] = "thorns";


         for (int i = 0; i < 1; i++)
        {
            usernameLoginArray[i] = usernameLoginTextBox.Text;
            passwordLogininArray[i] = passwordLoginTextBox.Text;

        if (usernameLoginArray.Equals(usernameLoginTextBox.Text) && passwordLogininArray.Equals(passwordLoginTextBox.Text));
            {