using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;

using InputManager; // third party library with DirectX support :D
using System.Diagnostics; // for Stopwatch

namespace MonkeyGamerGUI
{
    public partial class Form1 : Form
    {
        private bool isRecordingInput = false;
        private List<int> keysToEmulate;
        private bool isEmulatingInput = false;
        private System.Threading.Thread emulationThread;

        public Form logWindowForm;

        public string lastLogItem = "";

        //public int randomSeed = 1234567890;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyboardHook.KeyDown += new KeyboardHook.KeyDownEventHandler(UserInputHandler);
            KeyboardHook.InstallHook();

            keysToEmulate = new List<int>();

            this.TopMost = true;
        }

        public void testButton_Click(object sender, EventArgs e)
        {
            // ListViewItem LVI = testListView.Items.Add("Testing");

            if (!isRecordingInput) 
            {
                isRecordingInput = true;
                testButton.Text = "Stop Recording";
            }
            else if (isRecordingInput) 
            {
                isRecordingInput = false;
                testButton.Text = "Start Recording"; 
            }
        }        

        void UserInputHandler(int vkCode) // called on key down
        {
            if (isRecordingInput) // only handle input if we're recording
            {
                string stringName = ((Keys)vkCode).ToString();

                ListViewItem existingItem = testListView.FindItemWithText(stringName);
                if (existingItem == null) // only add if not a duplicate
                {
                    ListViewItem itemInListView = testListView.Items.Add(stringName);
                    itemInListView.SubItems.Add(vkCode.ToString());

                    keysToEmulate.Add(vkCode);
                }

                /*
                if (!testListView.Items.ContainsKey(stringName))
                {
                    ListViewItem itemInListView = testListView.Items.Add(stringName);
                    itemInListView.SubItems.Add(vkCode.ToString());
                }
                 */
            }
         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startEmulationButton_Click(object sender, EventArgs e)
        {
            

            if (!isEmulatingInput)
            {
                isEmulatingInput = true;
                mainWindowStatusBar.Text = "Starting emulation!";
                
                startEmulationButton.Text = "Stop Emulating";

                //logWindowForm = new LogWindowForm();
                //logWindowForm.Show();

                emulationThread = new System.Threading.Thread(delegate()
                {
                    EmulateInput(
                    (int)keystrokeNumberPicker.Value,
                    (float)keystrokeDelayPicker.Value,
                    keysToEmulate,
                    mouseMovementCheckbox.Checked,
                    mouseClickCheckbox.Checked,
                    scrollWheelCheckbox.Checked,
                    (float)keyHoldDurationPicker.Value,
                    Convert.ToInt32(randomSeedTextBox.Text)
                    );
                });

                emulationThread.Start();
            }
            else if (isEmulatingInput)
            {
                isEmulatingInput = false;
                mainWindowStatusBar.Text = "Emulation stopped.";

                //logWindowForm.Close();

                startEmulationButton.Text = "Begin Emulating";

                emulationThread.Abort();
            }
        }

        void EmulateInput(int numberOfKeystrokes, float keystrokeDelay, List<int> keyCodesToEmulate,
            bool mouseMovement, bool mouseClicks, bool scrollWheel, float keyHoldDuration, int randomSeed)
        {
            // Main emulation function!

            MessageBox.Show("Are you sure? Emulation will start when you press OK.");
            System.Threading.Thread.Sleep(2000);

            ///////////

            Random instanceOfRandom = new Random(randomSeed);
            int mouseClickChance = 25;
            int mouseScrollChance = 25;
            int mouseMoveChance = 25;
                      
            if (numberOfKeystrokes == 0)
            {
                while (true)
                {
                    int currentMouseMovementX;
                    int currentMouseMovementY;
                    int currentKeyCode = 0;

                    if (keyCodesToEmulate.Count > 0)
                         currentKeyCode = keyCodesToEmulate[instanceOfRandom.Next(keyCodesToEmulate.Count)]; // decide the keycode we're sending

                    if (instanceOfRandom.Next(100) < mouseMoveChance) // if the RNG decides we're moving the mouse
                    {
                        currentMouseMovementX = instanceOfRandom.Next(100);
                        currentMouseMovementY = instanceOfRandom.Next(100);

                        if (instanceOfRandom.Next(100) < mouseMoveChance)
                        {
                            currentMouseMovementX = -currentMouseMovementX; // invert
                            currentMouseMovementY = -currentMouseMovementY; // invert
                        }
                    }
                    else // don't move the mouse
                    {
                        currentMouseMovementX = 0;
                        currentMouseMovementY = 0;
                    }

                    ////////

                    if (keyCodesToEmulate.Count > 0) // only emulate if there's something to emulate
                    {
                        //ListViewItem existingItem = testListView.FindItemWithText(((Keys)currentKeyCode).ToString());

                        if (keyHoldDuration == 0) // code for instant release
                        {

                            SelectListItem(((Keys)currentKeyCode).ToString(), true);

                            Keyboard.KeyDown((Keys)currentKeyCode);
                            System.Diagnostics.Debug.WriteLine("Pressed key " + ((Keys)currentKeyCode).ToString());
                            //System.Threading.Thread.Sleep(1000);
                            Keyboard.KeyUp((Keys)currentKeyCode);
                            System.Diagnostics.Debug.WriteLine("Released key " + ((Keys)currentKeyCode).ToString());

                            SelectListItem(((Keys)currentKeyCode).ToString(), false);
                        }
                        else if (keyHoldDuration > 0) // holding code
                        {
                            System.Diagnostics.Debug.WriteLine("Holding key " + ((Keys)currentKeyCode).ToString() + " for " + keyHoldDuration + " seconds");
                            SelectListItem(((Keys)currentKeyCode).ToString(), true);

                            Stopwatch s = new Stopwatch();
                            s.Start();
                            while (s.Elapsed < TimeSpan.FromSeconds(keyHoldDuration))
                            {
                                //Keyboard.KeyPress((Keys)currentKeyCode);
                                // System.Threading.Thread.Sleep(0005);
                                Keyboard.KeyDown((Keys)currentKeyCode);
                            }
                            s.Stop();

                            Keyboard.KeyUp((Keys)currentKeyCode);
                            SelectListItem(((Keys)currentKeyCode).ToString(), false);

                            System.Diagnostics.Debug.WriteLine("Done holding key " + ((Keys)currentKeyCode).ToString());

                        }
                    }

                    if (currentMouseMovementX != 0 && mouseMovement)
                    {
                        Mouse.MoveRelative(currentMouseMovementX, currentMouseMovementY);
                    }

                    if (instanceOfRandom.Next(100) < mouseClickChance && mouseClicks)
                    {
                        // click mouse
                        Mouse.PressButton(Mouse.MouseKeys.Left);
                    }

                    if (instanceOfRandom.Next(100) < mouseScrollChance && scrollWheel)
                    {
                        // scroll mouse
                        Mouse.Scroll(Mouse.ScrollDirection.Up);
                    }

                    System.Threading.Thread.Sleep((int)(keystrokeDelay * 1000)); // wait for the specified delay
                }
            }
            else if (numberOfKeystrokes > 0)
            {
                for (int i = 0; i < numberOfKeystrokes; i++)
                {
                    int currentMouseMovementX;
                    int currentMouseMovementY;
                    int currentKeyCode = 0;

                    if (keyCodesToEmulate.Count > 0)
                        currentKeyCode = keyCodesToEmulate[instanceOfRandom.Next(keyCodesToEmulate.Count)]; // decide the keycode we're sending

                    if (instanceOfRandom.Next(100) < mouseMoveChance) // if the RNG decides we're moving the mouse
                    {
                        currentMouseMovementX = instanceOfRandom.Next(100);
                        currentMouseMovementY = instanceOfRandom.Next(100);

                        if (instanceOfRandom.Next(100) < mouseMoveChance)
                        {
                            currentMouseMovementX = -currentMouseMovementX; // invert
                            currentMouseMovementY = -currentMouseMovementY; // invert
                        }
                    }
                    else // don't move the mouse
                    {
                        currentMouseMovementX = 0;
                        currentMouseMovementY = 0;
                    }

                    ////////

                    if (keyCodesToEmulate.Count > 0) // only emulate if there's something to emulate
                    {
                        if (keyHoldDuration == 0) // code for instant release
                        {
                            Keyboard.KeyDown((Keys)currentKeyCode);
                            System.Diagnostics.Debug.WriteLine("Pressed key " + ((Keys)currentKeyCode).ToString());
                            //System.Threading.Thread.Sleep(1000);
                            Keyboard.KeyUp((Keys)currentKeyCode);
                            System.Diagnostics.Debug.WriteLine("Released key " + ((Keys)currentKeyCode).ToString());
                        }
                        else if (keyHoldDuration > 0) // holding code
                        {
                            System.Diagnostics.Debug.WriteLine("Holding key " + ((Keys)currentKeyCode).ToString() + " for " + keyHoldDuration + " seconds");

                            Stopwatch s = new Stopwatch();
                            s.Start();
                            while (s.Elapsed < TimeSpan.FromSeconds(keyHoldDuration))
                            {
                                //Keyboard.KeyPress((Keys)currentKeyCode);
                                // System.Threading.Thread.Sleep(0005);
                                Keyboard.KeyDown((Keys)currentKeyCode);
                            }
                            s.Stop();

                            Keyboard.KeyUp((Keys)currentKeyCode);

                            System.Diagnostics.Debug.WriteLine("Done holding key " + ((Keys)currentKeyCode).ToString());

                        }
                    }

                    if (currentMouseMovementX != 0 && mouseMovement)
                    {
                        Mouse.MoveRelative(currentMouseMovementX, currentMouseMovementY);
                    }

                    if (instanceOfRandom.Next(100) < mouseClickChance && mouseClicks)
                    {
                        // click mouse
                        Mouse.PressButton(Mouse.MouseKeys.Left);
                    }

                    if (instanceOfRandom.Next(100) < mouseScrollChance && scrollWheel)
                    {
                        // scroll mouse
                        Mouse.Scroll(Mouse.ScrollDirection.Up);
                    }

                    System.Threading.Thread.Sleep((int)(keystrokeDelay * 1000)); // wait for the specified delay
                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SelectListItem(string itemName, bool selected)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ListViewItem existingItem = testListView.FindItemWithText(itemName);
                existingItem.Selected = selected;

                mainWindowStatusBar.Text = "Pressing button: " + itemName;

                //LogWindowForm currentLogWindow = (LogWindowForm)logWindowForm;               
            });   
         
            
        }
    }

    
    
}
