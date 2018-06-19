using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using System.Threading;


namespace ZoomPractice
{
    public partial class Form1 : Form
    {

        InputSimulator inputSim = new InputSimulator();
        //bool clicked = false;

        public Form1()
        {
            InitializeComponent();
            txtXPos.Text = "200";
            txtYPos.Text = "200";
            txtMag.Text = "150";

            
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Convert.ToInt16(txtXPos.Text), Convert.ToInt16(txtYPos.Text));

            for(int i = 0; i < Convert.ToInt16(txtMag.Text)/25; i++)
            {
                win_zoom_in();
                Thread.Sleep(100);
            }

        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            /*If this is the first time the zoom is being used, we want to minimize the
            //Windows magnifier window. ##TODO this minimises the program rather than 
            //the magnifier...
            if (!clicked)
            {
                // first Win + '+' opens windows magnifier
                inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LWIN);
                inputSim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.OEM_PLUS);
                inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);

                //minimizes window
                inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LWIN);
                inputSim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.DOWN);
                inputSim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.DOWN);
                inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);

                clicked = !clicked;
            }*/
            win_zoom_in();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            win_zoom_out();
        }

        private void win_zoom_in()
        {
            inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LWIN);
            inputSim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.OEM_PLUS);
            inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);
        }

        private void win_zoom_out()
        {
            inputSim.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LWIN);
            inputSim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.OEM_MINUS);
            inputSim.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LWIN);
        }
    }
}
