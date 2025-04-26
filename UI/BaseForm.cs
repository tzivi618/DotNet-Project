using System;
using System.Drawing;
using System.Windows.Forms;

public class BaseForm : Form
{
    //private const string BackgroundImagePath = @"images\logo.png"; // נתיב יחסי לתמונה
    private const float FontSize = 12.0f; // גודל הפונט הרצוי

    public BaseForm()
    {
        //this.ClientSize = new Size(1257, 895); // גודל החלון
        this.StartPosition = FormStartPosition.CenterScreen;
        ////this.BackgroundImage = Image.FromFile(BackgroundImagePath);
        //this.BackgroundImageLayout = ImageLayout.Stretch;
        //this.Font = new Font("Arial", FontSize);
        //this.ForeColor = Color.Blue; // הגדרת צבע הפונט לכחול
    }

    protected override void OnLoad(EventArgs e)
    {
        //base.OnLoad(e);
    }

    
}
