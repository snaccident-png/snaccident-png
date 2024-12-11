using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
// using System.IO; // Remember to add this 'library' or namespace when
// wanting to read text documents. Apparently, System.IO allows this to happen.

namespace SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024
{
    public partial class Form1 : Form
    {
        /*
         * SETTING UP THE SNAKE SPRITE
         * Timestamp in the tutorial video: 13:20 to 15:26
         * 
         * Create a private 'list' called 'Snake'. Another new C# coding element.
         * 
         * What is a list?
         * 
         * A list is apparently similar to an array, a different form of the string variable
         * that allows you to contain multiple values such as [value1], [value 2].
         * 
         * A list allows you to do a LOT more with the values you provided.
         * 
         * I will see about that!
         * 
         * Also, when you add something related to the snake sprite, for example,
         * head and body, you will have to add to this private list.
         * 
         * Type:
         * private List<Circle> Snake = new List<Circle>();
         */

        private List<Circle> Snake = new List<Circle>();




        /* 
         * Next, create a private reference to the Circle class, call it 'food', and 
         * enter the constructor you created in the Circle class which should have
         * the same name (please see the Circle.cs class for an explanation).
         * 
         * This private reference appears to illustrate how one class can call out
         * a constructor or variables contained within a different class.
         * 
         * I think I get this, but I will possibly feel confused by the time I finish writing
         * these code comments here.
         * 
         * Type:
         * private Circle food = new Circle();
         */

        private Circle food = new Circle();




        // Sorry but I immediately know why the tutorial video said to create these
        // first two variables.

        // Oh, do not get cocky. I dislike being cocky. I might be wrong!

        /*
         * Good news: I was wrong.
         * 
         * maxWidth and maxHeight means the widest and highest
         * places in the game the snake sprite can reach.
         * 
         * Type:
         * int maxWidth;
        int maxHeight;

        int score;
        int highScore;
         */

        int maxWidth;
        int maxHeight;

        int score;
        int highestScore;




        /*
         * Here, create a new number that might show next to the current score
         * or highest score every time it changes. Again, I might be wrong.
         *
         * Apparently, this 'Random' element allows you to generate a random
         * number between two values.
         *
         * Type:
         * Random rand = new Random();
         */
        Random rand = new Random();




        /* 
         * Then, create a boolean or 'bool' element and provide directions such as
         * left and right. Apparently, all of these directions will be marked as 'false'.
         * 
         * I am not sure what that means for now, but maybe a lightbulb will light up
         * in my brain suddenly and I will have another 'lightbulb moment'.
         * 
         * Type:
         * bool goLeft, goRight, goDown, goUp;
         */
        bool goLeft, goRight, goDown, goUp;
        // bool mouseLeft, mouseRight, mouseDown, mouseUp;




        /* 
         * 26th September 2024 update (add to version 3 - UNUSED):
         * Create a new string variable containing the file path or location of a text
         * document (.txt is the file format).
         * 
         * Apparently, the at symbol '@' disregards the file location.
         * 
         * Type:
         * string openFile = @"C:\Users\[redacted]\OneDrive\Desktop\[redacted]
                                            \Hello and thank you for downloading.txt";
         * 
         * Breaking news: The file location above does not work and will not be read by the game.
         * However, if you move the text document to the desktop folder and remove the folder name
         * from the file location...
         * 
         * ... then the text document will be read and all of the text gets displayed on the game board which is
         * actually a new text box feature sitting on top of the game board. I reviewed the tutorial video I followed
         * and I noticed the feature the person created was a text box instead of a button.
         * 
         * Perhaps the reason why the game could not read my text document from the folder it was in was
         * because my folder's name had an underscore '_' ? Hmm. Let me test that hypothesis.
         * 
         * OK. I moved my text document to a new folder called 'New folder' with a space then launched the game
         * and then pressed the button and it still worked.
         * 
         * Finally, let me move my text document- No, let me add the underscore symbol between 'New' and 'folder'
         * then change the file location and see what happens...
         * 
         * ... Well, that was unexpected. The text document still got read and displayed.
         * 
         * Hmm... if I move my text document back to the original folder...
         * 
         * What?! It works now. Gosh darn it.
         * 
         * OK, end the recording now (15 minutes and counting).
         */
        // string openFile = @"""C:\Users\[redacted]\OneDrive\Desktop\[redacted]\Visual instructions for Nathans Snake Game_06-December-2024.png""";




        public Form1()
        {
            InitializeComponent();

            /* 
            * COMPLICATED SECTION A - SETTING UP THE GAME START-UP SETTINGS
            * Timestamp in the tutorial video: 15:27 to 15:49
            * 
            * Apparently, the Settings.cs class can be called directly from this
            * Form1.cs class
            * 
            * So, if I understand this correctly, every time the Snake game starts up,
            * the game will load a new copy of the Settings.cs class?
            * 
            * Type:
            * new Settings();
            */

            // new SplashScreen_24_Sep_2024();
            new Settings();
        }

        /*
         * I followed the steps provided in the following YouTube video:
         * 
         * C# Tutorial - Create a Classic Snakes Game in Visual Studio with Windows Forms [UPDATED]
         * 
         * I might provide video timestamps such as 10:34 here and there to remind me
         * which part of the almost one hour long video I followed for helping me do things.
         */




        /*
         * CREATING THE CONTAINERS
         * Timestamp in the tutorial video: 7:55 to 10:17
         * 
         * Click on Form1.cs [Design] which should send you back to the Windows Form
         * or your actual game.
         * 
         * From here, you will need to create the following six sections or whatever
         * these are called:
         *
         *(1) KeyIsDown, (2) KeyIsUp, (3) StartGame, (4) TakeSnap),
         * (5) GameTimerEvent, and (6) UpdatePictureBoxGraphics.
         * 
         * Nathan will now provide additional code comments for each container...
         */




        /* To create the KeyIsDown container, click on the Form1.cs Design class window,
         * then click anywhere on the Windows Form except the features you added,
         * for example the Start and Snapshot buttons.
         * 
         * Then, find the Properties window (bottom-right side of your screen) and find
         * the row of icons which look like tiny pictures at the top of Properties.
         * 
         * Find and click on the lightning bolt icon on the far right side (called 'Events')
         * and you should see a rather long list of confusing form fields such as KeyDown
         * and KeyUp.
         * 
         * Speaking of KeyDown and KeyUp, you will want to click on the empty fields
         * on the right of these form fields. These empty fields are where you will finally
         * enter the names 'KeyIsDown' and 'KeyIsUp', respectively, and then, hopefully,
         * Visual Studio should redirect you to this Form1.cs window and show
         * new containers called 'KeyIsDown' and 'KeyIsUp'.
         */

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            /*
             * CODING FOR THE KEYS - KEY DOWN and KEY UP
             * Timestamp in the tutorial video: 15:49 to 18:15
             * 
             * These KeyCode things are quite confusing.
             * 
             * Why can I not just put '...&& Settings.directions == "left" '?
             * 
             * I could try that later. 
             * 
             * The tutorial video mentioned that the typical Snake game does not
             * allow the snake to turn right when the snake is already facing left.
             * 
             * I think I understand that...
             */

            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
                // Failed: gameTimer.Enabled = true;
               
                //goRight = false;
                //goUp = false;
                //goDown = false;
            }

            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;

                //goLeft = false;
                //goUp = false;
                //goDown = false;
            }

            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;

                //goLeft = false;
                //goRight = false;
                //goDown = false;
            }
            
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;

                //goLeft = false;
                //goRight = false;
                //goUp = false;
            }

            // 20th September update (function change, failed):

            /*
                 * I would like to make the Space bar on the keyboard
                 * do nothing.
                 * 
                 * Currently, pressing the Space bar triggers the game to end,
                 * the congratulatory message to show up, and the 'Save as file'
                 * dialogue box to open. I do not want these actions to happen.
                 */

            // No. No. No.

            //if (e.KeyCode == Keys.Space)
            //{
            //    // Failed code: e.SuppressKeyPress = true;

            //}

            // 30th September update (function update, to be confirmed (TBC))
            // Add to version 3
            /* 
             * I just tested the KeyIsDown() and KeyIsUp() containers or functions with 
             * the gameTimer feature being set to true when the Space bar is down and vice versa
             * - being set to false when the Space bar is up, - and it worked!
             * 
             * I did not take a video of the new function but I can do so right now (7:53pm AEST, stopped and
             * vanished at 8:28pm.)
             * 
             * Let me finish adding the ELSE statements to provide the other action the
             * IF statements for the Space bar will perform i.e., if the Space bar is not up, then
             * let the game resume.
             * 
             * OK. I created another issue: The Space bar still pauses the game but when I try to
             * move the snake sprite using the arrow keys, those keys also pause the game when
             * held.
             * 
             * ...
             * 
             * OK. The Space bar still pauses the game and pressing the Space bar again still
             * advances the sprite by one pixel or whatever it is called, however I discovered the
             * game resumes when I press on the arrow keys.
             * 
             * I have given up on trying to make the Space bar do something it may be unable to do
             * and have shifted gear. Using these lines of code:
             * 
             * KeyIsDown() container / function:
             * 
             * if (e.KeyCode == Keys.Space)
            {
                ;
            }

             * KeyIsUp():
             * 
             * if (e.KeyCode == Keys.Space)
            {
                gameTimer.Enabled = false;
                gameTimer.Enabled = true;
            }

             * The player can press the Space bar and their game
             * will not be paused or resumed. The Space bar now
             * does nothing as is desired earlier in September 2024.
             * 
             * Change expectations and goals and I will not feel
             * unhappy.
             */

            //if (e.KeyCode == Keys.Space)
            //{
            //    ;
            //}

            //else
            //{
            //    gameTimer.Enabled = false;
            //}


            // 30th September update cont.

            // With this code, holding the Space bar pauses the game.
            // This code also works the other way around: letting go of the Space bar resumes the game.

            //if (e.KeyCode == Keys.Space)
            //{
            //    gameTimer.Enabled = false;
            //}

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            /*
             * Copy and paste the code from KeyIsDown to this container and
             * then remove everything to the right of Keys.Left, Keys.Right and so
             * on.
             * 
             * Then, change the 'true' values next to goLeft, goRight and so on
             * to 'false'.
             */

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                // Failed: gameTimer.Enabled = false;

                goRight = false;
                goUp = false;
                goDown = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;

                goLeft = false;
                goUp = false;
                goDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;

                goRight = false;
                goLeft = false;
                goDown = false;
            }
            
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;

                goUp = false;
                goRight = false;
                goDown = false;
            }

            // if (e.KeyCode == Keys.Space) // || e.KeyCode == Keys.Enter) // The Enter key does close the game.
            // {
                // 20th September update (function change) continued:

                // Unnecessary code: GameOver();
                // Failed code: e.KeyCode = Keys.None;
                // Failed code: TakeSnapshot() = false;
                // Unnecessary code: Close();

                // 24th September attempt: Failed
                // Close();

                // 30th September update (function update, to be confirmed (TBC))

                /* Well, now I know how to make the Space bar do nothing while the
                 * game is being played:
                 * 
                 * Type:
                 * gameTimer.Enabled = false;
                 * gameTimer.Enabled = true;
                 */

                //gameTimer.Enabled = false;
                //gameTimer.Enabled = true;

                // Well, this works at least.
                // startButton.Text = "Resume";
            // }

            //else if (e.KeyCode == Keys.Space)
            //{
            //    gameTimer.Enabled = true;
            //    // startButton.Text = "Start";
            //}

            //else if (e.KeyCode == Keys.Space)
            //{
            //    gameTimer.Enabled = true;
            //}


            // Failed code: else
            //{
            //    RestartGame();
            //}
        }

        /* 
         * As for the remaining four containers (StartGame to UpdatePictureBoxGraphics,
         * you need to repeat the steps provided in lines XX to XX.
         * 
         * Or, long story short: Click on Form1.cs [Design], then find Properties and
         * find and click on the lightning bolt and find KeyDown first.
         * 
         * Click on the empty field on the right and enter an appropriate name using
         * the appropriate C# naming convention (Pascal Case, where each word in
         * the name begins with an uppercase letter i.e., PascalCase).
         * 
         * Then, hit the Enter button on your keyboard to make sure your
         * container name is recognised.
         * 
         * Finally, wait for Visual Studio to show you this window you are looking at
         * now (Form1.cs)
         */

        //private void MouseIsDown(object sender, MouseEventArgs e)
        //{
        //    // bool move;

        //    // if (e.KeyCode == Keys.Left && Settings.directions != "right")
        //    //if (e.Button == MouseButtons.Left)
        //    //    goLeft = true;
        //    //    goRight = true;
        //    //    goUp = true;
        //    //    goDown = true;  

        //    //if (e.Button == MouseButtons.Left && Settings.directions != "left")
        //    //    goRight = true;

        //    //if (e.Button == MouseButtons.Left && Settings.directions != "down")
        //    //    goUp = true;

        //    //if (e.Button == MouseButtons.Left && Settings.directions != "up")
        //    //    goDown = true;
        //}

        //private void MouseIsUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //        goLeft = false;

        //    if (e.Button == MouseButtons.Left)
        //        goRight = false;

        //    if (e.Button == MouseButtons.Left)
        //        goUp = false;

        //    if (e.Button == MouseButtons.Left)
        //        goDown = false;
        //}

        private void StartGame(object sender, EventArgs e)
        {
            /*
             * SETTING UP STARTGAME and RESTARTGAME 
             * Timestamp in the tutorial video: 18:17 to 23:41
             * 
             */

            // Apparently, this is it for StartGame().
            // Open the RestartGame() container for the rest of this adventure.

            RestartGame();
        }

        private void TakeSnapshot(object sender, EventArgs e)
        {
            /*
             * SETTING UP TAKESNAPSHOT and ADDING A COMMENT
             * Timestamp in the tutorial video: 44:38 to 49:15
             */

            // Great Lord... I just sighed out of tiredness.

            /* 
             * Here, you will enter lines of code to set up the TakeSnapshot()
             * container which will make the Take Photo feature functional.
             * 
             * You will also enter lines of code to make a 'leading comment'
             * appear on the Windows Form. I might be wrong about the
             * Windows Form.
             */

            /* 
             * Enter these lines of code to create a local variable (as opposed to
             * a foreign variable, pun intended) called 'caption'.
             *
             * From here, you will set up multiple properties relating to the caption
             * variable such as caption.Text, where you can type in an appropriate
             * congratulatory comment directed at yourself or other potential players,
             * and caption.Width, where you can specify how wide or horizontally
             * long the caption should be.
             */

            Label caption = new Label();
            caption.Text = "Woohoo! Your snake ate " + score + " apples. Your highest score" + Environment.NewLine + " in this session was " + highestScore + " apples! :D";

            caption.Font = new Font("Arial", 12, FontStyle.Bold);
            caption.ForeColor = Color.Black; // Color.White (dark version only);




            /* 
             * 24th September 2024 update (bug fix, add to version 2):
             * I wanted to find out how to get rid of the background
             * behind my congratulatory comment / caption.
             * 
             * For whatever unknown reason, the caption takes
             *  on the background colour of the picCanvas /
             *  game board.
             *  
             *  I lately found a solution which you can see below:
             *  
             *  Type:
             *  caption.BackColor = Color.Transparent;
            */

            caption.BackColor = /*picCanvas.BackColor;*/ Color.Transparent /*(add to version 2)*/;

            caption.AutoSize = false;
            
            caption.Width = picCanvas.Width;
            caption.Height = 50;// picCanvas.Height;
                             // - So this is how to make the caption appear on the middle of the screen!
            
            caption.TextAlign = ContentAlignment.MiddleCenter;




            /* 
             * Apparently, this line of code shows the caption at the top of
             * the picCanvas feature.
             */

            picCanvas.Controls.Add(caption);

            /* 
             * 24th September 2024 update (bug fix, failed):
             * ...sorry I was thinking to myself. I will try to shift the position
             * of the congratulatory caption to the middle.
            */

            //caption.ImageAlign = ContentAlignment.MiddleCenter;



            /* 
             * Then, enter these lines of code which will set up the
             * default or pre-selected file saving options such as 
             * the leading comment seen in dialogue.FileName that
             * should appear already as soon as you click on
             * the Take Photo button and the dialogue box
             * opens.
             * 
             * Regarding dialogue.Filter, the Filter property apparently
             * gives you the option to save your photo as a JPEG
             * photo file format or any other photo file format.
             */

            SaveFileDialog dialogue = new SaveFileDialog();
            dialogue.FileName = "Snake Game result_DD-MM-YYYY";
            dialogue.DefaultExt = "jpg";




            // Failed code: string[] value = { "JPEG Image File | *.jpg", "PNG Image FIle | *.png" };
            // Failed code: string[] fileFormat = value;
            dialogue.Filter = "JPEG Image File | *.jpg" +

            // 19th September update (bug fix two, add to version 2):
            // As it turns out, the Filter property CAN include multiple file formats.
            // Make sure you separate the file formats with the pipe symbol |
                "| PNG Image File | *.png" + "| GIF Moving Image File | *.gif";




            // Unnecessary code: dialogue.SupportMultiDottedExtensions = true;
            // Failed code: dialogue.Filter = "PNG Image File | *.png";

            // Failed code: if (dialogue.DefaultExt != "jpg")
            // {
            // dialogue.DefaultExt = "png";
            // dialogue.Filter = "PNG Image File | .png";
            // }
            ;





            /*
             * The dialogue.ValidateNames property will check for unallowed
             * characters on Windows computers such as
             * punctuation marks - comma and apostrophes.
             * 
             * It might also check if you have saved another file with
             * the same name?
             */

            dialogue.ValidateNames = true;




            /*
            * SETTING UP THE 'OK' BUTTON IN THE
            * DIALOGUE BOX
            * Timestamp in the tutorial video: 49:17 to 52:47 
            */
            /* 
             * Now, you will set up what happens when you click on the OK
             * button.
             * 
             * Before you type any more code in this container, please
             * scroll up to the very top of the project where the 'using'
             * namespaces or whatever they are officially called and
             * add the following namespace below the last namespace:
             * 
             * using System.Drawing.Imaging
             */




            // Welcome back! Now, we march forward towards the finish line.

            // This code is still confusing but I will try my best to explain in
            // simple words.

            /*
             * Create an IF statement which looks at the OK button on the
             * dialogue box that opens when the player clicks on
             * 'Take Photo'.
             * 
             * Then, create two int variables and call them 'width' and 'height',
             * and assign 'Convert.ToInt32' as the value for both variables which
             * I think converts the width and height of the picCanvas feature
             * into numbers.
             * 
             * Then, create a bitmap variable which uses the width and height
             * of the picCanvas feature.
             * 
             * Then, call up the picCanvas.DrawToBitmap property and
             * enter the bitmap and a new rectangle shape.
             * 
             * The rectangle shape will have 0 as both the X and Y
             * coordinates as well as use the width and height of the
             * picCanvas feature.
             */

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);

                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                
                
                
                /*
                 * Save the bitmap which provides the snapshot or photo with
                 * a name that contains the text added to dialogue.FileName and
                 * the JPEG file format specified and provided by the
                 * extra namespace or class (Drawing.Imaging).
                 */

                bmp.Save(dialogue.FileName, ImageFormat.Jpeg);




                /* 
                 * Finally, make the caption that I think appears on the 
                 * picCanvas feature or the Windows Form disappear
                 * once the photo has been saved.
                 */

                picCanvas.Controls.Remove(caption);

                // All done! Click on Start on the top bar and test your game!
            }




            // 19th September update (bug fix one, add to version 2):

            /*
             * First bug fix for the Snake game and this one was not easy -
             * nothing is to me, - but I solved the bug concerning clicking
             * on the Cancel button and the congratulatory comment still
             * showing at the top of the picCanvas element by making
             * this code below:
             * 
             * Thank goodness for ELSE statements!
             */

            /* For future reference regarding the code structure for
             * functions of Windows Forms features or elements:
             * 
             * 1 - assigned name of the Windows Forms feature i.e., picCanvas
             * 2 - specify the property that belongs to the feature i.e., Controls
             * 3 - carefully read the actions in the list and experiment with
             * the actions you think mean what they think i.e., Clear
             * 4 - Close the function with the rounded brackets and a semicolon (); 
             */

            else
            {
                picCanvas.Controls.Clear();
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            /*
             * DETERMINING THE DIRECTIONS
             * Timestamp in the tutorial video: 28:22 to 37:00
             * 
             * Apparently, this code below is all you need to enter to
             * determine the directions that the snake sprite goes towards
             * when pressing the keys on your keyboard.
             */

            if (goLeft)
            {
                Settings.directions = "left";
            }

            if (goRight)
            {
                Settings.directions = "right";
            }

            if (goDown)
            {
                Settings.directions = "down";
            }

            if (goUp)
            {
                Settings.directions = "up";
            }




            // Great, another FOR loop.

            /* Create a FOR loop and name the int variable 'Snake.Count - 1'.
             * Also, change the iterator from 'i++' to 'i--'. Not sure why but I can
             * find out later.
             * 
             * This FOR loop will enable the snake sprite to move. Huh...
             * 
             * Apparently, to make the snake sprite move to the right, you need
             * to add a value of 1. Now this sort of makes sense for adding a value
             * of 1 to make the snake sprite move down.
             * 
             */

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0) // Value 0 represents the position of the snake head.
                {
                    switch (Settings.directions)
                    {
                        case "left": // 'Case' is used in relation to string variables i.e., Settings.directions.
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }




                    /* 
                     * The code below tells the snake sprite when it reaches the
                     * boundary of the Windows Form to reappear on the opposite
                     * side of the Windows Form.
                     * 
                     * For example, when the snake sprite reaches the left boundary
                     * of the Windows Form, the snake sprite will reappear from the
                     * right boundary line and vice versa.
                     */

                    if (Snake[i].X < 0)
                    {
                        //Snake[i].X = maxWidth;
                        GameOver();
                    }

                    if (Snake[i].X > maxWidth)
                    {
                        //Snake[i].X = 0;
                        GameOver();
                    }

                    if (Snake[i].Y < 0)
                    {
                        //Snake[i].Y = maxHeight;
                        GameOver();
                    }

                    if (Snake[i].Y > maxHeight)
                    {
                        // Original code used in version 1.1:
                        //Snake[i].Y = 0;

                        // 19th September update (bug fix three, add to version 2):

                        /*
                         * So this is how I get the snake head touching the
                         * edges of the picCanvas to end the game.
                         * 
                         * Comment out the previous code i.e., Snake[i]...
                         * and enter the GameOver() container (or function,
                         * it is confusing)
                         */

                        GameOver();
                    }




                    /* 
                     * PROGRAMMING EATFOOD AND GAMEOVER
                     * Timestamp in the tutorial video: 38:45 to 41:26
                     */

                    /* 
                    * After setting up the EatFood() container, open this
                    * GameTimerEvent() container again and create
                    * another IF statement which looks for matching
                    * X and Y coordinates of the snake sprite and
                    * food sprite.
                    * 
                    * Where the coordinates match, the food sprite
                    * will disappear and reappear elsewhere on the
                    * Windows Form randomly.
                    * 
                    * Type:
                    *  if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                   {
                       EatFood();
                    */

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }




                    /*
                     * Then, create another FOR loop and change the letter 'i'
                     * to 'j'. If this confuses you, another expression for the above
                     * is change 'i' for information to 'j' for jam.
                     * 
                     * Create an IF statement which looks at the X and Y
                     * coordinates of both the snake's head and body and,
                     * if the coordinates match, triggers the code in the
                     * GameOver() container.
                     */

                    /*
                     * Also, to avoid further confusion, where Snake[i] is used,
                     * the snake's head is being modified.
                     * 
                     * Where Snake[j] is used, the snake's body is being modified.
                     */

                    /*
                     * Type:
                     * for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                     */

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }




                /* 
                 * By the way, I messed up earlier when the containers from
                * I think StartGame() were mistakenly fitted into KeyIsUp()
                * which possibly caused the design-time error screen on the
                * Windows Form.
                * 
                * On the error screen, I clicked on 'Ignore and Continue' and
                * the Windows Form returned to the screen but looked wiped.
                * 
                * I then tried to restore the Windows Form to its former state and
                * the restoration process was going well until I discovered an issue
                * with changing the name of a label feature to its final name.
                * 
                * In short, when I tried to give the final name to the label and then a 
                * button, Visual Studio said there was already something with the
                * final name. I know what it meant. That means that the final names
                * of the features before I messed up are still recognised.
                * 
                * How on planet Earth could I remedy this issue?
                */

                /* 
                 * REMEDY UPDATE
                 * 16th September update: The remedy was carefully copying and pasting
                 * the code from the first curly bracket or thereabouts in the
                 * Nathans project into this new SnakeGame project.
                 */




                /*
                 * DETERMINING THE DIRECTIONS - CONTINUED
                 * Timestamp in the tutorial video: 28:22 to 37:00
                 * 
                /* 
                 * Finally, this code below tells the body of the snake how to
                 * move.
                 * 
                 * Somehow, this code makes the snake look like it is crawling
                 * up and down the Windows Form.
                 */

                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            /* 
             * This code below triggers the snake sprite to be re-painted after
             * moving across or down the Windows Form.
             */

            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            /*
             * PAINTING THE SNAKE SPRITE
             * Timestamp in the tutorial video: 23:43 to 28:21
             */

            // Not sure how the guy in the tutorial video came up with Graphics as a class.
            // Here, you will deal with the painting side of things.
            Graphics canvas = e.Graphics;




            // Now, colour the snake's head... somehow.

            /* 
             * Create a variable and name it appropriately, then create a FOR loop,
             * then enter the name of the variable and assign a colour which
             * apparently is provided by something called 'Brushes'.
             */

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }




                /* 
                 * Create a new rectangle and determine the X value, the Y value,
                 * the height, and the width of the snake sprite.
                 */

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    )
                                            );
            }




            /* 
             * Create another new rectangle and determine the X value, the Y value,
             * the height, and the width of the food sprite.
             */

            canvas.FillEllipse(Brushes.Red, new Rectangle
                    (
                    food.X * Settings.Width,
                    food.Y * Settings.Height,
                    Settings.Width, Settings.Height
                    )
                                            );
        }

        //private void MouseIsOn(object sender, EventArgs e)
        //{
        //    // 25th September 2024 update (hopeful function addition, failed):
        //    // ADDING INSTRUCTIONS - MOUSE HOVER AND LEAVE

        //    /* 
        //     * Hello, Nathan.
        //     * 
        //     * This container / function will hopefully allow a new text box
        //     * which says 'Instructions for the player' to, at least, change colour
        //     * when the mouse hovers over it and leaves it.
        //     * 
        //     * This stage uses two functions: MouseIsOn() and MouseIsOff().
        //     * 
        //     * The role this function plays is to help the player know when
        //     * their mouse has rolled over and rolled off the instructions text.
        //     */

        //    if (true)
        //    {
        //        /*
        //         * Another IF statement. *sighs*
        //         * 
        //         * I would like for the instructions text to not only change colour but
        //         * also change opacity or transparency i.e., 100 per cent when
        //         * the mouse is on to 50 per cent when the mouse is off.
        //         */

        //        // At first, I followed the steps provided in this video on YouTube:
        //        // How to set the opacity or transparency of a Panel in C# Winform .NET

        //        /* While the line of code below works fine, the Color.FromArgb structure
        //         * only works on panels or background layers.
        //         * 
        //         * I found another video on YouTube:
        //            * C# : how to change transparency of a color in c#
        //         * 
        //         * I will try out this line of code which may not work: Color.Transparency = 0.5f
        //         * 
        //         * I may have used Color.Transparency before in another function but
        //         * the numeric value i.e., 0.5f is a new concept. Apparently, this section of code
        //         * will make the level of transparency 50 per cent...
        //         */

        //        // textBox1.ForeColor = Color.FromArgb(100, Color.Orange);

        //        /* 
        //         * Well, the code produced an error that said Color.Transparent cannot be assigned
        //         * to because it is 'read only'.
        //         * 
        //         * If I test the code now... (10:23pm)
        //         * 
        //         * (10:28pm) I changed the foreground colour to orange.
        //         * I also changed the foreground colour on startup in the
        //         * Design window to dim gray.
        //         * 
        //         * I then modified the colour in MouseIsOff() to dim gray
        //         * so that the instructions text returns to dim gray when
        //         * the mouse is off the text.
        //         */
        //        textBox1.ForeColor = Color.Orange;
        //    }
        //}

        //private void MouseIsOff(object sender, EventArgs e)
        //{
        //    if(true)
        //    {
        //        textBox1.ForeColor = Color.FromArgb(0, Color.DimGray);
        //    }
        //}

        //private void OpenInstructions(object sender, MouseEventArgs e)
        //{
        //    // 25th to 26th September 2024 update (hopeful function addition, failed):
        //    // ADDING INSTRUCTIONS - OPEN AND READ INSTRUCTIONS

        //    /* 
        //     * In the evening of 25th September, I also added these functions,
        //     * OpenInstructions() and ReadInstructions().
        //     * 
        //     * Good luck.
        //     * 
        //     * I will follow the steps provided in this video on YouTube:
        //     * 
        //     * Read text file contents and show them in C# windows application
        //     */
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ;
        //    }
        //}

        //private void GameInstructions_Click(object sender, EventArgs e)
        //{
        //    if (File.Exists(openFile))
        //    {
        //        string textContents = File.ReadAllText(openFile);
        //        ;
        //    }
        //}

        //private void ReadInstructions(object sender, MouseEventArgs e)
        //{
        //    if (File.Exists(openFile))
        //    {
        //        string readText = File.ReadAllText(openFile);
        //        picCanvas.Text = readText;
        //    }
        //}

        private void OpenInstructions(object sender, EventArgs e)
        {
            // SHOWING THE INSTRUCTIONS IN A NEW WINDOW (add to version 3) - UNUSED
            // I think I found my own solution to my own problem!

            /*
             * I wanted to have my instructions show up on the
             * picCanvas feature in the game and I managed to get
             * that working as seen in the previous video recording.
             * 
             * However, the text formatting made my instructions
             * unreadable or at least difficult to read clearly.
             * 
             * So, I spent plenty of time this afternoon trying to
             * figure out how to make my instructions appear
             * with text formatting I desired.
             * 
             * Additionally, I wanted to make the instructions appear
             * after clicking on a button i.e., Game instructions.
             * 
             * Now, after some time, I think I got it to work.
             * 
             * 
             * 
             */

            //picCanvas.Controls.Clear();

            //GameInstructions_26092024 instructionsLaunch = new GameInstructions_26092024();
            //instructionsLaunch.Show();
            //this.Hide();

            //if (File.Exists(openFile))
            //{
            //    string readText = File.ReadAllText(openFile);

            //    instructions.Text = readText;

            //    Label gameInstructions = new Label();
            //    gameInstructions.ForeColor = Color.White;
            //    gameInstructions.BackColor = Color.Transparent;
            //    gameInstructions.Font = new Font("Arial", 12, FontStyle.Bold);
            //    gameInstructions.TextAlign = ContentAlignment.MiddleCenter;
            //}

            //instructions.Controls.Clear();


            // SHOWING THE INSTRUCTIONS (add to version 3)
            // 5th December 2024 update
            /*
             * I am back to coding the last new things for Nathan's Snake Game v3.
             * 
             * I have my design plan for a game menu feature which may be more
             * trouble than it is worth doing.
             * 
             * Also, I am going to eventually find a way to make my
             * text document containing the game instructions appear directly over
             * the game board. Or, actually, I may create a visual aid showing
             * which keys on the keyboard the player should press in order to play
             * the game and take screenshots of their most recent game.
             * 
             * I can do that now. -- end at 8:53pm
             */



            // 6th December 2024 update
            /*
             * OK, I exported the visual instructions for Nathan's Snake Game.
             * 
             * Maybe I can still use the openFile string variable to load the
             * visual instructions?
             */

            //string instructions;

            //if (File.Exists(openFile))
            //{
            //    string readText = File.ReadAllText(openFile);

            //    instructions.Text = readText;
            //}

            //gameInstructions.Controls.Clear();
            //Form1 showInstructions = new Form1();
            //gameInstructions.Controls.Add(showInstructions);
            //showInstructions.Show();
            //this.Hide();

            //if (File.Exists(openFile))
            //{
            //    string readText = File.ReadAllText(openFile);

            //    openFile.Text = new readText();
            //    readText.Show();
            //    this.Hide();

            //}

            //            string openFile = @"C:\Users\[redacted]\OneDrive\Desktop\[redacted]\Visual instructions 
            //for Nathans Snake Game_06-December-2024.png";

            // OK, this works but this is not what I wanted to do.

            // picCanvas.Controls.Clear();
            //Form1 showInstructions = new Form1();
            //showInstructions.TopLevel = false;
            //picCanvas.Controls.Add( showInstructions );
            //showInstructions.Show();


            /* 
             * Why is it so hard to achieve what I want to achieve? I want to be able to click on
             * the Game Instructions button and see my visual instructions. Why is this so hard?
             */

            //instructions.Controls.Add(openFile);
            //if (File.Exists(openFile))
            //{
            //    string readText = File.ReadAllText(openFile);

            //    instructions.Text = new readText();

            //}



            // var img = Resource1.Visual instructions for Nathans Snake Game_06 - December - 2024;

            // this.Opacity = 25.00;
            
            

            /* 
             * After a lot of trial and error, this code below does what I wanted to achieve:
             * Clicking on a button called 'Game Instructions' opens an image showing visual instructions for
             * playing Nathan's Snake Game in any version.
             * 
             * Additionally, I added two other features: a background layer that blocks out the game
             * board and, hopefully, helps the player focus on reading the instructions (which appears in quite
             * poor, pixelated quality. There may be a way to increase the image quality) and a red button named
             * 'Return to game' which, hopefully, when clicked on will close the visual instructions,
             * the background layer, and the button itself and return the player to the game board.
             */

            visualInstructions.Show();
            returnToGame.Show();
            backgroundFill.Show();


            //visualInstructions.Image = new Bitmap("C:\\Users\\natha\\OneDrive\\Desktop\\Frustrating to make games_03-August-2024\\Visual instructions + " +
            //    "for Nathans Snake Game_06-December-2024.png");


        }

        private void ReturnToGame(object sender, EventArgs e)
        {
            // CLOSING THE INSTRUCTIONS AND RETURNING TO THE GAME BOARD (add to version 3)
            // 6th December 2024
            
            // Now, for the moment I have been waiting for...

            visualInstructions.Hide();
            returnToGame.Hide();
            backgroundFill.Hide();

            // This code works! Happy days, Nathan. Happy days!
        }



        /* private void MoveSprite(object sender, MouseEventArgs e)
        {
            /*
             * SELF-LEARNING TIME: MAKING THE SNAKE SPRITE
             * MOVABLE USING A TRACKPAD OR AN EXTERNAL MOUSE
             

            
             * Good luck here, Nathan, you smart meerkat.
             * 
             * I would like to be able to move the snake sprite using the trackpad
             * that came with my laptop OR an external mouse.
             
            
        
            if (MouseButtons)
            {
                ;
            }
            if (MouseButtons.Left)
            {
                ;
            }
        } */

        private void RestartGame()
        {
            /*
             * This code apparently creates padding around the edge of the game 
             * prevent the snake sprite from going beyond the edge
             * 
             * This code will make everything from the finished game disappear and
             * reset the game for the next game.
             */

            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();




            /* 
             * Apparently, if the buttons are enabled upon start-up, you cannot 
             * the keys on the keyboard to move the snake sprite.
             * 
             * This is why the buttons are marked as false.
             */

            startButton.Enabled = false;
            snapButton.Enabled = false;




            // Ah, I forgot about the way to include spacing between words.

            /* 
             * You have to add the space after the first piece of text i.e. "Score: "
             * or at the beginning of the next piece of text i.e., " and ladders" .
             */

            score = 0;
            textCurrentScore.Text = "Score: " + score;




            // Now to create the body parts of the snake sprite:
            Circle head = new Circle { X = 15, Y = 15 }; // Previous co-ordinates were X = 10, Y = 5
            Snake.Add(head);

            /* 
             * 12:11pm on 16th September 2024 update:
             * 
             * Yay, I wanted to change the starting length of the body and
             * remembered I typed number 10 somewhere.
             * 
             * I changed 'i < 10' to
             * 'i < 1' and clicked on Start on the top bar and it worked!
             */
            for (int i = 0; i < 1; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }




            //  Create the food variable.
            /*
             * 'rand.Next' is used to generate the food sprite on a random spot
             * in the game.
             * 
             * '2' indicates somewhere off the side of the Windows Form and
             * indicates the boundary of the game inside which the food sprite
             * should generate.
             * 
             * The maxWidth and maxHeight variabes have been added to indicate
             * the other boundary of the game.
             * 
             * In this way, the food sprite should hopefully only generate within the
             * size of the Windows Form. Hopefully.
            */


            food = new Circle
            {
                X = rand.Next(2, maxWidth),
                Y = rand.Next(2, maxHeight)
            };

            // Create the game timer. The code for this will be done later on.
            // Now, move on to the UpdatePictureBoxGraphics() container!
            gameTimer.Start();

        }

        private void EatFood()
        {
            /*
             * SOMETHING TO DO WITH THE FOOD SPRITE
             * BUT ACTUALLY THIS SECTION IS MORE TO DO
             * WITH ENLARGING THE SNAKE SPRITE AND
             * KEEPING SCORE
             * Timestamp in the tutorial video: 37:02 to 38:44
             */

            // Oh, I think I just realised why I had to add 'score += 1'.

            /* 
             * Every time the snake sprite reaches the food sprite, the
             * score increases by a value of 1. 
             * 
             * So, this line of code and the next line of code helps
             * the Windows Form to keep track of the score or
             * keep updated with the score in real time.
             */

            score += 1;

            // I think I added this line of code somewhere before...
            textCurrentScore.Text = "Score: " + score;




            //  Add a new circle to the end of the snake sprite or 'index'.

            // I guess 'Snake.Count - 1' adds a new circle to the end of the
            // snake sprite.

            // I am still unsure why I have to use 'Snake.Count - 1'.
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y,
            };




            /* 
             * Apparently, this line of code adds the new circle to the
             * end of the snake sprite. One by one?
             */

            Snake.Add(body);




            /* 
             * Then, open the RestartGame() container and copy and
             * paste the code for the food sprite into this container.
             */

            food = new Circle
            {
                X = rand.Next(2, maxWidth),
                Y = rand.Next(2, maxHeight)
            };
        }

        private void GameOver()
        {
            /* 
             * ENDING THE GAME
             * Timestamp in the tutorial video: 41:26 to 44:38
             */

            // Apparently this line of code stops the game.
            gameTimer.Stop();




            /* 
             * When the snake sprite collides with itself and
             * the game stops, these two lines of code will
             * re-activate the Start and Take Photo buttons
             * to allow the player to replay the Snake game.
             */

            startButton.Enabled = true;
            snapButton.Enabled = true;




            // Oh, god, not another IF statement.

            /* 
             * Create an IF statement which looks at the current
             * score and highest score so far in a single gameplay
             * session.
             * 
             * This IF statement only applies to replayed games or
             * to the second game in a single gameplay session.
             */
            



            if (score > highestScore)
            {
                highestScore = score;


                // Ah, I forgot about these changes to the code.
                
                /*
                 * These three lines of code were originally active, however having
                 * tested the game in the Windows Form with the original code and
                 * preferring the ''Highest Score: " to appear as it did originally before
                 * coding.
                 * 
                 * So, there is no need for the highest score to appear on a new line
                 * and / or to appear with middle-centre text alignment.
                 * 
                 * Where the unnecessary code is, I enclosed them within code comment
                 * symbols i.e. // double forward slashes or / * * / slash-asterisk then asterisk-slash.
                 */

                textHighestScore.Text = "Highest Score: " /* + Environment.NewLine */ + highestScore;
                textHighestScore.ForeColor = Color.Purple; // Color.Yellow (dark version only);
                // textHighestScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }


}   
